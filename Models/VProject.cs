using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VProject
{
    public string ProjNo { get; set; } = null!;

    public string? ProjectDescription { get; set; }

    public string? ProjectDesc2 { get; set; }
}
