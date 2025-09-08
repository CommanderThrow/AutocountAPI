using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Setting
{
    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
