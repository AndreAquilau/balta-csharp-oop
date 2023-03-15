using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.SharedContext;

namespace Balta.SubscriptionContext;

public class Student : Base
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public User? User { get; set; }

    public Student()
    {
        Subscriptions = new List<Subscription>();
    }

    public IList<Subscription> Subscriptions { get; set; }

    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
}