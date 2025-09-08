using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class ReverseSstpayment
{
    public long DocKey { get; set; }

    public string DocType { get; set; } = null!;

    public long AppliedDocKey { get; set; }

    public string AppliedDocType { get; set; } = null!;

    public long JedocKey { get; set; }
}
