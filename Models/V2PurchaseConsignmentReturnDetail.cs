using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2PurchaseConsignmentReturnDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public int Seq { get; set; }

    public string? Numbering { get; set; }

    public string MainItem { get; set; } = null!;

    public string? Description { get; set; }

    public string? Desc2 { get; set; }

    public string? FurtherDescription { get; set; }

    public decimal? Qty { get; set; }

    public decimal? SmallestQty { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? SmallestUnitPrice { get; set; }

    public string? Discount { get; set; }

    public decimal? DiscountAmt { get; set; }

    public string? UserUom { get; set; }

    public string PrintOut { get; set; } = null!;

    public string? FullTransferOption { get; set; }

    public decimal? UnitPriceAfterDiscount { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? SubTotalExTax { get; set; }

    public decimal? LocalSubTotalExTax { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? LocalSubTotal { get; set; }

    public decimal? CalcByPercent { get; set; }

    public string AddToSubTotal { get; set; } = null!;

    public string? FromDocType { get; set; }

    public string? FromDocNo { get; set; }

    public long? FromDocDtlKey { get; set; }

    public byte? Indent { get; set; }

    public string? DtlType { get; set; }

    public decimal? Rate { get; set; }

    public string? FontStyle { get; set; }

    public long? PackageDocKey { get; set; }

    public decimal? SubTotalWithTax { get; set; }

    public string? ItemCode { get; set; }

    public string? Location { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNoList { get; set; }

    public string? TaxCode { get; set; }

    public string? Remark { get; set; }

    public string? Lost { get; set; }
}
