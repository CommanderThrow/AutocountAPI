using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class EinvoiceSelfBilledDetail
{
    public long DtlKey { get; set; }

    public long DocKey { get; set; }

    public int Seq { get; set; }

    public string? Classification { get; set; }

    public string Description { get; set; } = null!;

    public decimal? Qty { get; set; }

    public string? Measurement { get; set; }

    public decimal? UnitPrice { get; set; }

    public string TaxType { get; set; } = null!;

    public decimal? TaxRate { get; set; }

    public string? TaxExemptionReason { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? SubTotalExTax { get; set; }

    public decimal? Tax { get; set; }

    public decimal? TaxableAmt { get; set; }

    public string? Discount { get; set; }

    public decimal? DiscountAmt { get; set; }

    public string? DiscountReason { get; set; }

    public string? Charge { get; set; }

    public decimal? ChargeAmt { get; set; }

    public string? ChargeReason { get; set; }

    public string? TariffCode { get; set; }

    public string? OriginCountryCode { get; set; }

    public Guid Guid { get; set; }

    public virtual Tariff? TariffCodeNavigation { get; set; }
}
