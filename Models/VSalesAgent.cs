using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VSalesAgent
{
    public string SalesAgent { get; set; } = null!;

    public string? SalesAgentDescription { get; set; }

    public string? SalesAgentDesc2 { get; set; }

    public byte[]? SalesAgentSignature { get; set; }
}
