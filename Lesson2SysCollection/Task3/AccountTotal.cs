using System;
using System.Collections.Generic;
using System.Collections;

namespace Task3
{
    class AccountTotal : ICollection, IEnumerable
    {
        public AccountTotal()
        {

        }

        int count = 0;
        KeyValuePair<int, decimal>[] accounts = new KeyValuePair<int, decimal>[0];

        #region ICollection
        public int Count { get { return count; } }
        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return null; } }
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
        #endregion

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return accounts[i];
            }
        }

        public void Add (int account, decimal total)
        {
            bool add = true;
            for (int i = 0; i < Count; i++)
            {
                if (account == accounts[i].Key)
                {
                    accounts[i] = new KeyValuePair<int, decimal>(account, total);
                    add = false;
                }
            }
            if (add)
            {
                Array.Resize(ref accounts, Count + 1);
                accounts[Count] = new KeyValuePair<int, decimal>(account, total);
                count++;
            }
        }
    }
}
