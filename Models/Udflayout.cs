using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Udflayout
{
    public long AutoKey { get; set; }

    public string TableName { get; set; } = null!;

    public string LayoutName { get; set; } = null!;

    public string? Layout { get; set; }

    public Guid Guid { get; set; }
}
