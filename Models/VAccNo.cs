using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VAccNo
{
    public string AccNo { get; set; } = null!;

    public string? AccDescription { get; set; }

    public string? AccDesc2 { get; set; }

    public string AccType { get; set; } = null!;

    public string? SpecialAccType { get; set; }

    public string AccCurrencyCode { get; set; } = null!;
}
