using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Brdtl
{
    public string DtlGuid { get; set; } = null!;

    public string? DocNo { get; set; }

    public int? Seq { get; set; }

    public string? LotNo { get; set; }

    public string? ItemCode { get; set; }

    public string? Description { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public string? BatchNo { get; set; }

    public string? DeptNo { get; set; }

    public string? ProjNo { get; set; }

    public string? FromBinCode { get; set; }

    public string? ToBinCode { get; set; }

    public decimal? BalQty { get; set; }

    public decimal? RequestQty { get; set; }

    public decimal? ActualQty { get; set; }

    public string? DeviceGuid { get; set; }

    public string? DeviceId { get; set; }

    public DateTime? DeviceFromBinDate { get; set; }

    public DateTime? DeviceToBinDate { get; set; }

    public string? DeviceUserId { get; set; }

    public decimal? FromActualQty { get; set; }

    public decimal? ToActualQty { get; set; }

    public string? FromDeviceGuid { get; set; }

    public string? ToDeviceGuid { get; set; }
}
