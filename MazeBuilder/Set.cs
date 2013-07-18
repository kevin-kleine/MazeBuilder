using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MazeBuilder
{
   public class Set<T> : IEnumerable<T>
   {
      private List<T> items;

      public Set()
         : this(new T[] { })
      {
      }

      public Set(T primingItem)
         : this(new[] { primingItem }) 
      {

      }

      public Set(IEnumerable<T> primingItems)
      {
         items = new List<T>();
         items.AddRange(primingItems);
      }

      public bool AreDisjoint(Set<T> setToCompare)
      {
         return !setToCompare.items.Intersect(items).Any();
      }

      public void Merge(Set<T> setToMerge)
      {
         items = setToMerge.items.Union(items).ToList();
      }

      public IEnumerator<T> GetEnumerator()
      {
         return items.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
