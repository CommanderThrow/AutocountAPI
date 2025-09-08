using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Route
{
    public string RoutesId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Logo { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModifiedTime { get; set; }

    public string? CreatedBy { get; set; }
}
