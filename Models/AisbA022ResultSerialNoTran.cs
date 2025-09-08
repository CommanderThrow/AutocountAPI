using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultSerialNoTran
{
    public string Guid { get; set; } = null!;

    public string? DocType { get; set; }

    public string? DocGuid { get; set; }

    public string? DtlGuid { get; set; }

    public string? ItemCode { get; set; }

    public string? SerialNo { get; set; }

    public DateTime? ManufacturedDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public DateTime? LastSalesDate { get; set; }

    public string? Remarks { get; set; }

    public string? Note { get; set; }

    public string? Location { get; set; }
}
