using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockUpdateCostDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public int Seq { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemGroupDescription { get; set; }

    public string? ItemType { get; set; }

    public string? ItemTypeDescription { get; set; }

    public string? ItemBrand { get; set; }

    public string? ItemBrandDescription { get; set; }

    public string? ItemClass { get; set; }

    public string? ItemClassDescription { get; set; }

    public string? ItemCategory { get; set; }

    public string? ItemCategoryDescription { get; set; }

    public string? LeadTime { get; set; }

    public byte[]? Image { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemDesc2 { get; set; }

    public string? ItemFurtherDescription { get; set; }

    public string? ItemNote { get; set; }

    public string? ItemBaseUom { get; set; }

    public int? ItemUdfWarDay { get; set; }

    public string? Description { get; set; }

    public string? Desc2 { get; set; }

    public string? UomitemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Uomrate { get; set; }

    public string? BarCode { get; set; }

    public string? Shelf { get; set; }

    public decimal? Uomprice { get; set; }

    public decimal? Uomprice2 { get; set; }

    public decimal? Uomcost { get; set; }

    public decimal? UomrealCost { get; set; }

    public decimal? UombalQty { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? Volume { get; set; }

    public string? VolumeUom { get; set; }

    public decimal? OldCost { get; set; }

    public decimal? NewCost { get; set; }
}
