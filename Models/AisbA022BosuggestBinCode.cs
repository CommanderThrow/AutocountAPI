using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022BosuggestBinCode
{
    public string SuggestDtlGuid { get; set; } = null!;

    public string LotNo { get; set; } = null!;

    public string BinCode { get; set; } = null!;

    public decimal? BalQty { get; set; }

    public DateTime? SuggestedDateTime { get; set; }
}
