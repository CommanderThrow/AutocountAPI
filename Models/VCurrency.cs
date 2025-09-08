using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCurrency
{
    public string CurrencyCode { get; set; } = null!;

    public string? CurrencyWord { get; set; }

    public string? CurrencyWord2 { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? FcgainAccount { get; set; }

    public string? FclossAccount { get; set; }

    public string? GainLossJournalType { get; set; }
}
