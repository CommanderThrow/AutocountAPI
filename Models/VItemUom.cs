using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VItemUom
{
    public string UomitemCode { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public decimal Uomrate { get; set; }

    public string? BarCode { get; set; }

    public string? Shelf { get; set; }

    public decimal? Uomprice { get; set; }

    public decimal? Uomprice2 { get; set; }

    public decimal? Uomcost { get; set; }

    public decimal? UomrealCost { get; set; }

    public decimal? UombalQty { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? Volume { get; set; }

    public string? VolumeUom { get; set; }
}
