using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022Bi
{
    public string DocNo { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public string? Description { get; set; }

    public string? FromDocNo { get; set; }

    public string? FromDocType { get; set; }

    public string? ToDocNo { get; set; }

    public string? ToDocType { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDateTime { get; set; }

    public DateTime? SuggestedDateTime { get; set; }

    public bool? Cancelled { get; set; }

    public DateTime? FromDocLastModifiedDate { get; set; }
}
