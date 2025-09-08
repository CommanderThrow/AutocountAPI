using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022PickingList
{
    public string PickingListId { get; set; } = null!;

    public string? DocNo { get; set; }

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedTime { get; set; }

    public string? Status { get; set; }

    public string? Cancelled { get; set; }

    public decimal? FinalTotalPickedQty { get; set; }

    public decimal? FinalTotalVarianceQty { get; set; }

    public decimal? FinalTotalWeight { get; set; }

    public decimal? FinalTotalVolumn { get; set; }

    public string? LoadingBay { get; set; }

    public decimal? FinalTotalPickedFocQty { get; set; }

    public decimal? FinalTotalVarianceFocQty { get; set; }

    public decimal? FinalTotalFocWeight { get; set; }

    public decimal? FinalTotalFocVolume { get; set; }

    public string? PickMethod { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? LorryNo { get; set; }

    public string? Remarks { get; set; }
}
