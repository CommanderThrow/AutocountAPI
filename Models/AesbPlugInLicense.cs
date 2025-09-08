using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AesbPlugInLicense
{
    public string PlugInGuid { get; set; } = null!;

    public string? LicenseKey { get; set; }

    public string? Signature { get; set; }

    public DateTime? ActivationDate { get; set; }
}
