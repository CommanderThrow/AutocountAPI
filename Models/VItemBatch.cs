using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VItemBatch
{
    public string BatchItemCode { get; set; } = null!;

    public string BatchNo { get; set; } = null!;

    public string? BatchDescription { get; set; }

    public DateTime? BatchManufacturedDate { get; set; }

    public DateTime? BatchExpiryDate { get; set; }
}
