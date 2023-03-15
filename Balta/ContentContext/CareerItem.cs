using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.SharedContext;

using Balta.NotificationContext;

namespace Balta.ContentContext;

public class CareerItem : Base
{
    public CareerItem(int ordem, string title, string description, Course? course)
    {
        if (course == null)
        {
            base.AddNotification(new Notification(nameof(course), "Curso Inválido"));
        }

        Ordem = ordem;
        Title = title;
        Description = description;
        Course = course;
    }

    public int Ordem { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Course? Course { get; set; }

}