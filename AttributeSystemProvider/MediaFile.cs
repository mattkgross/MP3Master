using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace AttributeSystemProvider
{
    public interface MediaFile
    {
        string GetMediaPath();
        File.IFileAbstraction GetFileAbstract();
        File GetFile();
    }

    public abstract class Media : MediaFile
    {
        protected string _mediaSource;
        protected File.IFileAbstraction _mediaAbstract;
        protected File _mediaFile;

        public Media(string filePath)
        {
            _mediaSource = filePath;
            _mediaAbstract = new File.LocalFileAbstraction(_mediaSource);
            _mediaFile = File.Create(_mediaAbstract);
        }

        public virtual string GetMediaPath()
        {
            return _mediaSource;
        }

        public virtual File.IFileAbstraction GetFileAbstract()
        {
            return _mediaAbstract;
        }

        public virtual File GetFile()
        {
            return _mediaFile;
        }
    }
}
