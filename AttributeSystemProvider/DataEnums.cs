using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSystemProvider
{
    public class DataEnums
    {
        public static readonly Dictionary<string, string> genreOptions = new Dictionary<string,string> { 
            {"alternative", "Alternative"}, {"books & spoken", "Books & Spoken"}, {"christian", "Christian"},
            {"classical", "Classical"}, {"comedy", "Comedy"}, {"country", "Country"}, {"dance", "Dance"},
            {"electronic", "Electronic"}, {"folk", "Folk"}, {"hip-hop/rap", "Hip-Hop/Rap"}, {"indie", "Indie"},
            {"mashup", "Mashup"}, {"metal", "Metal"}, {"new age", "New Age"}, {"pop", "Pop"},
            {"pop latino", "Pop Latino"}, {"r&b/soul", "R&B/Soul"}, {"rock", "Rock"},
            {"singer/songwriter", "Singer/Songwriter"}, {"soundtrack", "Soundtrack"}, {"world", "World"} };

        public static readonly string[] schemaOptions = { "Album", "Artist" };
    }
}
