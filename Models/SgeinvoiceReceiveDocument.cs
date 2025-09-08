using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class SgeinvoiceReceiveDocument
{
    public long DocKey { get; set; }

    public string? DocType { get; set; }

    public string? SenderPeppolId { get; set; }

    public string? ReceiverPeppolId { get; set; }

    public DateTime? UploadTime { get; set; }

    public string? Name { get; set; }

    public string? DocumentUuid { get; set; }

    public string? DocNo { get; set; }

    public DateTime? DocDate { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Reason { get; set; }

    public string? ResponseCode { get; set; }

    public long? AutoCountDocKey { get; set; }

    public DateTime? SyncTime { get; set; }

    public string? Data { get; set; }
}
