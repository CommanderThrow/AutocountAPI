using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class MailQueue
{
    public long Id { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? FromName { get; set; }

    public string? FromEmail { get; set; }

    public string? Email { get; set; }

    public string? Ccemail { get; set; }

    public string? Bccemail { get; set; }

    public string? RecipientName { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateTime NextRetryTime { get; set; }

    public int RetryCount { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual ICollection<MailQueueDtl> MailQueueDtls { get; set; } = new List<MailQueueDtl>();
}
