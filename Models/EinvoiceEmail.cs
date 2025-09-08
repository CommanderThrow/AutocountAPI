using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceEmail
{
    public string DocType { get; set; } = null!;

    public string? Bccemail { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string ReportName { get; set; } = null!;

    public string Enabled { get; set; } = null!;
}
