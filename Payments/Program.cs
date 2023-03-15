using System;

namespace Payments;

public class Program
{
    public static void Main(string[] args)
    {
        var room = new Room(3);
        room.RoomSoldOut += OnRoomSoldOut;
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
    }


    static void OnRoomSoldOut(object sender, EventArgs e)
    {
        var obj = (Room)sender;

        Console.WriteLine(e.ToString());
    }

}

public class Room
{
    public Room(int seats)
    {
        Seats = seats;
        _seatsInUse = 0;
    }

    private int _seatsInUse = 0;
    public int Seats { get; set; } = 0;

    public void ReserveSeat()
    {
        _seatsInUse++;

        if (_seatsInUse >= Seats)
        {
            OnRoomSoldOut(EventArgs.Empty);
        }
        else
        {
            Console.WriteLine("Assentedo Resevado!");
        }
    }

    public event EventHandler RoomSoldOut;

    protected virtual void OnRoomSoldOut(EventArgs e)
    {
        EventHandler eventHandler = RoomSoldOut;
        eventHandler?.Invoke(this, e);
    }

}

