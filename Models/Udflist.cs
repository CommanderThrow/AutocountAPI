using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Udflist
{
    public long AutoKey { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public Guid Guid { get; set; }
}
