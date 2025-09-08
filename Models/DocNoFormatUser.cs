using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class DocNoFormatUser
{
    public long AutoKey { get; set; }

    public string Name { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public virtual DocNoFormat NameNavigation { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
