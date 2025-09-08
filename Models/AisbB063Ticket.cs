using System;
using System.Collections.Generic;

namespace AutocountAPI.Models;

public partial class AisbB063Ticket
{
    public string Guid { get; set; } = null!;

    public string? NoAkaunPenggadai { get; set; }

    public string? NoSiri { get; set; }

    public string? NoFile { get; set; }

    public string? NoKadPengenalan { get; set; }

    public string? NamaPenggadai { get; set; }

    public DateOnly? TarikhLahir { get; set; }

    public string? Jantina { get; set; }

    public string? Bangsa1 { get; set; }

    public string? Bangsa2 { get; set; }

    public string? Kerakyatan { get; set; }

    public string? NomborTelefon1 { get; set; }

    public string? NomborTelefon2 { get; set; }

    public string? NomborTelefon3 { get; set; }

    public string? AlamatPenggadai { get; set; }

    public string? AlamatSuratMenyurat { get; set; }

    public string? BernilaiBersihTinggi { get; set; }

    public string? Tfs { get; set; }

    public string? NamaMajikan { get; set; }

    public string? JenisPerjaanMajikan { get; set; }

    public string? NoKadPengenalanPemilik { get; set; }

    public string? NamaPemilik { get; set; }

    public DateOnly? TarikhLahirPemilik { get; set; }

    public string? BangsaPemilik1 { get; set; }

    public string? BangsaPemilik2 { get; set; }

    public string? JantinaPemilik { get; set; }

    public string? KerakyatanPemilik { get; set; }

    public string? AlamatPemilik { get; set; }

    public string? PerihalSadaran { get; set; }

    public int? BilanganSadaran { get; set; }

    public decimal? AnggaranBerat { get; set; }

    public decimal? Berat { get; set; }

    public decimal? NilaiSandaran { get; set; }

    public string? TujuanTransaksi { get; set; }

    public DateOnly? TarikhGadai { get; set; }

    public DateOnly? TarikhLuput { get; set; }

    public DateOnly? TarikhHarga { get; set; }

    public int? MasaPenebusan { get; set; }

    public decimal? KeuntunganBulanan { get; set; }

    public decimal? Insurance { get; set; }

    public decimal? AmaunPinjaman { get; set; }

    public string? Status { get; set; }

    public string? RenewFromSiri { get; set; }

    public DateTime? CreatedAt { get; set; }

    public long? ArRefundDocKey { get; set; }

    public string? ArRefundDocNo { get; set; }

    public long? IvDocKey { get; set; }

    public string? IvDocNo { get; set; }

    public long? ArPaymentDocKey { get; set; }

    public string? ArPaymentDocNo { get; set; }

    public long? ArRefundKnockOffKey { get; set; }

    public virtual ICollection<AisbB063Berat> AisbB063Berats { get; set; } = new List<AisbB063Berat>();
}
