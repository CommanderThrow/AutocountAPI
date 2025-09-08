using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class LayoutUser
{
    public long AutoKey { get; set; }

    public string Title { get; set; } = null!;

    public string UserId { get; set; } = null!;
}
