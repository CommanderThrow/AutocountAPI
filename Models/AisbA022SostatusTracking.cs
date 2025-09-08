using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022SostatusTracking
{
    public string Guid { get; set; } = null!;

    public DateTime CreatedTimeStamp { get; set; }

    public string SodocKey { get; set; } = null!;

    public string SodocNo { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public string? FromDocType { get; set; }

    public string? FromDocId { get; set; }
}
