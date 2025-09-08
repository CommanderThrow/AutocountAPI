using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class ChangeCount
{
    public long AutoKey { get; set; }

    public string TableName { get; set; } = null!;

    public int Counter { get; set; }
}
