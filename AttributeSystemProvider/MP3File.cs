using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace AttributeSystemProvider
{
    public class MP3File : Media
    {
        public MP3File(string filePath)
            : base(filePath)
        {

        }

        #region Track Get Methods

        public string GetTrackName()
        {
            return _mediaFile.Tag.Title;
        }

        public List<string> GetArtists()
        {
            return new List<string>(_mediaFile.Tag.Performers);
        }

        public string GetFirstArtist()
        {
            return _mediaFile.Tag.FirstPerformer;
        }

        public string GetAlbum()
        {
            return _mediaFile.Tag.Album;
        }

        public uint GetYear()
        {
            return _mediaFile.Tag.Year;
        }

        public uint GetTrackNumber()
        {
            return _mediaFile.Tag.Track;
        }

        public uint GetTrackCount()
        {
            return _mediaFile.Tag.TrackCount;
        }

        public uint GetDiscNumber()
        {
            return _mediaFile.Tag.Disc;
        }

        public uint GetDiscCount()
        {
            return _mediaFile.Tag.DiscCount;
        }

        public string GetGenre()
        {
            return _mediaFile.Tag.FirstGenre;
        }

        public uint GetDecibel()
        {
            throw new NotImplementedException();
        }

        public IPicture GetAlbumArt()
        {
            return _mediaFile.Tag.Pictures.Length == 0 ? null : _mediaFile.Tag.Pictures[0];
        }

        #endregion

        #region Track Set Methods

        public void SetTrackName(string name)
        {
            _mediaFile.Tag.Title = name;
            _mediaFile.Save();
        }

        public void SetArtists(string artist)
        {
            _mediaFile.Tag.Performers = new string[] { artist };
            _mediaFile.Save();
        }

        public void SetArtists(List<string> artists)
        {
            _mediaFile.Tag.Performers = artists.ToArray();
            _mediaFile.Save();
        }

        public void SetAlbum(string album)
        {
            _mediaFile.Tag.Album = album;
            _mediaFile.Save();
        }

        public void SetYear(uint year)
        {
            _mediaFile.Tag.Year = year;
            _mediaFile.Save();
        }

        public void SetTrackNumber(uint num)
        {
            _mediaFile.Tag.Track = num;
            _mediaFile.Save();
        }

        public void SetTrackCount(uint count)
        {
            _mediaFile.Tag.TrackCount = count;
            _mediaFile.Save();
        }

        public void SetDiscNumber(uint num)
        {
            _mediaFile.Tag.Disc = num;
            _mediaFile.Save();
        }

        public void SetDiscCount(uint count)
        {
            _mediaFile.Tag.DiscCount = count;
            _mediaFile.Save();
        }

        public void SetGenre(Genre genre)
        {
            _mediaFile.Tag.Genres = new string[] { genre.GetGenre() };
            _mediaFile.Save();
        }

        public void SetDecibelDefault()
        {
            throw new NotImplementedException();
        }

        public void SetAlbumArt(Picture photo)
        {
            _mediaFile.Tag.Pictures = new IPicture[] { photo };
            _mediaFile.Save();
        }

        #endregion

        public void ClearAllTags()
        {
            _mediaFile.Tag.Clear();
            _mediaFile.Save();
        } 
    }
}
