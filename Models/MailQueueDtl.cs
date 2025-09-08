using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class MailQueueDtl
{
    public long Id { get; set; }

    public long MailQueueId { get; set; }

    public string Filename { get; set; } = null!;

    public byte[]? Binary { get; set; }

    public virtual MailQueue MailQueue { get; set; } = null!;
}
