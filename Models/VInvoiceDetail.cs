using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VInvoiceDetail
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

    public decimal TransferedQty { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? SmallestUnitPrice { get; set; }

    public string? Discount { get; set; }

    public decimal? DiscountAmt { get; set; }

    public string? UserUom { get; set; }

    public string PrintOut { get; set; } = null!;

    public string? OurDono { get; set; }

    public DateTime? OurDodate { get; set; }

    public string? FullTransferOption { get; set; }

    public decimal? UnitPriceAfterDiscount { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxCodeDescription { get; set; }

    public decimal? TaxRate { get; set; }

    public string? TaxAccNo { get; set; }

    public string? GovtTaxCode { get; set; }

    public int? AccountingBasis { get; set; }

    public string? AddToCost { get; set; }

    public decimal? DocTaxRate { get; set; }

    public string? SalesExemptionNo { get; set; }

    public string? TariffCode { get; set; }

    public string? TaxPermitNo { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public decimal? TaxAdjustment { get; set; }

    public decimal? LocalTaxAdjustment { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? LocalSubTotal { get; set; }

    public decimal? SubTotalExTax { get; set; }

    public decimal? LocalSubTotalExTax { get; set; }

    public string Transferable { get; set; } = null!;

    public decimal? CalcByPercent { get; set; }

    public string AddToSubTotal { get; set; } = null!;

    public string? YourPono { get; set; }

    public DateTime? YourPodate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? EstimatedDeliveryDate { get; set; }

    public decimal? Focqty { get; set; }

    public decimal? FoctransferedQty { get; set; }

    public string? FromDocType { get; set; }

    public string? FromDocNo { get; set; }

    public long? FromDocDtlKey { get; set; }

    public decimal? BonusPoint { get; set; }

    public string? AccNo { get; set; }

    public byte? Indent { get; set; }

    public string? DtlType { get; set; }

    public decimal? Rate { get; set; }

    public long? PackageDocKey { get; set; }

    public string? FontStyle { get; set; }

    public decimal? SubTotalWithTax { get; set; }

    public string? SerialNoList { get; set; }

    public long? ValueXferSodocKey { get; set; }

    public string? Classification { get; set; }

    public string? OriginCountryCode { get; set; }

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

    public decimal? LocationBalQty { get; set; }

    public decimal? BatchBalQty { get; set; }

    public string? BatchItemCode { get; set; }

    public string? BatchNo { get; set; }

    public string? BatchDescription { get; set; }

    public DateTime? BatchManufacturedDate { get; set; }

    public DateTime? BatchExpiryDate { get; set; }

    public decimal? IvdtludfDeliveryQty { get; set; }

    public decimal? IvdtludfDeliveryFocQty { get; set; }
}
