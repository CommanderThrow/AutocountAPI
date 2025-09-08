using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Mru
{
    public int Mrukey { get; set; }

    public string UserId { get; set; } = null!;

    public string? Mruitems { get; set; }
}
