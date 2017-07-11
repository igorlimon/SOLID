﻿namespace SOLID.L.Solution
{
    public class SqlFile : IWritableSqlFile, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from sql file */
            return string.Empty;
        }
        public void SaveText()
        {
            /* Code to save text into sql file */
        }
    }
}
