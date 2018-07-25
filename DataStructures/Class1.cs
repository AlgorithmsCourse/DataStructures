using System;
using System.Collections;

namespace DataStructures
{

    //TODO: check what is exposed for the public class node -- revisit proper access modifiers
    public class Bag : IEnumerable
    {
        public Node First { get; set; }
        public class Node
        {
            public Object Cargo { get; set; }
            public Node Next { get; set; }
        }
        public void Add(Object item)
        {
            var newItem = new Node();
            newItem.Cargo = item;
            var temp = First;
            First = newItem;
            newItem.Next = temp;
            Size += 1;
              
        }
        
        public IEnumerator GetEnumerator()
        {
            return new BagEnumerator(First);
        }

        public class BagEnumerator : IEnumerator
        {
            public Node Current { get; set; }

            object IEnumerator.Current => Current;

            public BagEnumerator(Node entryPt)
            {
                Current = entryPt;
            }
            
         

            public bool MoveNext()
            {
                Current = Current.Next;
                return Current.Next != null;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
        public bool IsEmpty { get {
                return (Size == 0); }}

        public int Size { get; set; }
    }
}
