using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSystemProvider
{
    public class Genre
    {
        private string _genre;

        public Genre(string genre)
        {
            _genre = genre.ToLower();
            string value = "";

            _genre = !DataEnums.genreOptions.TryGetValue(_genre, out value) ? "" : value;
        }

        public bool SetGenre(string genre)
        {
            string value = "";

            if (!DataEnums.genreOptions.TryGetValue(genre, out value))
                return false;

            _genre = value;
            return true;
        }

        public string GetGenre()
        {
            return _genre;
        }
    }
}
