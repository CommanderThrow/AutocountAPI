using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AccType
{
    public long AutoKey { get; set; }

    public string AccType1 { get; set; } = null!;

    public string? Description { get; set; }

    public string? Desc2 { get; set; }

    public string IsBstype { get; set; } = null!;

    public string IsSystemType { get; set; } = null!;

    public virtual AccGroup? AccGroup { get; set; }

    public virtual ICollection<Bsformat> Bsformats { get; set; } = new List<Bsformat>();

    public virtual ICollection<Glmast> Glmasts { get; set; } = new List<Glmast>();

    public virtual ICollection<Plformat> Plformats { get; set; } = new List<Plformat>();
}
