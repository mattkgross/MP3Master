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
        private string _path1, _path2;
        private MP3File _mp3_1, _mp3_2;

        [SetUp]
        public void Init()
        {
            // Create Test Directory w/ Empty File & Pretagged File
            _testDir = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Test");
            _path1 = _testDir + "\\test1.mp3";
            _path2 = _testDir + "\\test2.mp3";

            System.IO.File.WriteAllBytes(_path1, DataEnums.mp3Empty);
            _mp3_1 = new MP3File(_path1);
            System.IO.File.WriteAllBytes(_path2, DataEnums.mp3Tagged);
            _mp3_2 = new MP3File(_path2);
        }

        [TearDown]
        public void Dispose()
        {
            System.IO.File.Delete(_path1);
            System.IO.File.Delete(_path2);
            Directory.Delete(_testDir.FullName);
        }

        #region MP3 Set Methods
        [Test]
        [Category("SetMethods")]
        public void SetTrackName()
        {
            var name = "Test Name";
            _mp3_1.SetTrackName(name);

            Assert.True(String.Equals(name, _mp3_1.GetTrackName()));
        }

        [Test]
        [Category("SetMethods")]
        public void SetArtist()
        {
            var artist = "Test Artist";
            _mp3_1.SetArtists(artist);

            Assert.IsNotNullOrEmpty(_mp3_1.GetFirstArtist());
            Assert.AreEqual(1, _mp3_1.GetArtists().Count);
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
            _mp3_1.SetArtists(artists);

            Assert.IsNotNull(_mp3_1.GetArtists());
            Assert.AreEqual(3, _mp3_1.GetArtists().Count);
        }

        [Test]
        [Category("SetMethods")]
        public void SetAlbum()
        {
            var album = "Test Album";
            _mp3_1.SetAlbum(album);

            Assert.True(String.Equals(album, _mp3_1.GetAlbum()));
        }

        [Test]
        [Category("SetMethods")]
        public void SetYear()
        {
            var year = (uint) 29;
            _mp3_1.SetYear(year);

            Assert.AreEqual(year, _mp3_1.GetYear());
        }

        [Test]
        [Category("SetMethods")]
        public void SetTrackNumber()
        {
            var number = (uint) 30;
            _mp3_1.SetTrackNumber(number);

            Assert.AreEqual(number, _mp3_1.GetTrackNumber());
        }

        [Test]
        [Category("SetMethods")]
        public void SetTrackCount()
        {
            var count = (uint) 31;
            _mp3_1.SetTrackCount(count);

            Assert.AreEqual(count, _mp3_1.GetTrackCount());
        }

        [Test]
        [Category("SetMethods")]
        public void SetDiscNumber()
        {
            var number = (uint) 32;
            _mp3_1.SetDiscNumber(number);

            Assert.AreEqual(number, _mp3_1.GetDiscNumber());
        }

        [Test]
        [Category("SetMethods")]
        public void SetDiscCount()
        {
            var count = (uint) 33;
            _mp3_1.SetDiscCount(count);

            Assert.AreEqual(count, _mp3_1.GetDiscCount());
        }

        [Test]
        [Category("SetMethods")]
        public void SetGenre()
        {
            var genre = new Genre("pOp");
            _mp3_1.SetGenre(genre);

            Assert.True(String.Equals("Pop", _mp3_1.GetGenre()));
        }

        [Test]
        [Category("SetMethods")]
        public void SetAlbumArt()
        {
            var art = new Picture(new ByteVector(DataEnums.jpegEmpty, DataEnums.jpegEmpty.Length));
            _mp3_1.SetAlbumArt(art);

            Assert.IsNotNull(_mp3_1.GetAlbumArt());
        }
        #endregion

        #region MP3 Get Methods
        [Test]
        [Category("GetMethods")]
        public void GetTrackName()
        {
            var name = "Test Name";

            Assert.True(String.Equals(name, _mp3_2.GetTrackName()));
        }

        [Test]
        [Category("GetMethods")]
        public void GetArtist()
        {
            var artist = "Test Artist 1, Test Artist 2";

            var nud = _mp3_2.GetFirstArtist();
            
            Assert.True(String.Equals(artist, _mp3_2.GetFirstArtist()));
        }

        [Test]
        [Category("GetMethods")]
        public void GetArtists()
        {
            var artists = new List<string>()
                            {
                                "Test Artist 1, Test Artist 2"
                            };

            Assert.AreEqual(artists.Count, _mp3_2.GetArtists().Count);
        }

        [Test]
        [Category("GetMethods")]
        public void GetAlbum()
        {
            var album = "Test Album";

            Assert.True(String.Equals(album, _mp3_2.GetAlbum()));
        }

        [Test]
        [Category("GetMethods")]
        public void GetYear()
        {
            var year = (uint)0;

            Assert.AreEqual(year, _mp3_2.GetYear());
        }

        [Test]
        [Category("GetMethods")]
        public void GetTrackNumber()
        {
            var number = (uint)30;

            Assert.AreEqual(number, _mp3_2.GetTrackNumber());
        }

        [Test]
        [Category("GetMethods")]
        public void GetTrackCount()
        {
            var count = (uint)31;

            Assert.AreEqual(count, _mp3_2.GetTrackCount());
        }

        [Test]
        [Category("GetMethods")]
        public void GetDiscNumber()
        {
            var number = (uint)32;

            Assert.AreEqual(number, _mp3_2.GetDiscNumber());
        }

        [Test]
        [Category("GetMethods")]
        public void GetDiscCount()
        {
            var count = (uint)33;

            Assert.AreEqual(count, _mp3_2.GetDiscCount());
        }

        [Test]
        [Category("GetMethods")]
        public void GetGenre()
        {
            var genre = new Genre("Pop").GetGenre();

            Assert.True(String.Equals(genre, _mp3_2.GetGenre()));
        }

        [Test]
        [Category("GetMethods")]
        public void GetAlbumArt()
        {
            Assert.IsNotNull(_mp3_2.GetAlbumArt());
        }
        #endregion
    }
}
