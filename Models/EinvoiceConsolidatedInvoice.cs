using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceConsolidatedInvoice
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime IssueDateTime { get; set; }

    public string? SalesLocation { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal ToTaxCurrencyRate { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalExTax { get; set; }

    public decimal? Tax { get; set; }

    public decimal? NetTotal { get; set; }

    public string? FromDocType { get; set; }

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public Guid Guid { get; set; }

    public string? ConsolidatedPeriod { get; set; }

    public string SupplierName { get; set; } = null!;

    public int? SupplierClassification { get; set; }

    public string SupplierTin { get; set; } = null!;

    public string? SupplierIdentityType { get; set; }

    public string? SupplierIdentityNo { get; set; }

    public string? SupplierSstregistrationNumber { get; set; }

    public string? SupplierTourismTaxRegistrationNumber { get; set; }

    public string? SupplierEmail { get; set; }

    public string SupplierPhone { get; set; } = null!;

    public string SupplierMsiccode { get; set; } = null!;

    public string SupplierBusinessActivityDesc { get; set; } = null!;

    public string SupplierAddress { get; set; } = null!;

    public string SupplierCity { get; set; } = null!;

    public string SupplierPostCode { get; set; } = null!;

    public string SupplierCountryCode { get; set; } = null!;

    public string SupplierStateCode { get; set; } = null!;

    public string BuyerName { get; set; } = null!;

    public int? BuyerClassification { get; set; }

    public string BuyerTin { get; set; } = null!;

    public string? BuyerIdentityType { get; set; }

    public string? BuyerIdentityNo { get; set; }

    public string? BuyerSstregistrationNumber { get; set; }

    public string? BuyerEmail { get; set; }

    public string BuyerPhone { get; set; } = null!;

    public string BuyerAddress { get; set; } = null!;

    public string BuyerCity { get; set; } = null!;

    public string BuyerPostCode { get; set; } = null!;

    public string BuyerCountryCode { get; set; } = null!;

    public string BuyerStateCode { get; set; } = null!;

    public string? FrequencyOfBilling { get; set; }

    public DateTime? BillingPeriodStartDate { get; set; }

    public DateTime? BillingPeriodEndDate { get; set; }

    public string? EinvoiceStatus { get; set; }

    public DateTime? EinvoiceAipsubmissionDateTime { get; set; }

    public string? EinvoiceUuid { get; set; }

    public DateTime? EinvoiceValidatedDateTime { get; set; }

    public string? EinvoiceValidationLink { get; set; }

    public string? EinvoiceError { get; set; }

    public DateTime? EinvoiceCancelDateTime { get; set; }

    public string? EinvoiceCancelReason { get; set; }

    public string? EinvoiceTraceId { get; set; }

    public string? PaymentMode { get; set; }

    public string? EinvoiceSubmissionUuid { get; set; }

    public decimal? RoundAdj { get; set; }

    public decimal? FinalTotal { get; set; }

    public string GeneratedBy { get; set; } = null!;

    public DateTime? EinvoiceSubmissionDateTime { get; set; }
}
