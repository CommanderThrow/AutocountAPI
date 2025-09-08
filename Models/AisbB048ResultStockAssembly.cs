using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB048ResultStockAssembly
{
    public string Guid { get; set; } = null!;

    public string? DocNo { get; set; }

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public string Cancelled { get; set; } = null!;

    public DateTime CreatedTimeStamp { get; set; }

    public DateTime LastModified { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string LastModifiedUserId { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? BatchNo { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public decimal? Qty { get; set; }

    public string? RefDocNo { get; set; }

    public decimal? OrderQty { get; set; }

    public string? ItemCode { get; set; }

    public bool? IsImported { get; set; }

    public string? Sono { get; set; }
}
