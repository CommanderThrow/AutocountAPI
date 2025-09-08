using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VItemCategory
{
    public string ItemCategory { get; set; } = null!;

    public string? ItemCategoryDescription { get; set; }

    public string? ItemCategoryDesc2 { get; set; }
}
