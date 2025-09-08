using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Criterion
{
    public long AutoKey { get; set; }

    public string CriteriaName { get; set; } = null!;

    public string CriteriaType { get; set; } = null!;

    public byte[]? Data { get; set; }
}
