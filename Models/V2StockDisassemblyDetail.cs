using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2StockDisassemblyDetail
{
    public long DtlKey { get; set; }

    public long? ParentDtlKey { get; set; }

    public long? DocKey { get; set; }

    public int Seq { get; set; }

    public string? Numbering { get; set; }

    public string? IsBomitem { get; set; }

    public string? Description { get; set; }

    public string? Desc2 { get; set; }

    public string? FurtherDescription { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public decimal? ItemCost { get; set; }

    public decimal? OverHeadCost { get; set; }

    public decimal? SubTotalCost { get; set; }

    public string PrintOut { get; set; } = null!;

    public string? Remark { get; set; }

    public string? SerialNoList { get; set; }

    public string? ItemCode { get; set; }

    public string? BatchNo { get; set; }

    public string? Location { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public decimal? CostFraction { get; set; }

    public string? Uom { get; set; }
}
