using System;
using System.Collections;

namespace AdditionalTask
{
    class ReverseSort : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare (object a, object b)
        {
            int result = comparer.Compare(b, a);
            return result;
        }
    }
}
