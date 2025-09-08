using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AccPeriod
{
    public int PeriodNo { get; set; }

    public string Lock { get; set; } = null!;
}
