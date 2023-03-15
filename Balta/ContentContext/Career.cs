using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balta.ContentContext;

public class Career : Content
{
    public Career(string title, string url) : base(title: title, url: url)
    {
        Items = new List<CareerItem>();
    }

    public IList<CareerItem> Items { get; set; }

    public int TotalCourses { get => Items.Count(); }
}

