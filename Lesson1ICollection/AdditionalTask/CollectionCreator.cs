using System;
using System.Collections.Generic;

namespace AdditionalTask
{
    class CollectionCreator
    {
        public IEnumerable<int> CreateCollection(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 !=0)
                {
                    int element = (int)Math.Pow(array[i], 2);
                    yield return element;
                }
            }

        }
    }
}
