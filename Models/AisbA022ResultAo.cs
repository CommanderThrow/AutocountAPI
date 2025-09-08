using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultAo
{
    public string Guid { get; set; } = null!;

    public string? DocNo { get; set; }

    public string? DeviceId { get; set; }

    public string? DocType { get; set; }

    public DateTime? DocDate { get; set; }

    public string? Description { get; set; }

    public string? RefDocNo { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? TransFromDoc { get; set; }

    public string? ItemCode { get; set; }

    public string? BatchNo { get; set; }

    public string? Location { get; set; }

    public string? ProjNo { get; set; }

    public string? DeptNo { get; set; }

    public decimal? Qty { get; set; }

    public bool? Posted { get; set; }

    public int? PostCount { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? LastModifiedUserId { get; set; }

    public bool? Cancelled { get; set; }

    public string? CancelledUserId { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? OrderQty { get; set; }

    public long? FromDtlKey { get; set; }

    public string? Fgdescription { get; set; }
}
