using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Should;

namespace MazeBuilder.UnitTests
{
   
   public class SetTests
   {
      [TestCase]
      public void SetsShouldBeDisjoint()
      {
         var firstSet = new Set<int>(new List<int> {1, 2, 3});
         var secondSet = new Set<int>(new List<int> {4, 5, 6});
         firstSet.AreDisjoint(secondSet).ShouldBeTrue();
      }

      [TestCase]
      public void SetsShouldNotBeDisjoint()
      {
         var firstSet = new Set<int>(new List<int> {1, 2, 3});
         var secondSet = new Set<int>(new List<int> {3, 5, 6});
         firstSet.AreDisjoint(secondSet).ShouldBeFalse();
      }
      
      [TestCase]
      public void SetsShouldMergeCorrectly()
      {
         var firstSet = new Set<int>(new List<int> {1, 2, 3});
         var secondSet = new Set<int>(new List<int> {2, 3, 4, 5, 6});
         var mergedSet = new Set<int>(new List<int> {1, 2, 3, 4, 5, 6});
         firstSet.Merge(secondSet);
         firstSet.Count().ShouldEqual(mergedSet.Count());
         foreach (var val in mergedSet)
         {
            firstSet.ShouldContain(val);
         }
      }

      [TestCase]
      public void DoubleSetMerge()
      {
         var firstSet = new Set<int>(new List<int> { 1, 2, 3 });
         var secondSet = new Set<int>(new List<int> { 4, 5, 6 });

         var mergedSet = new Set<int>(new List<int> {1, 2, 3, 4, 5, 6});

         firstSet.Merge(secondSet);
         secondSet.Merge(firstSet);

         firstSet.Count().ShouldEqual(mergedSet.Count());
         firstSet.Count().ShouldEqual(secondSet.Count());

         foreach (var set in mergedSet)
         {
            firstSet.ShouldContain(set);
            secondSet.ShouldContain(set);
         }
      }
   }
}
