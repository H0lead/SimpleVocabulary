using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVocabulary
{
    internal class WordNotFoundException : Exception
    {
        // Звичайни кастомний exception.
        public WordNotFoundException(string message) : base(message) { }
    }
}
