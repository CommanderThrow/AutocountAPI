using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class VAppaymentDetail
{
    public long DocKey { get; set; }

    public long DtlKey { get; set; }

    public int Seq { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? PaymentBy { get; set; }

    public string? ChequeNo { get; set; }

    public short? FloatDay { get; set; }

    public decimal? BankCharge { get; set; }

    public decimal? PaymentAmt { get; set; }

    public decimal? LocalPaymentAmt { get; set; }

    public decimal? CreditorPaymentAmt { get; set; }

    public string IsRchq { get; set; } = null!;

    public DateTime? Rchqdate { get; set; }

    public long? DepositDocKey { get; set; }

    public string? BankChargeProjNo { get; set; }

    public string? BankChargeDeptNo { get; set; }

    public string? BankChargeTaxCode { get; set; }

    public decimal? BankChargeTaxRate { get; set; }

    public decimal? BankChargeTax { get; set; }

    public string? BankChargeTaxRefNo { get; set; }
}
