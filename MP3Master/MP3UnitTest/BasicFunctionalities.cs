﻿using AttributeSystemProvider;
using System;
using System.IO;
using NUnit.Framework;

namespace MP3UnitTest
{
    [TestFixture]
    public class BasicFunctionalities
    {
        private DirectoryInfo _testDir;
        private string _path;
        private MP3File _mp3;

        [SetUp]
        public void Init()
        {
            // Create Test Directory w/ Empty File
            _testDir = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Test");
            _path = Directory.GetCurrentDirectory() + "\\Test\\test.mp3";
            File.Create(_path);
            _mp3 = new MP3File(_path);
        }

        [TearDown]
        public void Dispose()
        {
            File.Delete(_path);
            Directory.Delete(_testDir.FullName);
        }

        #region MP3 Set Methods
        [Test]
        public void SetTrackName_ValidName()
        {
            var name = "Test Name";
            _mp3.SetTrackName(name);

            NUnit.Framework.Assert.Equals("Test Name", String.Copy(_mp3.GetTrackName()));
        }
        #endregion

        #region MP3 Get Methods
        [Test]
        public void GetsAllArtists()
        {

        }
        #endregion
    }
}
