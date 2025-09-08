using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AssetLink
{
    public long AutoKey { get; set; }

    public string AssetAccNo { get; set; } = null!;

    public string AssetDeprnAccNo { get; set; } = null!;

    public virtual Glmast AssetAccNoNavigation { get; set; } = null!;

    public virtual Glmast AssetDeprnAccNoNavigation { get; set; } = null!;
}
