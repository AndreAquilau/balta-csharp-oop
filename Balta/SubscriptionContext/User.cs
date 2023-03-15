using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.SharedContext;

namespace Balta.SubscriptionContext;

public class User : Base
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public User()
    {
        Subscriptions = new List<Subscription>();
    }

    IList<Subscription> Subscriptions { get; set; }
}
