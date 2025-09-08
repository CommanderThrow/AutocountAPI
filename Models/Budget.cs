using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Budget
{
    public long BudgetKey { get; set; }

    public string BudgetName { get; set; } = null!;
}
