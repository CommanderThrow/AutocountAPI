using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class NotifAllowUser
{
    public long NotificationKey { get; set; }

    public string UserId { get; set; } = null!;
}
