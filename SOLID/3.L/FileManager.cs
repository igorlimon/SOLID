using System.Collections.Generic;
using System.Text;

namespace SOLID.L
{
    public class FileManager
    {
        public List<File> lstFiles;

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in lstFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }

        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstFiles)
            {
                //Check whether the current file object is read only or not.If yes, skip calling it's  
                // SaveText() method to skip the exception.  

                if (!(objFile is ReadOnlyFile))
                    objFile.SaveText();
            }
        }
    }

}

