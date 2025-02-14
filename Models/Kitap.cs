namespace BookStore.Models
{
    public class Kitap
    {
        public int Id { get; set; }//PK
        public string KitapAd { get; set; }
        public double Fiyat { get; set; }
        public int KategoriId { get; set; }//FK
        //Navigation Property
        public Kategori Kategori { get; set; }

    }
}

/*
 * 1-Python-200-3
 * 2-Şeker Portakalı-188-2
 * 3-CSharp Öğreniyorum-196-3
 */