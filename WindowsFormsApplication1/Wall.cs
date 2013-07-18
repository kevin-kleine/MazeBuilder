namespace MazeBuilder
{
   public class Wall
   {
      public Set<int> Cell1 { get; private set; }
      public Set<int> Cell2 { get; private set; }

      public Wall(Set<int> cell1, Set<int> cell2)
      {
         Cell1 = cell1;
         Cell2 = cell2;
      }
   }
}
