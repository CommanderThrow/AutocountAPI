using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockItemType
{
    public string ItemType { get; set; } = null!;

    public string? ItemTypeDescription { get; set; }

    public string? ItemTypeDesc2 { get; set; }

    public string? Note { get; set; }
}
