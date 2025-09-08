using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultDeliveryAppDtl
{
    public string Guid { get; set; } = null!;

    public string ParentGuid { get; set; } = null!;

    public long DtlKey { get; set; }

    public decimal Qty { get; set; }

    public decimal DeliveryQty { get; set; }

    public decimal Focqty { get; set; }

    public decimal DeliveryFocQty { get; set; }
}
