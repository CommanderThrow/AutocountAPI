using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockAssemblyOrder
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public decimal? Qty { get; set; }

    public decimal? TransferedQty { get; set; }

    public decimal? OutstandingQty { get; set; }

    public decimal? Total { get; set; }

    public decimal? AssemblyCost { get; set; }

    public decimal? NetTotal { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public short? PrintCount { get; set; }

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public string? LastModifiedUserName { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? CreatedUserName { get; set; }

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public string? CanSync { get; set; }

    public string? ExpectedCompletedDate { get; set; }

    public string? IsMultiLevel { get; set; }

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

    public string? Location { get; set; }

    public string? LocationDescription { get; set; }

    public string? LocationDesc2 { get; set; }

    public string? LocationAddr1 { get; set; }

    public string? LocationAddr2 { get; set; }

    public string? LocationAddr3 { get; set; }

    public string? LocationAddr4 { get; set; }

    public string? LocationPostCode { get; set; }

    public string? LocationPhone1 { get; set; }

    public string? LocationPhone2 { get; set; }

    public string? LocationFax1 { get; set; }

    public string? LocationFax2 { get; set; }

    public string? LocationContact { get; set; }

    public string? LocationNote { get; set; }

    public string? ProjNo { get; set; }

    public string? ProjectDescription { get; set; }

    public string? ProjectDesc2 { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptDescription { get; set; }

    public string? DeptDesc2 { get; set; }

    public string? BatchItemCode { get; set; }

    public string? BatchNo { get; set; }

    public string? BatchDescription { get; set; }

    public DateTime? BatchManufacturedDate { get; set; }

    public DateTime? BatchExpiryDate { get; set; }

    public string? TransferFrom { get; set; }

    public string? AsmorderUdfSuperAppId { get; set; }
}
