using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceSelfBilledLink
{
    public int SblinkKey { get; set; }

    public long? FromDocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string EinvoiceUuid { get; set; } = null!;

    public long ToDocKey { get; set; }

    public string? FromDocType { get; set; }

    public long? ToDocDtlKey { get; set; }
}
