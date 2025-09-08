using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockItemBrand
{
    public string ItemBrand { get; set; } = null!;

    public string? ItemBrandDescription { get; set; }

    public string? ItemBrandDesc2 { get; set; }

    public string? Note { get; set; }
}
