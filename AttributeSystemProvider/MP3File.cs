﻿using System;
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

        #region Get Methods

        public string GetTrackName()
        {
            return _mediaFile.Tag.Title;
        }

        public List<string> GetArtists()
        {
            return new List<string>(_mediaFile.Tag.AlbumArtists);
        }

        public string GetFirstArtist()
        {
            return _mediaFile.Tag.FirstAlbumArtist;
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

        #endregion

        #region Set Methods

        public void SetTrackName(string name)
        {
            _mediaFile.Tag.Title = name;
            _mediaFile.Save();
        }

        public void SetArtists(string artist)
        {
            _mediaFile.Tag.AlbumArtists = new string[] { artist };
            _mediaFile.Save();
        }

        public void SetArtists(List<string> artists)
        {
            _mediaFile.Tag.AlbumArtists = artists.ToArray();
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
            _mediaFile.Tag.Genres = new string[] { genre.ToString() };
        }

        #endregion
    }
}