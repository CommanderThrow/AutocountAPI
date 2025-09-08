using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceConsolidatedInvoiceLink
{
    public long CilinkKey { get; set; }

    public long CidocKey { get; set; }

    public long CidtlKey { get; set; }

    public string DocType { get; set; } = null!;

    public long DocKey { get; set; }

    public string Cancelled { get; set; } = null!;
}
