using Figures.Base;
using System.IO;

namespace Figures.FileRepository
{
    public class FileWriter
    {
        private const string FileType = ".txt";
        private readonly string _path;
        private readonly string _fileName;

        public FileWriter(string path, string fileName)
        {
            _path = path;
            _fileName = fileName;
        }

        private string FullPath
        {
            get { return _path + "\\" + _fileName + FileType; }
        }

        public void SaveFigurePropertiesToFile(BaseFigure figure)
        {
            using (var file = GetFile())
            {
                file.WriteLine(figure.GetFigureInfo());
            }
        }

        private StreamWriter GetFile()
        {
            if (!File.Exists(FullPath))
            {
                return File.CreateText(FullPath);
            }
            else
            {
                return File.AppendText(FullPath);
            }
        }
    }
}
