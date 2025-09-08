using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class SgeinvoiceLogging
{
    public long Id { get; set; }

    public long? DocKey { get; set; }

    public string? SgeinvoiceFlowType { get; set; }

    public string? SgeinvoiceDocType { get; set; }

    public string? DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string? AccNo { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Total { get; set; }

    public decimal? NetTotal { get; set; }

    public string? SendToPeppol { get; set; }

    public string? SendToIras { get; set; }

    public string? SgeinvoiceDocumentUuid { get; set; }

    public string? SgeinvoiceTraceId { get; set; }

    public DateTime? SgeinvoiceAipsubmissionDateTime { get; set; }

    public string? SgeinvoiceSubmissionUuid { get; set; }

    public string? SgeinvoicePeppolError { get; set; }

    public string? SgeinvoicePeppolInstanceId { get; set; }

    public string? SgeinvoicePeppolSubmissionStatus { get; set; }

    public string? SgeinvoicePeppolSender { get; set; }

    public string? SgeinvoicePeppolReceiver { get; set; }

    public string? SgeinvoiceIraserror { get; set; }

    public string? SgeinvoiceIrastransmissionId { get; set; }

    public string? SgeinvoiceIrassubmissionStatus { get; set; }

    public DateTime? CreatedTimeStamp { get; set; }

    public string? CreatedUserId { get; set; }
}
