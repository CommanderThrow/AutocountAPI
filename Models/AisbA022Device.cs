using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Device
{
    public string DeviceId { get; set; } = null!;

    public string? DeviceName { get; set; }

    public string? Location { get; set; }

    public string? PrinterName { get; set; }

    public string? ReportBnout { get; set; }

    public string? ReportBnin { get; set; }

    public string? ReportBnallocation { get; set; }

    public string? ReportBnadjustment { get; set; }

    public string? ReportStockAdjustment { get; set; }

    public string? ReportStockIssue { get; set; }

    public string? ReportStockReceive { get; set; }

    public string? ReportStockTransfer { get; set; }

    public string? ReportStockTransferRequest { get; set; }

    public string? ReportStockTransferOut { get; set; }

    public string? ReportStockTransferIn { get; set; }

    public string? ReportGoodsReceiveNote { get; set; }

    public string? ReportDeliveryOrder { get; set; }

    public bool? IsActive { get; set; }

    public string? ReportLotLabel { get; set; }

    public string? ReportPurchaseOrder { get; set; }

    public string? ReportPurchaseReturn { get; set; }

    public string? DocNoFormatAj { get; set; }

    public string? DocNoFormatIs { get; set; }

    public string? DocNoFormatSr { get; set; }

    public string? DocNoFormatTx { get; set; }

    public string? DocNoFormatRx { get; set; }

    public string? DocNoFormatPo { get; set; }

    public string? DocNoFormatGrn { get; set; }

    public string? DocNoFormatPr { get; set; }

    public string? DocNoFormatDo { get; set; }

    public string? DocNoFormatAo { get; set; }

    public string? DocNoFormatAs { get; set; }

    public string? ReportAssemblyOrder { get; set; }

    public string? ReportStockAssembly { get; set; }

    public int? ItemCodeStart { get; set; }

    public int? ItemCodeEnd { get; set; }

    public int? QuantityStart { get; set; }

    public int? QuantityEnd { get; set; }

    public int? QuantityDecimal { get; set; }

    public int? PriceStart { get; set; }

    public int? PriceEnd { get; set; }

    public int? PriceDecimal { get; set; }

    public string? FlagDigit { get; set; }

    public bool? SettingEnabled { get; set; }

    public string? Uomtype { get; set; }

    public bool? ReplaceUnitPrice { get; set; }

    public int? BatchNoStart { get; set; }

    public int? BatchNoEnd { get; set; }

    public int? SerialNoStart { get; set; }

    public int? SerialNoEnd { get; set; }

    public int? DeptNoStart { get; set; }

    public int? DeptNoEnd { get; set; }

    public int? ProjNoStart { get; set; }

    public int? ProjNoEnd { get; set; }

    public int? LocationStart { get; set; }

    public int? LocationEnd { get; set; }

    public string? ReportSalesOrder { get; set; }

    public string? ReportInvoice { get; set; }

    public string? ReportCashSales { get; set; }

    public string? ReportCreditNote { get; set; }

    public string? ReportPurchaseInvoice { get; set; }

    public string? PaymentMethod { get; set; }

    public string? DocNoFormatSo { get; set; }

    public string? DocNoFormatIv { get; set; }

    public string? DocNoFormatCs { get; set; }

    public string? DocNoFormatCn { get; set; }

    public string? DocNoFormatPi { get; set; }

    public string? AjreportXml { get; set; }

    public string? SrreportXml { get; set; }

    public string? IsreportXml { get; set; }

    public string? TxreportXml { get; set; }

    public string? StrreportXml { get; set; }

    public string? StrireportXml { get; set; }

    public string? StroreportXml { get; set; }

    public string? AoreportXml { get; set; }

    public string? SareportXml { get; set; }

    public string? DoreportXml { get; set; }

    public string? PoreportXml { get; set; }

    public string? GrreportXml { get; set; }

    public string? PrreportXml { get; set; }

    public string? ReportCashSale { get; set; }

    public string? PireportXml { get; set; }

    public string? SoreportXml { get; set; }

    public string? CsreportXml { get; set; }

    public string? IvreportXml { get; set; }

    public string? CnreportXml { get; set; }

    public string? ReportQuotation { get; set; }

    public string? DocNoFormatQt { get; set; }

    public string? QtreportXml { get; set; }

    public string? License { get; set; }

    public string? DocNoFormatRq { get; set; }

    public string? DocNoFormatPq { get; set; }

    public string? ReportPurchaseRequest { get; set; }

    public string? PqreportXml { get; set; }

    public string? EnableModule { get; set; }

    public bool? ApplyRounding { get; set; }

    public string? SalesRounding { get; set; }

    public string? PurchaseRounding { get; set; }

    public virtual ICollection<AisbA022PrintFormat> AisbA022PrintFormats { get; set; } = new List<AisbA022PrintFormat>();
}
