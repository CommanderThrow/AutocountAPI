using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VTaxEntity
{
    public int TaxEntityId { get; set; }

    public string Name { get; set; } = null!;

    public string? TradeName { get; set; }

    public string? IdentityNo { get; set; }

    public string Tin { get; set; } = null!;

    public string TaxBranchId { get; set; } = null!;

    public string? Address { get; set; }

    public string? PostCode { get; set; }

    public string? Phone { get; set; }

    public string? EmailAddress { get; set; }

    public int TaxCategory { get; set; }

    public int TaxClassification { get; set; }

    public string? GstregisterNo { get; set; }

    public string? SstregisterNo { get; set; }

    public string? TourismTaxRegisterNo { get; set; }

    public string? BusinessActivityDesc { get; set; }

    public string? Msiccode { get; set; }

    public string? IdentityType { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? CountryCode { get; set; }

    public string TaxRegisterNo { get; set; } = null!;
}
