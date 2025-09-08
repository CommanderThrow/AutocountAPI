using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA035PickingSystem
{
    public string PickingListDtlId { get; set; } = null!;

    public string? PickingListId { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public string? Description { get; set; }

    public decimal? RequestQty { get; set; }

    public decimal? TotalPickedQty { get; set; }

    public decimal? TotalVarianceQty { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public long? FromDocDtlKey { get; set; }

    public string? FromDocNo { get; set; }

    public int? Seq { get; set; }

    public string? Transferable { get; set; }

    public string? Shelf { get; set; }

    public string? Status { get; set; }

    public DateTime? LastModifiedTime { get; set; }

    public DateTime? FirstAddedTime { get; set; }

    public decimal? RequestFocQty { get; set; }

    public decimal? TotalPickedFocQty { get; set; }

    public decimal? TotalVarianceFocQty { get; set; }

    public decimal? TotalFocWeight { get; set; }

    public decimal? TotalFocVolume { get; set; }

    public string? SalesOrderNo { get; set; }

    public string? PickedStatus { get; set; }

    public string? Soarea { get; set; }

    public string? ReserveId { get; set; }

    public DateTime? ReserveTime { get; set; }

    public string? CompletedId { get; set; }

    public DateTime? CompletedTime { get; set; }
}
