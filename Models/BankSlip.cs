using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class BankSlip
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string BankAccNo { get; set; } = null!;
}
