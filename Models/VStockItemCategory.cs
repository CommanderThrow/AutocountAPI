using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockItemCategory
{
    public string ItemCategory { get; set; } = null!;

    public string? ItemCategoryDescription { get; set; }

    public string? ItemCategoryDesc2 { get; set; }

    public string? Note { get; set; }
}
