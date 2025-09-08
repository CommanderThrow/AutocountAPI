using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class UsersPurchaseAgent
{
    public string UserId { get; set; } = null!;

    public string PurchaseAgent { get; set; } = null!;
}
