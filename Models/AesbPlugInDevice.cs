using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AesbPlugInDevice
{
    public string PlugInGuid { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public string? Name { get; set; }

    public string? LicenseKey { get; set; }

    public string? Signature { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ActivationDate { get; set; }
}
