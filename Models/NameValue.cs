using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class NameValue
{
    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
