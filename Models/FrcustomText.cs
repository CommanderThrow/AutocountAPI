using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class FrcustomText
{
    public long AutoKey { get; set; }

    public string Id { get; set; } = null!;

    public string? Text1 { get; set; }

    public string? Text2 { get; set; }
}
