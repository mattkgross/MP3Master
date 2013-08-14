using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MP3UnitTest
{
    [TestClass]
    public class BasicFunctionalities
    {
        private string path;

        [TestInitialize]
        private void Initialization()
        {
            // TODO: Create a fake mp3 file w/ attributes.
            path = Directory.GetCurrentDirectory() + "\\test.mp3";
            File.Create(path);
        }

        [TestCleanup]
        private void Cleanup()
        {
            File.Delete(path);
        }

        [TestMethod]
        public void GetsAllArtists()
        {
            
        }
    }
}
