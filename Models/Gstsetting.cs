using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Gstsetting
{
    public string Gstname { get; set; } = null!;

    public string? Gstvalue { get; set; }
}
