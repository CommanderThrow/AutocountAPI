using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class DefaultReport
{
    public long AutoKey { get; set; }

    public string ReportType { get; set; } = null!;

    public string ReportName { get; set; } = null!;
}
