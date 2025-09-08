using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2StockDisassembly
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public string Location { get; set; } = null!;

    public string? BatchNo { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Total { get; set; }

    public decimal? DisassemblyCost { get; set; }

    public decimal? NetTotal { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public short? PrintCount { get; set; }

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public string? CanSync { get; set; }

    public string? IsMultilevel { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? ItemCost { get; set; }

    public decimal? DtlTotal { get; set; }

    public int CostOptions { get; set; }
}
