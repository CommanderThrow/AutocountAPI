using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VDebtorSalesAgent
{
    public string DebtorSalesAgent { get; set; } = null!;

    public string? DebtorSalesAgentDescription { get; set; }

    public string? DebtorSalesAgentDesc2 { get; set; }

    public byte[]? DebtorSalesAgentSignature { get; set; }
}
