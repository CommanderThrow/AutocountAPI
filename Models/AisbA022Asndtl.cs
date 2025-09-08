using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Asndtl
{
    public long DtlKey { get; set; }

    public long? DocKey { get; set; }

    public long? SodocKey { get; set; }

    public long? SodtlKey { get; set; }

    public int Seq { get; set; }

    public byte? Indent { get; set; }

    public string? FontStyle { get; set; }

    public bool MainItem { get; set; }

    public string? Numbering { get; set; }

    public string? ItemCode { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }

    public string? FurtherDescription { get; set; }

    public string? YourSono { get; set; }

    public DateTime? YourSodate { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public string? Uom { get; set; }

    public string? UserUom { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? SmallestQty { get; set; }

    public decimal TransferedQty { get; set; }

    public decimal? Focqty { get; set; }

    public decimal? FoctransferedQty { get; set; }

    public decimal? SmallestUnitPrice { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Discount { get; set; }

    public decimal? DiscountAmt { get; set; }

    public string? TaxType { get; set; }

    public decimal? Tax { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? LocalSubTotal { get; set; }

    public string Transferable { get; set; } = null!;

    public string PrintOut { get; set; } = null!;

    public string? DtlType { get; set; }

    public decimal? CalcByPercent { get; set; }

    public bool AddToSubTotal { get; set; }

    public string? FromDocType { get; set; }

    public string? FromDocNo { get; set; }

    public long? FromDocDtlKey { get; set; }

    public string? FullTransferOption { get; set; }

    public string? FullTransferFromDocList { get; set; }

    public decimal? TransferedPoqty { get; set; }

    public decimal? FoctransferedPoqty { get; set; }

    public string? EstimatedDeliveryDate { get; set; }

    public long? PackageDocKey { get; set; }

    public long? ParentDtlKey { get; set; }

    public decimal? TransferedAoqty { get; set; }

    public decimal? SubQty { get; set; }

    public bool? StockReceived { get; set; }

    public decimal? TotalPurchaseRequestQty { get; set; }

    public decimal? TotalDeliveryRequestQty { get; set; }

    public decimal? TotalAssemblyOrderRequestQty { get; set; }

    public short? PurchaseStatus { get; set; }

    public short? DeliveryStatus { get; set; }

    public short? AssemblyOrderStatus { get; set; }

    public DateTime? LastOpmodified { get; set; }

    public string? LastOpmodifiedUserId { get; set; }

    public DateTime? LastDrpmodified { get; set; }

    public DateTime? LastAorpmodified { get; set; }

    public string? LastDrpmodifiedUserId { get; set; }

    public string? LastAorpmodifiedUserId { get; set; }

    public decimal? SubTotalExTax { get; set; }

    public decimal? LocalTax { get; set; }

    public string? BatchNo { get; set; }

    public Guid Guid { get; set; }

    public long? RuleNo { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? TaxAdjustment { get; set; }

    public decimal? LocalSubTotalExTax { get; set; }

    public decimal? ExtraDiscountAmt { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? LocalTaxAdjustment { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public string? SalesExemptionNo { get; set; }

    public string? ToDtlKey { get; set; }

    public int? PrintQty { get; set; }
}
