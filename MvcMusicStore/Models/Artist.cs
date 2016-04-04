using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        public int ArtistID
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public List<Album> Albums
        {
            get;
            set;
        }
    }
}
