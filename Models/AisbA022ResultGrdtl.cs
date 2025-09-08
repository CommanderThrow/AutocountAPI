using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultGrdtl
{
    public string Guid { get; set; } = null!;

    public int DtlKey { get; set; }

    public string? Seq { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public string? BatchNo { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public string? FromDocNo { get; set; }

    public long? FromDtlKey { get; set; }

    public string? FromDocType { get; set; }

    public bool? OverTransQtyApprove { get; set; }

    public string? LotNo { get; set; }

    public string? Location { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? ParentGuid { get; set; }

    public decimal? FromQuantity { get; set; }

    public decimal? FocQuantity { get; set; }

    public decimal? FromFocQuantity { get; set; }

    public string? Description { get; set; }
}
