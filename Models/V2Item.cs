using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2Item
{
    public string ItemCode { get; set; } = null!;

    public string? ItemGroup { get; set; }

    public string? ItemType { get; set; }

    public string? ItemBrand { get; set; }

    public string? ItemClass { get; set; }

    public string? ItemCategory { get; set; }

    public string? LeadTime { get; set; }

    public byte[]? Image { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemDesc2 { get; set; }

    public string? ItemFurtherDescription { get; set; }

    public string? ItemNote { get; set; }

    public string ItemBaseUom { get; set; } = null!;

    public int? ItemUdfWarDay { get; set; }
}
