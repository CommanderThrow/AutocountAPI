using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VPurchaseAgent
{
    public string PurchaseAgent { get; set; } = null!;

    public string? PurchaseAgentDescription { get; set; }

    public string? PurchaseAgentDesc2 { get; set; }

    public byte[]? PurchaseAgentSignature { get; set; }
}
