using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class SgeinvoiceGstregistered
{
    public string RegisterNo { get; set; } = null!;

    public string? IsGstregistered { get; set; }

    public DateTime? LastUpdatedTimeStamp { get; set; }
}
