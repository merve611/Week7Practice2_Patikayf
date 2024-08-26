using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Practice2_Patikayf
{
    public class Artist:IComparable<Artist>
    {
        public string FullName { get; set; }
        public string MusicGenre { get; set; }      //müzik türü
        public int ReleaseYear { get; set; }        //çıkış yılı
        public int AlbumSales { get; set; }         //album satış sayısı

        public int CompareTo(Artist? other)
        {
            throw new NotImplementedException();
        }


    }
}
