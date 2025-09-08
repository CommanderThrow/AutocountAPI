using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VLocation
{
    public string Location { get; set; } = null!;

    public string? LocationDescription { get; set; }

    public string? LocationDesc2 { get; set; }

    public string? LocationAddr1 { get; set; }

    public string? LocationAddr2 { get; set; }

    public string? LocationAddr3 { get; set; }

    public string? LocationAddr4 { get; set; }

    public string? LocationPostCode { get; set; }

    public string? LocationPhone1 { get; set; }

    public string? LocationPhone2 { get; set; }

    public string? LocationFax1 { get; set; }

    public string? LocationFax2 { get; set; }

    public string? LocationContact { get; set; }

    public string? LocationNote { get; set; }
}
