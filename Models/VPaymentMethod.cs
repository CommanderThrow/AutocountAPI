using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VPaymentMethod
{
    public string PaymentMethod { get; set; } = null!;

    public string BankAccount { get; set; } = null!;

    public string? BankChargeAccount { get; set; }

    public decimal BankChargePercent { get; set; }

    public string MergeBankChargeTrans { get; set; } = null!;

    public string SpecialAccType { get; set; } = null!;

    public string JournalType { get; set; } = null!;

    public string AcceptChequeNo { get; set; } = null!;

    public decimal Odlimit { get; set; }

    public string PaymentFormatName { get; set; } = null!;

    public string ReceiptFormatName { get; set; } = null!;

    public string IsActive { get; set; } = null!;
}
