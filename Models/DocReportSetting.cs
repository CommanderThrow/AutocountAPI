using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class DocReportSetting
{
    public string DocType { get; set; } = null!;

    public byte[]? Data { get; set; }
}
