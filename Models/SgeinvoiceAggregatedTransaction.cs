using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class SgeinvoiceAggregatedTransaction
{
    public long DocKey { get; set; }

    public string? SgeinvoiceFlowType { get; set; }

    public string? SgeinvoiceDocType { get; set; }

    public string? DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal ToTaxCurrencyRate { get; set; }

    public string? Description { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalExTax { get; set; }

    public decimal? NetTotal { get; set; }

    public string? SgeinvoiceDocumentUuid { get; set; }

    public string? SgeinvoiceError { get; set; }

    public string? SgeinvoiceTraceId { get; set; }

    public DateTime? SgeinvoiceAipsubmissionDateTime { get; set; }

    public string? SgeinvoiceSubmissionUuid { get; set; }

    public string? SgeinvoiceIrastransmissionId { get; set; }

    public string? SgeinvoiceIrassubmissionStatus { get; set; }

    public string? SgeinvoiceIraserror { get; set; }

    public DateTime? CreatedTimeStamp { get; set; }

    public string? CreatedUserId { get; set; }

    public string? DocType { get; set; }

    public decimal? RoundAdj { get; set; }

    public decimal? FinalTotal { get; set; }
}
