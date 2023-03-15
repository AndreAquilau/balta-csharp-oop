using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net.Http;

namespace Matriz;

public class Program
{
    public static void Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            var response = client.GetStreamAsync("https://viacep.com.br/ws/01001000/json");

            response.Wait();

            var text = new StreamReader(response.Result);

            var fileExist = new FileInfo("./cep.json").Exists;

            if (fileExist)
            {
                File.Delete("./cep.json");
            }

            StreamWriter stream = new StreamWriter("./cep.json", false);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            while (!text.EndOfStream)
            {
                var json = text.ReadLine();
                Console.WriteLine(json);
                stream.WriteLine(json);
            }
            Console.ForegroundColor = ConsoleColor.White;

            text.Dispose();
            stream.Dispose();
        }

    }
}