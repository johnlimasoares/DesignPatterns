using System;
using System.Collections;
using System.Collections.Generic;

namespace Proxy
{
    public class ListUnmodified : IList
    {
        private System.Collections.Generic.IList<object> list;

        public ListUnmodified(IList<object> list)
        {
            this.list = list;
        }


        public object this[int index] { get { return this[index]; } set { throw new Exception("Não é possível executar esta operação em uma lista não modificável"); } }

        public bool IsReadOnly { get; set; }

        public bool IsFixedSize { get; set; }

        public int Count { get { return list.Count; } }

        public object SyncRoot { get; set; }

        public bool IsSynchronized { get; set; }

        public int Add(object value)
        {
            throw new Exception("Não é possível executar esta operação em uma lista não modificável");
        }

        public void Clear()
        {
            throw new Exception("Não é possível executar esta operação em uma lista não modificável");
        }

        public bool Contains(object value)
        {
            return this.list.Contains(value);
        }

        public void CopyTo(Array array, int index)
        {
            throw new Exception("Não é possível executar esta operação em uma lista não modificável");
        }

        public IEnumerator GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            return this.list.IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            throw new Exception("Não é possível executar esta operação em uma lista não modificável");
        }

        public void Remove(object value)
        {
            throw new Exception("Não é possível executar esta operação em uma lista não modificável");
        }

        public void RemoveAt(int index)
        {
            throw new Exception("Não é possível executar esta operação em uma lista não modificável");
        }
    }
}
