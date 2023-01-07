namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Oğuz";
            musteri1.SurName = "Özyurt";
            musteri1.DateOfBirth = "15.02.1997";
            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Name = "Cem",
                SurName = "Candan",
                DateOfBirth = "25.05.1995"

            };
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Ertan";
            musteri3.SurName = "Kocatopcu";
            musteri3.DateOfBirth = "12.12.2012";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriListele(musteriler);

       





        }
    }
}