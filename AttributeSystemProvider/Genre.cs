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

            if (DataEnums.genreOptions.ContainsKey(_genre))
                _genre = DataEnums.genreOptions
        }
    }
}
