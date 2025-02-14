namespace BookStore.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        //Navigation Property
        public List<Kitap> Kitaplar { get; set; } = new();

    }
}

/*
 * 1-Roman
 * 2-Hikaye
 * 3-Bilgisayar
 */
