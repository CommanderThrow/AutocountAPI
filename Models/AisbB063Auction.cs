using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB063Auction
{
    public string Guid { get; set; } = null!;

    public string? GuidTicket { get; set; }

    public string? Schedule { get; set; }

    public string NumberRujukan { get; set; } = null!;

    public string? PerihalSandaranYangDijual { get; set; }

    public string? BilanganSandaranYangDijual { get; set; }

    public string? JumlahJualan { get; set; }

    public DateOnly? TarikhJualanLelong { get; set; }

    public string? NamaPembeli { get; set; }

    public string? NoKadPengenalan { get; set; }

    public string? Kerakyatan { get; set; }

    public string? Jantina { get; set; }

    public string? AlamatPembeli { get; set; }

    public string? KeuntunganYangPatutDibayarFaedah { get; set; }

    public string? KeuntunganYangPatutDibayarLain { get; set; }

    public string? KeuntunganYangPatutDikenakanFaedah { get; set; }

    public string? KeuntunganYangPatutDikenakanLain { get; set; }

    public string? FiPelelong { get; set; }

    public string? Gst { get; set; }

    public string? LebihanJualanLelongDiTanganPpg { get; set; }

    public string? CaraBayaran { get; set; }

    public string? LebihanJualanLelongYangDiserahBalikKepadaPemajak { get; set; }

    public string? LebihanJualanLelongYangTidakDituntutOlehPemajak { get; set; }

    public string? LebihanDiserahBalikKepadaPemajak { get; set; }

    public DateOnly? TarikhLahir { get; set; }

    public string? NoAkaunPenggadai { get; set; }

    public string? NoKadPengenalanPenggadai { get; set; }

    public string? NamaPenggadai { get; set; }

    public DateOnly? TarikhGadai { get; set; }

    public DateOnly? TarikhLuput { get; set; }

    public decimal? AmaunPinjaman { get; set; }

    public DateTime? CreatedAt { get; set; }
}
