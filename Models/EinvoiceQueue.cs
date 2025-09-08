using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceQueue
{
    public string DocType { get; set; } = null!;

    public long DocKey { get; set; }
}
