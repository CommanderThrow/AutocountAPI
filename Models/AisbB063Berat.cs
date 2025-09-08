using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB063Berat
{
    public string Guid { get; set; } = null!;

    public string? TicketGuid { get; set; }

    public decimal? BeratLkEmas999 { get; set; }

    public decimal? BeratEmas999 { get; set; }

    public decimal? BeratLkEmas950 { get; set; }

    public decimal? BeratEmas950 { get; set; }

    public decimal? BeratLkEmas916 { get; set; }

    public decimal? BeratEmas916 { get; set; }

    public decimal? BeratLkEmas875 { get; set; }

    public decimal? BeratEmas875 { get; set; }

    public decimal? BeratLkEmas835 { get; set; }

    public decimal? BeratEmas835 { get; set; }

    public decimal? BeratLkEmas750 { get; set; }

    public decimal? BeratEmas750 { get; set; }

    public decimal? BeratLkEmas585 { get; set; }

    public decimal? BeratEmas585 { get; set; }

    public decimal? BeratLkEmas375 { get; set; }

    public decimal? BeratEmas375 { get; set; }

    public decimal? BeratLkPerak925 { get; set; }

    public decimal? BeratPerak925 { get; set; }

    public decimal? BeratLkLain { get; set; }

    public decimal? BeratLain { get; set; }

    public virtual AisbB063Ticket? Ticket { get; set; }
}
