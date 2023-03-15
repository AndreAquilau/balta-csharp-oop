using System;
using System.Text;
using Balta.ContentContext;
using Balta.NotificationContext;
using System.Linq;
using Balta.SubscriptionContext;

namespace Balta;

public class Program
{
    public static void Main(params string[] args)
    {
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "CSharp"));
        articles.Add(new Article("Artigo sobre .NET", "dotnet"));

        var print = new StringBuilder();
        foreach (var article in articles)
        {
            print.Append(article.Id).Append(Environment.NewLine);
            print.Append(article.Title).Append(Environment.NewLine);
            print.Append(article.Url).Append(Environment.NewLine);
        }

        Console.WriteLine(print);

        var courses = new List<Course>();
        var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
        var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
        var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

        courses.Add(courseOOP);
        courses.Add(courseCSharp);
        courses.Add(courseAspNet);

        var careers = new List<Career>();
        var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
        var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
        var careerItem1 = new CareerItem(1, "Comece por aqui", "", courseCSharp);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

        careerDotnet.Items.Add(careerItem2);
        careerDotnet.Items.Add(careerItem3);
        careerDotnet.Items.Add(careerItem1);

        careers.Add(careerDotnet);

        foreach (var career in careers)
        {
            Console.WriteLine(career.Title);
            foreach (var item in career.Items.OrderBy(x => x.Ordem))
            {
                Console.WriteLine($"{item.Ordem} - {item.Title}");
                Console.WriteLine(item.Course?.Title);
                Console.WriteLine(item.Course?.Level);
                foreach (var notification in item.Notifications)
                {
                    Console.WriteLine($"{notification.Message} - {notification.Message}");
                }
            }

        }

        var payPalSubscription = new PayPalSubscription();
        var student = new Student();

    }

}
