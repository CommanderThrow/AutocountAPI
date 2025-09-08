using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB063Redemption
{
    public string Guid { get; set; } = null!;

    public string? NoSiri { get; set; }

    public string? NoPenebusan { get; set; }

    public DateOnly? TarikhPenebus { get; set; }

    public string? NoKadPengenalanPenebus { get; set; }

    public string? NamaPenebus { get; set; }

    public string? AlamatPenebus { get; set; }

    public string? Jantina { get; set; }

    public string? Bangsa { get; set; }

    public string? Bangsa2 { get; set; }

    public string? Kerakyatan { get; set; }

    public decimal? AmaunPinjaman { get; set; }

    public decimal? FaedahDikenakan { get; set; }

    public decimal? KeuntunganBulanan { get; set; }

    public DateOnly? TarikhGadai { get; set; }

    public decimal? JumlahKeseluruhanBayaran { get; set; }

    public string? PerihalSadaran { get; set; }

    public string? Catatan { get; set; }

    public DateOnly? TarikhLahir { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Status { get; set; }

    public string? TicketGuid { get; set; }

    public string? NoAkaunPenebus { get; set; }
}
