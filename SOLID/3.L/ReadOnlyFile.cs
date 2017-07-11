using System.IO;

namespace SOLID.L
{
    public class ReadOnlyFile : File
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from file */
            return string.Empty;
        }
        public void SaveText()
        {
            /* Throw an exception when app flow tries to do save. */
            throw new IOException("Can't Save");
        }
    }
}

