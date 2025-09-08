using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022PickingListDtlTransfer
{
    public string PickingListDtlTransferId { get; set; } = null!;

    public string? PickingListDtlId { get; set; }

    public string? PickingListId { get; set; }

    public int? Seq { get; set; }

    public string? SodocNo { get; set; }

    public long? SodocKey { get; set; }

    public long? SodtlKey { get; set; }

    public string? Soarea { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public string? Description { get; set; }

    public decimal? NewSoqty { get; set; }

    public decimal? Soqty { get; set; }

    public decimal? NewSofocQty { get; set; }

    public decimal? SofocQty { get; set; }

    public decimal? PickedQty { get; set; }

    public decimal? PickedFocQty { get; set; }

    public decimal? VarianceQty { get; set; }

    public decimal? SubWeight { get; set; }

    public decimal? SubVolume { get; set; }

    public string? Transferable { get; set; }

    public decimal? RevertQty { get; set; }

    public decimal? SooutstandingQty { get; set; }

    public decimal? SofocOutstandingQty { get; set; }

    public decimal? VarianceFocQty { get; set; }

    public decimal? RevertFocQty { get; set; }

    public string? TransType { get; set; }
}
