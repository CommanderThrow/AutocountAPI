using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VWithholdingTax
{
    public string WithholdingTaxCode { get; set; } = null!;

    public string? WithholdingTaxDescription { get; set; }

    public decimal WithholdingTaxRate { get; set; }

    public string? WhtcreditableAccNo { get; set; }

    public string? WhtpayableAccNo { get; set; }
}
