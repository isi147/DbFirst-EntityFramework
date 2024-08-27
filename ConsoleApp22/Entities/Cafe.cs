using System;
using System.Collections.Generic;

namespace ConsoleApp22.Entities;

public partial class Cafe
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Menu { get; set; } = null!;
}
