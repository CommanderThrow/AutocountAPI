﻿using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbA022ResultPo
{
    public string Guid { get; set; } = null!;

    public string? DocNo { get; set; }

    public string? DeviceId { get; set; }

    public string? DocType { get; set; }

    public string? CommittedBy { get; set; }

    public string? CreditorCode { get; set; }

    public string? Location { get; set; }

    public bool? Posted { get; set; }

    public int? PostCount { get; set; }

    public string? LastModifiedUserId { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public DateTime? DocDate { get; set; }

    public string? CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? Cancelled { get; set; }

    public string? CancelledUserId { get; set; }

    public DateTime? CommitedDateTime { get; set; }
}
