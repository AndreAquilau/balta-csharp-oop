using System;
using System.Linq;

namespace Collections;

public class Program
{
    public static void Main(string[] args)
    {
        // IList
        // ICollection
        // IEnumerable
        IList<Payment> payments = new List<Payment>() { new Payment(id: Guid.NewGuid()) };

        payments.Add(new Payment(id: Guid.NewGuid()));
        payments.Add(new Payment(id: Guid.NewGuid()));
        payments.Add(new Payment(id: Guid.NewGuid()));
        payments.Add(new Payment(id: Guid.NewGuid()));

        foreach (var row in payments)
        {
            Console.WriteLine(row.Id);
        }

        var paidPayments = new List<Payment>();

        paidPayments.AddRange(payments);

        var payment = payments.Where((p, index) => index == 3).FirstOrDefault();

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine(payment?.Id);

        payments.Remove(payment ?? new Payment(Guid.Empty));

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        foreach (var row in payments.Skip(1).Take(30))
        {
            Console.WriteLine(row.Id);
        }

        Console.ForegroundColor = ConsoleColor.White;

        var exist = payments.Any(p => p.Id == payment?.Id);

        Console.WriteLine(exist);


    }

}


public class Payment
{
    public Guid Id { get; set; }
    public Payment(Guid id)
    {
        this.Id = id;
    }
}