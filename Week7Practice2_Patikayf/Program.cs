using Week7Practice2_Patikayf;

internal class Program
{
    public static void Main(string[] args)
    {
        //Sanatçıları atamak için bir liste oluşturuldu
        List<Artist> artists = new List<Artist>()
        {
            new Artist
            {
                FullName = "Ajda Pekkan", MusicGenre = "Pop", ReleaseYear = 1968, AlbumSales = 20000000,
            },
             new Artist
            {
                FullName = "Sezen Aksu", MusicGenre = "Türk Halk Müziği/Pop", ReleaseYear = 1971, AlbumSales = 10000000,
            },
              new Artist
            {
                FullName = "Funda Arar", MusicGenre = "Pop", ReleaseYear = 1999, AlbumSales = 3000000,
            },
               new Artist
            {
                FullName = "Sertap Erener", MusicGenre = "Pop", ReleaseYear = 1994, AlbumSales = 5000000,
            },
                new Artist
            {
                FullName = "Sıla", MusicGenre = "Pop", ReleaseYear = 2009, AlbumSales = 3000000,
            },
                 new Artist
            {
                FullName = "Serdar Ortaç", MusicGenre = "Pop", ReleaseYear = 1994, AlbumSales = 10000000,
            },
                  new Artist
            {
                FullName = "Tarkan", MusicGenre = "Pop", ReleaseYear = 1992, AlbumSales = 40000000,
            },
                   new Artist
            {
                FullName = "Hande Yener", MusicGenre = "Pop", ReleaseYear = 1999, AlbumSales = 7000000,
            },
                    new Artist
            {
                FullName = "Hadise", MusicGenre = "Pop", ReleaseYear = 2005, AlbumSales = 5000000,
            },
                     new Artist
            {
                FullName = "Gülben Ergen", MusicGenre = "Türk Halk Müziği/Pop", ReleaseYear = 1997, AlbumSales = 10000000,
            },
                      new Artist
            {
                FullName = "Neşet Ertaş", MusicGenre = "Türk Halk Müziği/Türk Sanat Müziği", ReleaseYear = 1960, AlbumSales = 2000000,
            },



        };


        //Sanatçıların full name sorgulanarak s ile başlayan seçildi
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar : ");

        var artistsStartingWithS = artists.Where(artist => artist.FullName.StartsWith("S"));

        foreach (var a in artistsStartingWithS)
        {
            Console.WriteLine(a.FullName);
        }

        Console.WriteLine("--------------------");
        //Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var onAlbumSales = artists.Where(a => a.AlbumSales > 10000000);
        foreach (var a in onAlbumSales)
        {
            Console.WriteLine($"şarkıcı ismi : {a.FullName}, albüm satış sayısı : {a.AlbumSales}");
        }
        Console.WriteLine("--------------------");
        // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. (Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

        List<Artist> filterList = new List<Artist>();
        filterList = artists.Where(a => a.ReleaseYear > 2000 && a.MusicGenre.Contains("Pop")).ToList();

        var groupByYear = filterList.GroupBy(a => a.ReleaseYear);
        foreach (var group in groupByYear)
        {
            Console.WriteLine($"{group.Key}");
            foreach (var artist in group)
            {
                Console.WriteLine($"{artist.FullName}");
            }
        }


        Console.WriteLine("--------------------");



        //En çok albüm satan şarkıcı
        Console.WriteLine("En çok albüm satan şarkıcı : ");

        var maxAlbumSales = artists.MaxBy(a => a.AlbumSales);
        Console.WriteLine(maxAlbumSales.FullName);

        //En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı

        Console.WriteLine("En yeni çıkış yapan sanatçı : ");
        var maxReleaseYear = artists.MaxBy(a => a.ReleaseYear);
        Console.WriteLine(maxReleaseYear.FullName);


        Console.WriteLine("En yeni çıkış yapan sanatçı : ");
        var minReleaseYear = artists.MinBy(a => a.ReleaseYear);
        Console.WriteLine(minReleaseYear.FullName);

    }
}