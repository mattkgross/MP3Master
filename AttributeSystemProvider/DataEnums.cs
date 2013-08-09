using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSystemProvider
{
    public class DataEnums
    {
        // Lists all lower case genres and their corrsponding, formatted counterparts
        public static readonly Dictionary<string, string> genreOptions = new Dictionary<string,string> { 
            {"alternative", "Alternative"}, {"books & spoken", "Books & Spoken"}, {"christian", "Christian"},
            {"classical", "Classical"}, {"comedy", "Comedy"}, {"country", "Country"}, {"dance", "Dance"},
            {"electronic", "Electronic"}, {"folk", "Folk"}, {"hip-hop/rap", "Hip-Hop/Rap"}, {"indie", "Indie"},
            {"mashup", "Mashup"}, {"metal", "Metal"}, {"new age", "New Age"}, {"pop", "Pop"},
            {"pop latino", "Pop Latino"}, {"r&b/soul", "R&B/Soul"}, {"rock", "Rock"},
            {"singer/songwriter", "Singer/Songwriter"}, {"soundtrack", "Soundtrack"}, {"world", "World"}
        };

        // Lists all schema options with the corresponding GET method of the MP3File class
        public static readonly Dictionary<string, string> schemaOptions = new Dictionary<string, string> {
            {"Artist", "GetFirstArtist"}, {"Album", "GetAlbum"}
        };

        // Lists all song name options - BE SURE TO ADD A SWITCH STATEMENT CASE TO Form1.StructuredMove FOR ANY YOU ADD
        public enum songName { Original_Name, Track_Title, Song_Title };
        public static readonly Dictionary<string, songName> songOptions = new Dictionary<string, songName> {
            {"Original Name", songName.Original_Name}, {"Track # - Song Title", songName.Track_Title},
            {"Song Title", songName.Song_Title}
        };
    }
}
