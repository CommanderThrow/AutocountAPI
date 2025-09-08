using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCreditorArea
{
    public string CreditorAreaCode { get; set; } = null!;

    public string? CreditorAreaDescription { get; set; }

    public string? CreditorAreaDesc2 { get; set; }
}
