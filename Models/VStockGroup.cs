using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VStockGroup
{
    public string ItemGroup { get; set; } = null!;

    public string? ItemGroupDescription { get; set; }

    public string? ItemGroupDesc2 { get; set; }

    public string? Note { get; set; }

    public string? SalesCode { get; set; }

    public string? CashSalesCode { get; set; }

    public string? SalesReturnCode { get; set; }

    public string? SalesDiscountCode { get; set; }

    public string? PurchaseDiscountCode { get; set; }

    public string? PurchaseCode { get; set; }

    public string? CashPurchaseCode { get; set; }

    public string? PurchaseReturnCode { get; set; }
}
