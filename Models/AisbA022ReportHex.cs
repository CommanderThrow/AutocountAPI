using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ReportHex
{
    public string DocGuid { get; set; } = null!;

    public string DocNo { get; set; } = null!;

    public string? DocType { get; set; }

    public string ReportHex { get; set; } = null!;

    public long Id { get; set; }

    public DateTime? LastUpdatedTime { get; set; }
}
