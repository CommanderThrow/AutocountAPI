using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockUpdateCost
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public string UpdateToRealCost { get; set; } = null!;

    public short PrintCount { get; set; }

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public string? LastModifiedUserName { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? CreatedUserName { get; set; }
}
