using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TNotes
{
    enum FileType
    {
        TXT,
        RTF,
        UNK
    }

    class NoteParser
    {
        public Exception UnknownFileTypeException { get; private set; }

        public NoteParser()
        {

        }
        public List<string> parseFile(string filename)
        {
            StreamReader input = new StreamReader(filename);             
            string[] s = filename.Split('.');
            FileType t;
            if (s[1].Equals("txt"))
            {
                t = FileType.TXT;
            }
            else if (s[1].Equals("rtf"))
            {
                throw UnknownFileTypeException;
                //t = FileType.RTF; TODO: IMPLEMENT RTF VARIANT
            }
            else
            {
                throw UnknownFileTypeException;
            }
            return parseFileType(input, t);
        }
        public List<string> parseFileType(StreamReader input, FileType t)
        {
            switch (t)
            {
                case FileType.TXT : return parseTXTFile(input);
                case FileType.RTF : return parseRTFFile(input);
                default: return new List<string>();
            }
        }
        private List<string> parseTXTFile(StreamReader input)
        {
            List<string> tokens = new List<string>();
            string line;
            char[] delims = { ' ', '\t', '\r', ',', '.', '!', '?', '`', '~' , '|'
                            , '(', ')' , '{' , '}', '[', ']', '<', '>', '/' , '\\'
                            , '@', '$' , '%' , '^', '&', '*', '-', '_', '+' , '='
                            , '1', '2' , '3' , '4', '5', '6', '7', '8', '9' , '0'
                            , ':', ';' , '\'', '\"'
                            };
            while((line = input.ReadLine()) != null)
            {
                string[] s = line.Split(delims);
                for(int i = 0; i < s.Length; i++)
                {
                    tokens.Add(s[i].Trim());
                }
            }
            return removeGarbage(tokens);
        }
        private List<string> parseRTFFile(StreamReader input)
        {
            List<string> tokens = new List<string>();
            //Ultimately, this is going to generate a list of tokens and spit out only candidate keywords.
            return removeGarbage(tokens); // TODO: IMPLEMENT THIS FUNCTION
        }
        private List<string> removeGarbage(List<string> tokens)
        {
            tokens = removeEmpty(tokens);
            string[] aa   = {"a","an","the"};
            string[] prep = { "of", "with", "at", "from", "into", "during"
                            , "including", "until", "against", "among", "throughout"
                            , "despite", "towards", "upon", "concerning", "to", "in"
                            , "for", "on", "by", "about", "like", "through", "over"
                            , "before", "between", "after", "since", "without", "under"
                            , "within", "along", "following", "across", "behind", "beyond"
                            , "plus", "except", "but", "up", "out", "around", "down"
                            , "off", "above", "near" };
            string[] cv   = { "am", "is", "are", "was", "were", "be", "being", "been" };
            string[] pn   = { "it", "i", "you", "he", "they", "we", "she", "who", "them"
                            , "me", "him", "one", "her", "us" };

            for(int i = tokens.Count; i > -1; i--)
            {
                string s = tokens.ElementAt(i).ToLower();
                if ( aa.Contains(s)
                  || prep.Contains(s)
                  || cv.Contains(s)
                  || pn.Contains(s)
                  )
                {
                    tokens.RemoveAt(i);
                }
            }
            return tokens;
        }
        private List<string> removeEmpty(List<string> tokens)
        {
            for(int i = tokens.Count; i > -1; i--)
            {
                string s = tokens.ElementAt(i);
                if ( s.Equals("")
                  || s.Equals(null))
                {
                    tokens.RemoveAt(i);
                }
            }
            return tokens;
        }
    }
}
