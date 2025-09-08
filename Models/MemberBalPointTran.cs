using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class MemberBalPointTran
{
    public long TransKey { get; set; }

    public string MemberNo { get; set; } = null!;

    public decimal Point { get; set; }
}
