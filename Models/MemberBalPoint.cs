using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class MemberBalPoint
{
    public long AutoKey { get; set; }

    public string MemberNo { get; set; } = null!;

    public decimal? Point { get; set; }

    public Guid Guid { get; set; }
}
