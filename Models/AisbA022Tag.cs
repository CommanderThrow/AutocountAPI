using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Tag
{
    public int TagId { get; set; }

    public string? TagText { get; set; }

    public string? Color { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModifiedTime { get; set; }

    public string? CreatedBy { get; set; }
}
