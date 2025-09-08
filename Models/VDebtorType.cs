using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VDebtorType
{
    public string DebtorType { get; set; } = null!;

    public string? DebtorTypeDescription { get; set; }

    public string? DebtorTypeDesc2 { get; set; }
}
