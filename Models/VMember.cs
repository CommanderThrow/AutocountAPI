using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VMember
{
    public string MemberNo { get; set; } = null!;

    public string? MemberName { get; set; }

    public string? MemberAddress1 { get; set; }

    public string? MemberAddress2 { get; set; }

    public string? MemberAddress3 { get; set; }

    public string? MemberAddress4 { get; set; }

    public string? MemberDepartment { get; set; }

    public string? MemberTitle { get; set; }

    public string? MemberMobilePhone { get; set; }

    public string? MemberDirectPhone { get; set; }

    public string? MemberDirectFax { get; set; }

    public string? MemberEmailAddress { get; set; }

    public string? MemberImaddress { get; set; }

    public string? MemberNote { get; set; }
}
