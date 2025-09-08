using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB063StatusHistory
{
    public string Guid { get; set; } = null!;

    public string ParentGuid { get; set; } = null!;

    public string? Status { get; set; }

    public DateOnly? TarikhGadai { get; set; }

    public DateOnly? TarikhLuput { get; set; }

    public int? MasaPenebus { get; set; }

    public DateOnly? TarikhLuputExtended { get; set; }

    public DateTime? CreatedAt { get; set; }
}
