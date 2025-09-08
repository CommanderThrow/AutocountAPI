using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ManifestDtl
{
    public string ManifestDtlId { get; set; } = null!;

    public string? ManifestId { get; set; }

    public string? SodocNo { get; set; }

    public long? SodocKey { get; set; }

    public DateTime? SodocDate { get; set; }

    public string? SocompanyName { get; set; }

    public string? Soaddress1 { get; set; }

    public string? Soaddress2 { get; set; }

    public string? Soaddress3 { get; set; }

    public string? Soaddress4 { get; set; }

    public string? Soarea { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public string? PostedToDocType { get; set; }

    public string? PostedToDocNo { get; set; }

    public long? PostedToDocKey { get; set; }

    public string? PickingListId { get; set; }

    public string? PickingListDocNo { get; set; }

    public string? SodebtorCode { get; set; }

    public string? DodocNo { get; set; }

    public long? DodocKey { get; set; }

    public string? IvdocNo { get; set; }

    public long? IvdocKey { get; set; }

    public decimal? TotalFocWeight { get; set; }

    public decimal? TotalFocVolume { get; set; }
}
