using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNotes
{
    class Note
    {
        List<string> parsedFile;
        List<string> keywords;
        byte[] blob;
        List<string> noteInfo;
        System.IO.BinaryReader reader;
        
        
        public Note(string year, string semester, string professor, string course)
        {
            noteInfo.Add(year);
            noteInfo.Add(semester);
            noteInfo.Add(professor);
            noteInfo.Add(course);
        }

    }
}
