using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class MyeinvoiceReceiveDocument
{
    public long Id { get; set; }

    public string Uuid { get; set; } = null!;

    public string SubmissionUuid { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string DocNo { get; set; } = null!;

    public DateTime IssueDateTime { get; set; }

    public DateTime ReceivedDateTime { get; set; }

    public DateTime ValidatedDateTime { get; set; }

    public DateTime? RejectRequestDateTime { get; set; }

    public DateTime? CancelDateTime { get; set; }

    public string? IssuerTin { get; set; }

    public string? IssuerId { get; set; }

    public string? IssuerIdType { get; set; }

    public string? IssuerName { get; set; }

    public string? ReceiverTin { get; set; }

    public string? ReceiverId { get; set; }

    public string? ReceiverIdType { get; set; }

    public string? ReceiverName { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal TotalNetAmount { get; set; }

    public decimal TotalExTax { get; set; }

    public decimal TotalPayableAmount { get; set; }

    public string Status { get; set; } = null!;

    public string? ValidationLink { get; set; }

    public string? StatusReason { get; set; }

    public string? AutoCountDocType { get; set; }

    public long? AutoCountDocKey { get; set; }

    public string? JsonDocument { get; set; }
}
