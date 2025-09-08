using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class PocketSyncProfile
{
    public long ProfileKey { get; set; }

    public string ProfileName { get; set; } = null!;

    public string? Email { get; set; }

    public short ExpiredDays { get; set; }

    public byte[]? Criteria { get; set; }

    public string? FolderName { get; set; }

    public DateTime? LastDate { get; set; }

    public DateTime? LastSynchronized { get; set; }

    public string? SyncId { get; set; }

    public string? DeviceId { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedUserId { get; set; }

    public int? LastUpdate { get; set; }

    public virtual User? LastModifiedUser { get; set; }
}
