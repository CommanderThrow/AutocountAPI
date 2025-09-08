using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VBranch
{
    public string BranchAccNo { get; set; } = null!;

    public string BranchCode { get; set; } = null!;

    public string? BranchName { get; set; }

    public string? BranchAddress1 { get; set; }

    public string? BranchAddress2 { get; set; }

    public string? BranchAddress3 { get; set; }

    public string? BranchAddress4 { get; set; }

    public string? BranchPostCode { get; set; }

    public string? BranchContact { get; set; }

    public string? BranchPhone1 { get; set; }

    public string? BranchPhone2 { get; set; }

    public string? BranchMobile { get; set; }

    public string? BranchFax1 { get; set; }

    public string? BranchFax2 { get; set; }

    public string? BranchSalesAgent { get; set; }

    public string? BranchPurchaseAgent { get; set; }

    public string? BranchAreaCode { get; set; }

    public string? BranchEmailAddress { get; set; }

    public string BranchIsActive { get; set; } = null!;
}
