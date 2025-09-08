using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VCompanyProfile
{
    public string CompanyName { get; set; } = null!;

    public string? RegisterNo { get; set; }

    public string? TaxRegisterNo { get; set; }

    public string? SalesTaxRegisterNo { get; set; }

    public string? ServiceTaxRegisterNo { get; set; }

    public string? CompanyNameWithRegisterNo { get; set; }

    public string? CompanyNameWithRemark { get; set; }

    public string? Remark { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? PostCode { get; set; }

    public string? DeliverAddr1 { get; set; }

    public string? DeliverAddr2 { get; set; }

    public string? DeliverAddr3 { get; set; }

    public string? DeliverAddr4 { get; set; }

    public string? DeliverPostCode { get; set; }

    public string? DeliverPhone1 { get; set; }

    public string? DeliverFax1 { get; set; }

    public string? DeliverContact { get; set; }

    public string? Attention { get; set; }

    public string? Contact { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Fax1 { get; set; }

    public string? Fax2 { get; set; }

    public string? NatureOfBusiness { get; set; }

    public string? EmailAddress { get; set; }

    public byte[]? Logo { get; set; }

    public byte[]? Signature { get; set; }

    public string? ReportHeader { get; set; }

    public int? TaxEntityId { get; set; }
}
