namespace MazeBuilder
{
   public class Wall
   {
      public int CellIndex1;
      public int CellIndex2;
      public bool IsUp { get; private set; }
      
      public Wall(int cell1, int cell2)
      {
         CellIndex1 = cell1;
         CellIndex2 = cell2;
         IsUp = true;
      }
      
      public Wall()
      {
         IsUp = false;
      }
      
      public void KnockDown()
      {
         IsUp = false;
      }
   }
}
