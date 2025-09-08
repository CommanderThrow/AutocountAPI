using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class V2ConsignmentSubDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public int Seq { get; set; }

    public string? Description { get; set; }

    public string? Desc2 { get; set; }

    public string? FurtherDescription { get; set; }

    public decimal? SubQty { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitPrice { get; set; }

    public string PrintOut { get; set; } = null!;

    public decimal? Rate { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public string? SerialNoList { get; set; }

    public long? ParentDtlKey { get; set; }

    public string? Remark { get; set; }
}
