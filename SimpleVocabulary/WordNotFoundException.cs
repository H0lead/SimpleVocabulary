using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVocabulary
{
    internal class WordNotFoundException : Exception
    {
        public WordNotFoundException(string message) : base(message) { }
    }
}
