using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceSelfBilled
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string DocStatus { get; set; } = null!;

    public DateTime? ExpiryTimeStamp { get; set; }

    public string? SupplierInvoiceNo { get; set; }

    public string? FrequencyOfBilling { get; set; }

    public DateTime? BillingPeriodStartDate { get; set; }

    public DateTime? BillingPeriodEndDate { get; set; }

    public int? SupplierTaxEntityId { get; set; }

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

    public bool SupplierIsForeigner { get; set; }

    public bool SupplierIsGeneralPublic { get; set; }

    public int? BuyerTaxEntityId { get; set; }

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

    public int? DeliveryTaxEntityId { get; set; }

    public string? DeliveryName { get; set; }

    public int? DeliveryClassification { get; set; }

    public string? DeliveryTin { get; set; }

    public string? DeliveryIdentityType { get; set; }

    public string? DeliveryIdentityNo { get; set; }

    public string? DeliveryEmail { get; set; }

    public string? DeliveryPhone { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliveryCity { get; set; }

    public string? DeliveryPostCode { get; set; }

    public string? DeliveryCountryCode { get; set; }

    public string? DeliveryStateCode { get; set; }

    public string? EinvoiceStatus { get; set; }

    public DateTime? EinvoiceAipsubmissionDateTime { get; set; }

    public string? EinvoiceUuid { get; set; }

    public DateTime? EinvoiceValidatedDateTime { get; set; }

    public string? EinvoiceValidationLink { get; set; }

    public string? EinvoiceError { get; set; }

    public DateTime? EinvoiceCancelDateTime { get; set; }

    public string? EinvoiceTraceId { get; set; }

    public string? EinvoiceCancelReason { get; set; }

    public string? BillingRef { get; set; }

    public string? PaymentMode { get; set; }

    public string? SupplierBankAccNo { get; set; }

    public decimal? PrepaymentAmt { get; set; }

    public DateTime? PrepaymentDate { get; set; }

    public string? PaymentRef { get; set; }

    public string? PaymentTerms { get; set; }

    public string? ReferenceNumberOfCustomsFormNo1And9 { get; set; }

    public string? Incoterms { get; set; }

    public string? FreeTradeAgreementInformation { get; set; }

    public string? AuthorisationNumberForCertifiedExporter { get; set; }

    public string? ReferenceNumberOfCustomsFormNo2 { get; set; }

    public decimal? FreightAllowanceChargeAmt { get; set; }

    public string? FreightAllowanceChargeReason { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal ToTaxCurrencyRate { get; set; }

    public string InclusiveTax { get; set; } = null!;

    public decimal? RoundAdj { get; set; }

    public decimal? NetTotal { get; set; }

    public decimal? Tax { get; set; }

    public decimal? ExTax { get; set; }

    public decimal? TotalExTax { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? Total { get; set; }

    public decimal? FinalTotal { get; set; }

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public Guid Guid { get; set; }

    public bool DeliveryIsForeigner { get; set; }

    public bool DeliveryIsGeneralPublic { get; set; }

    public bool IsSbconsolidated { get; set; }

    public string? EinvoiceSubmissionUuid { get; set; }

    public DateTime? EinvoiceSubmissionDateTime { get; set; }

    public virtual TaxEntity? BuyerTaxEntity { get; set; }

    public virtual Currency CurrencyCodeNavigation { get; set; } = null!;

    public virtual TaxEntity? DeliveryTaxEntity { get; set; }

    public virtual TaxEntity? SupplierTaxEntity { get; set; }
}
