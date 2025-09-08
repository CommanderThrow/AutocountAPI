using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Asmbomoptional
{
    public long DtlKey { get; set; }

    public long? DocKey { get; set; }

    public long? BomoptionalKey { get; set; }

    public decimal Qty { get; set; }
}
