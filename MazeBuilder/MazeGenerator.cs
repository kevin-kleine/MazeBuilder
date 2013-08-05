using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MazeBuilder
{
   public static class MazeGenerator
   {
      public static Maze Generate(int height, int width)
      {
         int totalCells = width*height;
         var cells = new DisjointSet(totalCells);
         IList<Corner> corners = ConstructWalls(width, height);

         IList<Wall> walls = new List<Wall>();
         foreach (var corner in corners)
         {
            walls.Add(corner.Bottom);
            walls.Add(corner.Right);
         }

         RandomlyDestroyWalls(walls, cells);

         int parent = cells.Find(1);
         MessageBox.Show("Generation completed. Parent node is " + parent + " with a depth of " + cells[parent]);

         return new Maze(corners, height, width);
      }

      private static void RandomlyDestroyWalls(IList<Wall> walls, DisjointSet cells)
      {
         ShuffleList(walls);

         foreach (var wall in walls)
            RemoveIfNeeded(wall, cells);
      }

      private static void RemoveIfNeeded(Wall wall, DisjointSet cells)
      {
         if (!wall.IsUp)
            return;

         int cell1Parent = cells.Find(wall.CellIndex1);
         int cell2Parent = cells.Find(wall.CellIndex2);

         if (cell1Parent != cell2Parent)
         {
            wall.KnockDown();
            cells.Union(cell1Parent, cell2Parent);
         }
      }

      private static void ShuffleList<T>(IList<T> list)
      {
         var random = new Random();
         var count = list.Count;

         for (var i = 0; i < count; i++)
         {
            var swapIndex = random.Next(0, count);
            var temp = list[i];
            list[i] = list[swapIndex];
            list[swapIndex] = temp;
         }
      }

      private static IList<Corner> ConstructWalls(int width, int height)
      {
         var corners = new List<Corner>();
         var numberOfCorners = width*height;

         for (var i = 0; i < numberOfCorners; i++)
            AddRightAndBottomWallAsNeeded(corners, i, width, height);

         return corners;
      }

      private static void AddRightAndBottomWallAsNeeded(IList<Corner> corners, int setIndex, int width, int height)
      {
         var corner = new Corner();

         if (NeedsRightWall(setIndex, width))
            corner.Right = new Wall(setIndex, setIndex + 1);
         else
            corner.Right = new Wall();
         
         if (NeedsBottomWall(setIndex, width, height))
            corner.Bottom = new Wall(setIndex, setIndex + width);
         else
            corner.Bottom = new Wall();

         corners.Add(corner);
      }
      
      private static bool NeedsRightWall(int index, int width)
      {
         return (index + 1)%width != 0;
      }

      private static bool NeedsBottomWall(int index, int width, int height)
      {
         return index < (width*(height-1));
      }
   }
}
