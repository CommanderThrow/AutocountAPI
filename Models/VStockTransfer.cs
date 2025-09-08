using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockTransfer
{
    public long DocKey { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string? Description { get; set; }

    public decimal? Total { get; set; }

    public string? Reason { get; set; }

    public string? AuthorisedBy { get; set; }

    public string? Ref { get; set; }

    public string? Note { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public short PrintCount { get; set; }

    public string Cancelled { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public string LastModifiedUserId { get; set; } = null!;

    public string? LastModifiedUserName { get; set; }

    public DateTime CreatedTimeStamp { get; set; }

    public string CreatedUserId { get; set; } = null!;

    public string? CreatedUserName { get; set; }

    public string? ExternalLink { get; set; }

    public string? RefDocNo { get; set; }

    public string CanSync { get; set; } = null!;

    public string FromLocation { get; set; } = null!;

    public string? FromLocationDescription { get; set; }

    public string? FromLocationDesc2 { get; set; }

    public string? FromLocationAddr1 { get; set; }

    public string? FromLocationAddr2 { get; set; }

    public string? FromLocationAddr3 { get; set; }

    public string? FromLocationAddr4 { get; set; }

    public string? FromLocationPostCode { get; set; }

    public string? FromLocationPhone1 { get; set; }

    public string? FromLocationPhone2 { get; set; }

    public string? FromLocationFax1 { get; set; }

    public string? FromLocationFax2 { get; set; }

    public string? FromLocationContact { get; set; }

    public string? FromLocationNote { get; set; }

    public string ToLocation { get; set; } = null!;

    public string? ToLocationDescription { get; set; }

    public string? ToLocationDesc2 { get; set; }

    public string? ToLocationAddr1 { get; set; }

    public string? ToLocationAddr2 { get; set; }

    public string? ToLocationAddr3 { get; set; }

    public string? ToLocationAddr4 { get; set; }

    public string? ToLocationPostCode { get; set; }

    public string? ToLocationPhone1 { get; set; }

    public string? ToLocationPhone2 { get; set; }

    public string? ToLocationFax1 { get; set; }

    public string? ToLocationFax2 { get; set; }

    public string? ToLocationContact { get; set; }

    public string? ToLocationNote { get; set; }

    public string? XferudfSuperAppId { get; set; }
}
