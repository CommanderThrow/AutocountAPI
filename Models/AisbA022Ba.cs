using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Ba
{
    public string DocNo { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public string? Description { get; set; }

    public string? RefDocNo { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDateTime { get; set; }

    public bool? Cancelled { get; set; }
}
