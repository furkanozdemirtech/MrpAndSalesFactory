using MrpAndSalesFactory.Entity.Models;
using System.Data.Entity;

namespace MrpAndSalesFactory.DataAccessLayer.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Adres> Adress { get; set; }

        public DbSet<Cari> Caris { get; set; }

        public DbSet<CariAylik> CariAyliks { get; set; }

        public DbSet<ErpAltIsemri> ErpAltIsemris { get; set; }

        public DbSet<ErpAltIsemriDetay> ErpAltIsemriDetays { get; set; }
        public DbSet<ErpIsemri> ErpIsemris { get; set; }

        public DbSet<ErpSevkEmri> ErpSevkEmris { get; set; }
        public DbSet<ErpSevkEmriDetay> ErpSevkEmriDetays { get; set; }

        public DbSet<ErpStokAmbalaj> ErpStokAmbalajs { get; set; }

        public DbSet<ErpStokMaliyet> ErpStokMaliyets { get; set; }

        public DbSet<ErpStokOzellik> ErpStokOzelliks { get; set; }
        public DbSet<ErpStokVaryant> ErpStokVaryants { get; set; }

        public DbSet<ErpTedarikci> ErpTedarikcis { get; set; }

        public DbSet<ErpTezgah> ErpTezgahs { get; set; }

        public DbSet<ErpTezgahMaliyet> ErpTezgahMaliyets { get; set; }

        public DbSet<ErpUretimDurus> ErpUretimDuruss { get; set; }

        public DbSet<ErpUretimFisi> ErpUretimFisis { get; set; }

        public DbSet<ErpUretimFisiDetay> ErpUretimFisiDetays { get; set; }

        public DbSet<ErpUretimOperasyon> ErpUretimOperasyons { get; set; }
        public DbSet<ErpUretimPanel> ErpUretimPanels { get; set; }

        public DbSet<ErpUretimPanelDurum> ErpUretimPanelDurums { get; set; }

        public DbSet<ErpUretimPanelOperasyon> ErpUretimPanelOperasyons { get; set; }

        public DbSet<ErpUrunAgaci> ErpUrunAgacis { get; set; }

        public DbSet<ErpUrunAgaciDetay> ErpUrunAgaciDetays { get; set; }

        public DbSet<ErpUrunAgaciKombini> ErpUrunAgaciKombinis { get; set; }

        public DbSet<ErpVaryant> ErpVaryants { get; set; }

        public DbSet<ErpVaryantDetay> ErpVaryantDetays { get; set; }

        public DbSet<ErpVaryantOlcu> ErpVaryantOlcus { get; set; }

        public DbSet<Fatura> Faturas { get; set; }

        public DbSet<Firmalar> Firmalars { get; set; }
        public DbSet<Fiyat> Fiyats { get; set; }

        public DbSet<Grup> Grups { get; set; }

        public DbSet<HizliSatisTanim> HizliSatisTanims { get; set; }

        public DbSet<KurBaglanti1> KurBaglanti1s { get; set; }

        public DbSet<KurBaglanti2> KurBaglanti2s { get; set; }

        public DbSet<Kurgiris> Kurgiriss { get; set; }
        public DbSet<Loginfo> Loginfos { get; set; }
        public DbSet<Paket> Paket { get; set; }

        public DbSet<Paketdeger> Paketdegers { get; set; }

        public DbSet<Paketonay> Paketonays { get; set; }

        public DbSet<Personel> Personels { get; set; }

        public DbSet<Rapor> Rapors { get; set; }

        public DbSet<SatinalmaSozCiro> SatinalmaSozCiros { get; set; }

        public DbSet<SatinalmaSozCiroDetay> SatinalmaSozCiroDetays { get; set; }

        public DbSet<SatinalmaSozCiroStok> SatinalmaSozCiroStoks { get; set; }
        public DbSet<SatinalmaSozHareket> SatinalmaSozHarekets { get; set; }

        public DbSet<SatinalmaSozlesmeFis> SatinalmaSozlesmeFiss { get; set; }

        public DbSet<Satis> Satiss { get; set; }

        public DbSet<Sevkiyat> Sevkiyats { get; set; }

        public DbSet<Sevkiyatdetay> Sevkiyatdetays { get; set; }

        public DbSet<Sevkiyattamamlama> Sevkiyattamamlamas { get; set; }

        public DbSet<Siparis> Sipariss { get; set; }

        public DbSet<Stok> Stoks { get; set; }

        public DbSet<Teklif> Teklifs { get; set; }

        public DbSet<TeklifHar> TeklifHars { get; set; }

        public DbSet<TeklifYetki> TeklifYetkis { get; set; }

        public DbSet<UretimTekstilParca> UretimTekstilParcas { get; set; }

        public DbSet<UrtCizim> UrtCizims { get; set; }

        public DbSet<UrtCizimSure> UrtCizimSures { get; set; }

        public DbSet<UrtDurum> UrtDurums { get; set; }

        public DbSet<UrtKategoriAltGrup> UrtKategoriAltGrups { get; set; }

        public DbSet<UrtKategoriUstGrup> UrtKategoriUstGrups { get; set; }

        public DbSet<UrtMakine> UrtMakines { get; set; }

        public DbSet<UrtMakineDeger> UrtMakineDegers { get; set; }

        public DbSet<UrtSevkBirim> UrtSevkBirims { get; set; }

        public DbSet<UrtVardiya> UrtVardiyas { get; set; }

        public DbSet<Users> Userss { get; set; }

        public DbSet<Yetki> Yetki { get; set; }

        public DbSet<Yetkikodu> Yetkikodus { get; set; }

        public DbSet<Yetkili> Yetkilis { get; set; }


    }
}
