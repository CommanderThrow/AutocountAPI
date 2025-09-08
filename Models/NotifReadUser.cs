using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class NotifReadUser
{
    public long NotificationKey { get; set; }

    public string UserId { get; set; } = null!;
}
