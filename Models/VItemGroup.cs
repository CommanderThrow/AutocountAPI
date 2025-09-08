using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VItemGroup
{
    public string ItemGroup { get; set; } = null!;

    public string? ItemGroupDescription { get; set; }

    public string? ItemGroupDesc2 { get; set; }
}
