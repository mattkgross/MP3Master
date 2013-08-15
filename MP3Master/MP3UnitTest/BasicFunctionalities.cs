using AttributeSystemProvider;
using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using TagLib;

namespace MP3UnitTest
{
    [TestFixture]
    public class BasicFunctionalities
    {
        private DirectoryInfo _testDir;
        private string _path;
        private MP3File _mp3;

        // TODO: Make mp3 with pre-filled info for get methods

        [SetUp]
        public void Init()
        {
            // Create Test Directory w/ Empty File
            _testDir = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Test");
            _path = _testDir + "\\test.mp3";

            System.IO.File.WriteAllBytes(_path, DataEnums.mp3Empty);
            _mp3 = new MP3File(_path);
        }

        [TearDown]
        public void Dispose()
        {
            System.IO.File.Delete(_path);
            Directory.Delete(_testDir.FullName);
        }

        #region MP3 Set Methods
        [Test]
        [Category("SetMethods")]
        public void SetTrackName()
        {
            var name = "Test Name";
            _mp3.SetTrackName(name);

            Assert.True(String.Equals(name, _mp3.GetTrackName()));
        }

        [Test]
        [Category("SetMethods")]
        public void SetArtist()
        {
            var artist = "Test Artist";
            _mp3.SetArtists(artist);

            Assert.IsNotNullOrEmpty(_mp3.GetFirstArtist());
            Assert.AreEqual(1, _mp3.GetArtists().Count);
        }

        [Test]
        [Category("SetMethods")]
        public void SetArtists()
        {
            var artists = new List<string>()
                              {
                                  "Test Artist 1",
                                  "Test Artist 2",
                                  "Test Artist 3"
                              };
            _mp3.SetArtists(artists);

            Assert.IsNotNull(_mp3.GetArtists());
            Assert.AreEqual(3, _mp3.GetArtists().Count);
        }

        [Test]
        [Category("SetMethods")]
        public void SetAlbum()
        {
            var album = "Test Album";
            _mp3.SetAlbum(album);

            Assert.True(String.Equals(album, _mp3.GetAlbum()));
        }

        [Test]
        [Category("SetMethods")]
        public void SetYear()
        {
            var year = (uint) 2999;
            _mp3.SetYear(year);

            Assert.AreEqual(year, _mp3.GetYear());
        }

        [Test]
        [Category("SetMethods")]
        public void SetTrackNumber()
        {
            var number = (uint) 3000;
            _mp3.SetTrackNumber(number);

            Assert.AreEqual(number, _mp3.GetTrackNumber());
        }

        [Test]
        [Category("SetMethods")]
        public void SetTrackCount()
        {
            var count = (uint) 3001;
            _mp3.SetTrackCount(count);

            Assert.AreEqual(count, _mp3.GetTrackCount());
        }

        [Test]
        [Category("SetMethods")]
        public void SetDiscNumber()
        {
            var number = (uint) 3002;
            _mp3.SetDiscNumber(number);

            Assert.AreEqual(number, _mp3.GetDiscNumber());
        }

        [Test]
        [Category("SetMethods")]
        public void SetDiscCount()
        {
            var count = (uint) 3003;
            _mp3.SetDiscCount(count);

            Assert.AreEqual(count, _mp3.GetDiscCount());
        }

        [Test]
        [Category("SetMethods")]
        public void SetGenre()
        {
            var genre = new Genre("pOp");
            _mp3.SetGenre(genre);

            Assert.True(String.Equals("Pop", _mp3.GetGenre()));
        }

        [Test]
        [Category("SetMethods")]
        public void SetDecibelDefault()
        {
            // TODO: Implement test once decibel level is editable
        }

        [Test]
        [Category("SetMethods")]
        public void SetAlbumArt()
        {
            var art = new Picture(new ByteVector(DataEnums.jpegEmpty, DataEnums.jpegEmpty.Length));
            _mp3.SetAlbumArt(art);

            Assert.IsNotNull(_mp3.GetAlbumArt());
        }
        #endregion

        #region MP3 Get Methods
        [Test]
        [Category("GetMethods")]
        public void GetTrackName()
        {
            var name = "Test Name";
            _mp3.SetTrackName(name);

            Assert.IsNotNullOrEmpty(_mp3.GetTrackName());
        }

        [Test]
        [Category("GetMethods")]
        public void GetArtist()
        {
            var artist = "Test Artist";
            _mp3.SetArtists(artist);

            Assert.IsNotNullOrEmpty(_mp3.GetFirstArtist());
        }

        [Test]
        [Category("GetMethods")]
        public void GetArtists()
        {
            var artists = new List<string>()
                              {
                                  "Test Artist 1",
                                  "Test Artist 2",
                                  "Test Artist 3"
                              };
            _mp3.SetArtists(artists);

            Assert.IsNotNull(_mp3.GetArtists());
        }

        [Test]
        [Category("GetMethods")]
        public void GetAlbum()
        {
            var album = "Test Album";
            _mp3.SetAlbum(album);

            Assert.IsNotNullOrEmpty(_mp3.GetAlbum());
        }

        [Test]
        [Category("GetMethods")]
        public void GetYear()
        {
            var year = (uint)2999;
            _mp3.SetYear(year);

            Assert.IsNotNull(_mp3.GetYear());
        }

        [Test]
        [Category("GetMethods")]
        public void GetTrackNumber()
        {
            var number = (uint)3000;
            _mp3.SetTrackNumber(number);

            Assert.IsNotNull(_mp3.GetTrackNumber());
        }

        [Test]
        [Category("GetMethods")]
        public void GetTrackCount()
        {
            var count = (uint)3001;
            _mp3.SetTrackCount(count);

            Assert.IsNotNull(_mp3.GetTrackCount());
        }

        [Test]
        [Category("GetMethods")]
        public void GetDiscNumber()
        {
            var number = (uint)3002;
            _mp3.SetDiscNumber(number);

            Assert.IsNotNull(_mp3.GetDiscNumber());
        }

        [Test]
        [Category("GetMethods")]
        public void GetDiscCount()
        {
            var count = (uint)3003;
            _mp3.SetDiscCount(count);

            Assert.IsNotNull(_mp3.GetDiscCount());
        }

        [Test]
        [Category("GetMethods")]
        public void GetGenre()
        {
            var genre = new Genre("pOp");
            _mp3.SetGenre(genre);

            Assert.IsNotNullOrEmpty(_mp3.GetGenre());
        }

        [Test]
        [Category("GetMethods")]
        public void GetDecibelDefault()
        {
            // TODO: Implement test once decibel level is editable
        }

        [Test]
        [Category("GetMethods")]
        public void GetAlbumArt()
        {
            var art = new Picture(new ByteVector(DataEnums.jpegEmpty, DataEnums.jpegEmpty.Length));
            _mp3.SetAlbumArt(art);

            Assert.IsNotNull(_mp3.GetAlbumArt());
        }
        #endregion
    }
}
