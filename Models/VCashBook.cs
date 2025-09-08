using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCashBook
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public int? TaxEntityId { get; set; }

    public DateTime? TaxDate { get; set; }

    public string DocType { get; set; } = null!;

    public string? DealWith { get; set; }

    public string? Description { get; set; }

    public string? PostDetailDesc { get; set; }

    public string? DocNo2 { get; set; }

    public decimal CurrencyRate { get; set; }

    public decimal ToTaxCurrencyRate { get; set; }

    public decimal? TotalPayment { get; set; }

    public decimal? Total { get; set; }

    public decimal? LocalTotal { get; set; }

    public decimal? ExTax { get; set; }

    public decimal? LocalExTax { get; set; }

    public decimal? Tax { get; set; }

    public decimal? LocalTax { get; set; }

    public decimal? TaxCurrencyTax { get; set; }

    public decimal? NetTotal { get; set; }

    public decimal? LocalNetTotal { get; set; }

    public string DocStatus { get; set; } = null!;

    public string Cancelled { get; set; } = null!;

    public string? Note { get; set; }

    public short PrintCount { get; set; }

    public string? SourceType { get; set; }

    public long? SourceKey { get; set; }

    public string InclusiveTax { get; set; } = null!;

    public decimal? TotalExTax { get; set; }

    public decimal? LocalTotalExTax { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? LocalTaxableAmt { get; set; }

    public decimal? TaxCurrencyTaxableAmt { get; set; }

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public string? LastModifiedUserName { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? CreatedUserName { get; set; }

    public string? TaxRegisterNo { get; set; }

    public string? TaxEntityAddress { get; set; }

    public string SubmitEinvoice { get; set; } = null!;

    public string? EinvoiceStatus { get; set; }

    public DateTime? EinvoiceAipsubmissionDateTime { get; set; }

    public DateTime? EinvoiceSubmissionDateTime { get; set; }

    public string? EinvoiceUuid { get; set; }

    public string? EinvoiceSubmissionUuid { get; set; }

    public DateTime? EinvoiceValidatedDateTime { get; set; }

    public DateTime? EinvoiceIssueDateTime { get; set; }

    public string? EinvoiceError { get; set; }

    public DateTime? EinvoiceCancelDateTime { get; set; }

    public string? EinvoiceCancelReason { get; set; }

    public string? EinvoiceTraceId { get; set; }

    public string? EinvoiceValidationLink { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyWord { get; set; }

    public string? CurrencyWord2 { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? FcgainAccount { get; set; }

    public string? FclossAccount { get; set; }

    public string? GainLossJournalType { get; set; }
}
