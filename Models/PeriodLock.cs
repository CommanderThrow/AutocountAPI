using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class PeriodLock
{
    public int PeriodNo { get; set; }

    public string Lock { get; set; } = null!;
}
