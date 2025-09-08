using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VJournalOfTransaction
{
    public string AccNo { get; set; } = null!;

    public string? AccDescription { get; set; }

    public string? AccDesc2 { get; set; }

    public string? DeaccNo { get; set; }

    public string? DeaccDescription { get; set; }

    public string? DeaccDesc2 { get; set; }

    public string JournalType { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public decimal ToHomeRate { get; set; }

    public decimal? OrgDr { get; set; }

    public decimal? OrgCr { get; set; }

    public decimal? Dr { get; set; }

    public decimal? Cr { get; set; }

    public decimal? HomeDr { get; set; }

    public decimal? HomeCr { get; set; }

    public DateTime TransDate { get; set; }

    public string? RefNo1 { get; set; }

    public string? RefNo2 { get; set; }

    public string? UserId { get; set; }

    public string? SourceType { get; set; }

    public long? SourceKey { get; set; }
}
