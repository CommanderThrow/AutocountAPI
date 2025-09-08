using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB048Token
{
    public string TokenId { get; set; } = null!;

    public DateTime ExpiredDateTime { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime? LogoutDateTime { get; set; }

    public string UserId { get; set; } = null!;

    public string? PassHash { get; set; }

    public string? DeviceId { get; set; }
}
