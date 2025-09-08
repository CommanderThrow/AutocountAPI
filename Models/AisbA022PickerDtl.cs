using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022PickerDtl
{
    public string Guid { get; set; } = null!;

    public string ParentGuid { get; set; } = null!;

    public long? Seq { get; set; }

    public string? FilterType { get; set; }

    public string? Keyword { get; set; }

    public string? Description { get; set; }

    public long? Priority { get; set; }
}
