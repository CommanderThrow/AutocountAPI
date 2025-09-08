using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class PeriodLockException
{
    public long AutoKey { get; set; }

    public int PeriodNo { get; set; }

    public string FunctionName { get; set; } = null!;

    public string UserId { get; set; } = null!;
}
