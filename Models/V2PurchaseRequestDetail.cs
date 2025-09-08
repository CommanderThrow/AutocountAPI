using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2PurchaseRequestDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public int Seq { get; set; }

    public string? Numbering { get; set; }

    public string MainItem { get; set; } = null!;

    public string? Description { get; set; }

    public string? Desc2 { get; set; }

    public string? FurtherDescription { get; set; }

    public decimal? Qty { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public decimal? SmallestQty { get; set; }

    public decimal TransferedQty { get; set; }

    public string? UserUom { get; set; }

    public string PrintOut { get; set; } = null!;

    public DateTime? RequiredDate { get; set; }

    public string? Location { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public byte? Indent { get; set; }

    public decimal? Rate { get; set; }

    public string? FontStyle { get; set; }

    public string? CreditorCode { get; set; }

    public string? CreditorName { get; set; }

    public string Transferable { get; set; } = null!;
}
