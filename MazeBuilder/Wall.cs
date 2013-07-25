using System;

namespace MazeBuilder
{
   public class Wall
   {
      public  Set<int> cell1;
      public  Set<int> cell2;
      
      public Wall(Set<int> cell1, Set<int> cell2)
      {
         this.cell1 = cell1;
         this.cell2 = cell2;
         IsUp = true;
      }

      public Wall()
      {
         IsUp = false;
      }

      
      public bool IsUp { get; private set; }
      
      public bool SeparatesDisjointCellSets
      {
         get { return cell1.AreDisjoint(cell2); }
      }
      
      public void MergeCells()
      {
         Console.WriteLine("cell1 contains: ");
         WriteContentsOfCell(cell1);

         Console.WriteLine("cell2 contains: ");
         WriteContentsOfCell(cell2);

         cell1.Merge(cell2);
         cell2.Merge(cell1);


         Console.WriteLine("cell1 now contains after merge: ");
         WriteContentsOfCell(cell1);

         Console.WriteLine("cell2 now contains after merge: ");
         WriteContentsOfCell(cell2);


         Console.WriteLine("____________________________________________________________");
      }

      public void KnockDown()
      {
         IsUp = false;
      }

      private static void WriteContentsOfCell(Set<int> cell)
      {
         string contents = String.Join(", ", cell);
         Console.WriteLine(contents);
      }

   }
}
