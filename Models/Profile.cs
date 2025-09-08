using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class Profile
{
    public long AutoKey { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Remark { get; set; }

    public string? RegisterNo { get; set; }

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

    public string? LogoClass { get; set; }

    public string? ReportHeader { get; set; }

    public int? RemarkColor { get; set; }

    public int LastUpdate { get; set; }

    public string? CountriesInJson { get; set; }

    public string? SalesTaxRegisterNo { get; set; }

    public string? ServiceTaxRegisterNo { get; set; }

    public int? TaxEntityId { get; set; }

    public string? ItemMeasurementInJson { get; set; }

    public string? ItemClassificationInJson { get; set; }

    public string? MsiccodeInJson { get; set; }

    public string? EinvoiceCountryCodeInJson { get; set; }

    public string? CompanyId { get; set; }

    public string? PublicId { get; set; }

    public string? CompanyAccessKey { get; set; }

    public string? AccKeyId { get; set; }

    public string? AccApiKey { get; set; }

    public string? PoskeyId { get; set; }

    public string? PosapiKey { get; set; }

    public DateTime? AccExpiryTimestamp { get; set; }

    public DateTime? PosexpiryTimestamp { get; set; }

    public string? GenerateLinkResultJson { get; set; }

    public Guid Guid { get; set; }

    public bool? TinownershipValidated { get; set; }

    public byte[]? Signature { get; set; }

    public string? AccSubKeyId { get; set; }

    public string? AccSubApiKey { get; set; }

    public DateTime? AccSubExpiryTimestamp { get; set; }

    public bool IsSubCompany { get; set; }

    public bool IntermediaryLoginValidated { get; set; }

    public bool IsEinvoiceDeactivated { get; set; }

    public string? SgeinvoiceCompanyId { get; set; }

    public string? SgeinvoiceCompanyAccessKey { get; set; }

    public string? SgeinvoiceAccKeyId { get; set; }

    public string? SgeinvoiceAccApiKey { get; set; }

    public string? SgeinvoiceApiKey { get; set; }

    public string? SgeinvoiceApiSecret { get; set; }

    public string? SgeinvoicePeppolId { get; set; }

    public bool HasClientIdClientSecret { get; set; }

    public virtual TaxEntity? TaxEntity { get; set; }
}
