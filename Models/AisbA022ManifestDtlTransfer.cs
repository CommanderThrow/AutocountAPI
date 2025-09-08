using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ManifestDtlTransfer
{
    public string ManifestDtlTransferId { get; set; } = null!;

    public string? ManifestDtlId { get; set; }

    public string? ManifestId { get; set; }

    public int? Seq { get; set; }

    public string? SodocNo { get; set; }

    public string? SodocKey { get; set; }

    public string? SodtlKey { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? Description { get; set; }

    public decimal? Soqty { get; set; }

    public decimal? SofocQty { get; set; }

    public decimal? PickedQty { get; set; }

    public decimal? ActualQty { get; set; }

    public decimal? ActualFocQty { get; set; }

    public decimal? VarianceQty { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public string? FromDocType { get; set; }

    public string? BatchNo { get; set; }

    public decimal? PickedFocQty { get; set; }

    public string? PickingListDtlTransferId { get; set; }

    public decimal? RevertQty { get; set; }

    public string? Transferable { get; set; }

    public long? DodtlKey { get; set; }

    public decimal? RevertFocQty { get; set; }

    public int? CombineSeq { get; set; }

    public bool? IsWrongPicked { get; set; }
}
