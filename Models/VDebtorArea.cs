using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VDebtorArea
{
    public string DebtorAreaCode { get; set; } = null!;

    public string? DebtorAreaDescription { get; set; }

    public string? DebtorAreaDesc2 { get; set; }
}
