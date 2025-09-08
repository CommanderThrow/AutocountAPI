using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultSrdtl
{
    public string Guid { get; set; } = null!;

    public int DtlKey { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Qty { get; set; }

    public string? BatchNo { get; set; }

    public decimal? Rate { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public string? Location { get; set; }

    public string? Desc2 { get; set; }

    public string? FurtherDesc { get; set; }

    public string? ParentGuid { get; set; }

    public string? Seq { get; set; }
}
