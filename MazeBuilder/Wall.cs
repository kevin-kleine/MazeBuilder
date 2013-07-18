namespace MazeBuilder
{
   public class Wall
   {
      private readonly Set<int> cell1;
      private readonly Set<int> cell2;
      
      public Wall(Set<int> cell1, Set<int> cell2)
      {
         this.cell1 = cell1;
         this.cell2 = cell2;
         IsUp = true;
      }

      
      public bool IsUp { get; private set; }
      
      public bool SeparatesDisjointCellSets
      {
         get { return cell1.AreDisjoint(cell2); }
      }
      
      public void MergeCells()
      {
         cell1.Merge(cell2);
         cell2.Merge(cell1);
      }

      public void KnockDown()
      {
         IsUp = false;
      }
      
   }
}
