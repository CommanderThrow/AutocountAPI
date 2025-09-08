using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceStatusChangeLog
{
    public long Id { get; set; }

    public string EinvoiceStatus { get; set; } = null!;

    public string EinvoiceTraceId { get; set; } = null!;

    public string? EinvoiceUuid { get; set; }

    public string? EinvoiceSubmissionUuid { get; set; }

    public string? EinvoiceValidationLink { get; set; }

    public string? EinvoiceStatusReason { get; set; }

    public string DocType { get; set; } = null!;

    public long DocKey { get; set; }

    public DateTime ActionTimeStamp { get; set; }

    public string UserId { get; set; } = null!;
}
