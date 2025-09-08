using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VUser
{
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Department { get; set; }

    public byte[]? Signature { get; set; }

    public string? EmailAddress { get; set; }

    public string IsActive { get; set; } = null!;
}
