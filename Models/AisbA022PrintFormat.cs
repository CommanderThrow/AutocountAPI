using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022PrintFormat
{
    public int PrintFormatId { get; set; }

    public string? DeviceId { get; set; }

    public string? DocType { get; set; }

    public string? PrintFormat { get; set; }

    public DateTime? LastModifiedTime { get; set; }

    public virtual AisbA022Device? Device { get; set; }
}
