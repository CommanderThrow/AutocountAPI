using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022DevicesQuery
{
    public string QueryId { get; set; } = null!;

    public string? DeviceId { get; set; }

    public string? DocType { get; set; }

    public string? Caption { get; set; }

    public string? Query { get; set; }

    public long? Seq { get; set; }
}
