using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Picker
{
    public string Guid { get; set; } = null!;

    public string? UserId { get; set; }

    public string? Mode { get; set; }
}
