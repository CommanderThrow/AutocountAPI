using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Irasgstsubmission
{
    public long Gstkey { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public string FormType { get; set; } = null!;

    public byte[]? TaxDataReport { get; set; }

    public string? RequestPayload { get; set; }

    public string? ResponsePayload { get; set; }

    public DateTime? CreatedTimeStamp { get; set; }

    public string? CreatedUserId { get; set; }

    public long? ParentGstkey { get; set; }

    public int? Seq { get; set; }

    public string? IsTaxAgent { get; set; }

    public string? ShowDebtorCreditorControl { get; set; }

    public string? ShowZeroBalance { get; set; }

    public string? ProductVersion { get; set; }

    public string? Iafversion { get; set; }

    public int Gstversion { get; set; }
}
