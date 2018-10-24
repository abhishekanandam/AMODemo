using System;
using System.Collections;

namespace S.O.L.I.D.Tests
{
    public class CustomData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] { 1, 2, 3 };
        }
    }
}