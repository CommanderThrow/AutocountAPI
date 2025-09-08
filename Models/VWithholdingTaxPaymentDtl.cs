using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VWithholdingTaxPaymentDtl
{
    public string DocType { get; set; } = null!;

    public long DocKey { get; set; }

    public long DtlKey { get; set; }

    public string? WithholdingValueType { get; set; }

    public decimal? Amount { get; set; }

    public string? WithholdingTaxCode { get; set; }

    public string? WithholdingTaxDescription { get; set; }

    public decimal? WithholdingTaxRate { get; set; }

    public string? WhtcreditableAccNo { get; set; }

    public string? WhtpayableAccNo { get; set; }

    public decimal? DocWithholdingTaxRate { get; set; }

    public decimal? WithholdingTax { get; set; }
}
