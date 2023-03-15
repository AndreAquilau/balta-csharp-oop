using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext;

public class Lecture : Base
{
    public int Ordem { get; set; }

    public string? Title { get; set; }

    public int DurantionInMinute { get; set; }

    public EContentLevel Level { get; set; }
}
