using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022BinDtl
{
    public string Guid { get; set; } = null!;

    public string BinCode { get; set; } = null!;

    public int Seq { get; set; }

    public string? FilterType { get; set; }

    public string? Keyword { get; set; }

    public string? Description { get; set; }

    public int? Priority { get; set; }
}
