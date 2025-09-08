using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Am
{
    public string Amsid { get; set; } = null!;

    public string? DebtorCode { get; set; }

    public string? BranchCode { get; set; }

    public string? SalesLocation { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastModifiedUserId { get; set; }

    public DateTime? LastModifiedDateTime { get; set; }
}
