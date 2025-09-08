using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Registry
{
    public int RegId { get; set; }

    public short? RegType { get; set; }

    public string? RegValue { get; set; }
}
