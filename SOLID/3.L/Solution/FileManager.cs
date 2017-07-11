using System.Collections.Generic;
using System.Text;

namespace SOLID.L.Solution
{
    public class FileManager
    {
        public string GetTextFromFiles(List<IReadableFile> readableFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in readableFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }

        public void SaveTextIntoFiles(List<IWritableFile> writableFiles)
        {
            foreach (var objFile in writableFiles)
            {
                objFile.SaveText();
            }
        }
    }
}
