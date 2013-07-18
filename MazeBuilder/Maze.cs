using System.Collections.Generic;

namespace MazeBuilder
{
   public class Maze
   {
      public Maze(IList<Wall> walls, int height, int width)
      {
         Walls = walls;
         Height = height;
         Width = width;
      }

      public int Width { get; private set; }
      public int Height { get; private set; }
      public IList<Wall> Walls { get; private set; }
   }
}
