using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace effective_c_sharp
{
    public class EmbeddedIterator : IEnumerable<char>
    {
        public IEnumerator<char> GetEnumerator() => new LetterEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => new LetterEnumerator();
        public static IEnumerable<char> GenerateAlphabet() => new EmbeddedIterator();

        private class LetterEnumerator : IEnumerator<char>
        {
            private char letter = (char)('a' - 1);

            public bool MoveNext()
            {
                letter++;
                return letter <= 'z';
            }

            public char Current => letter;

            object IEnumerator.Current => letter;

            public void Reset() => letter = (char)('a' - 1);

            void IDisposable.Dispose() { }
        }
    }
}
