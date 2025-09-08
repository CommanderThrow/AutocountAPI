using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockItemClass
{
    public string ItemClass { get; set; } = null!;

    public string? ItemClassDescription { get; set; }

    public string? ItemClassDesc2 { get; set; }

    public string? Note { get; set; }
}
