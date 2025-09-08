using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class ReverseGstdo
{
    public long DocKey { get; set; }

    public string DocType { get; set; } = null!;

    public long JedocKey { get; set; }
}
