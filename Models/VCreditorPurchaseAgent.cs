using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCreditorPurchaseAgent
{
    public string CreditorPurchaseAgent { get; set; } = null!;

    public string? CreditorPurchaseAgentDescription { get; set; }

    public string? CreditorPurchaseAgentDesc2 { get; set; }

    public byte[]? CreditorPurchaseAgentSignature { get; set; }
}
