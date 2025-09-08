using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCreditorType
{
    public string CreditorType { get; set; } = null!;

    public string? CreditorTypeDescription { get; set; }

    public string? CreditorTypeDesc2 { get; set; }
}
