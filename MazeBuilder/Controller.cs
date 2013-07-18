using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilder
{
   public class Controller
   {
      public void GenerateMaze(int width, int height)
      {
         int totalCells = width*height;
         List<Set<int>> sets = ConstructSets(totalCells);
         List<Wall> walls = ConstructWalls(sets, width, height);

         RandomlyDestroyWalls(walls, sets);
      }

      private void RandomlyDestroyWalls(List<Wall> walls, List<Set<int>> sets)
      {
         
      }

      private static List<Set<int>> ConstructSets(int totalCells)
      {
         var sets = new List<Set<int>>(totalCells);

         for (int i = 0; i < totalCells; i++)
            sets.Add(new Set<int>(i));

         return sets;
      } 

      private static List<Wall> ConstructWalls(List<Set<int>> sets, int width, int height)
      {
         var walls = new List<Wall>();

         for (int i = 0; i < sets.Count; i++)
            AddRightAndBottomWallAsNeeded(walls, sets, i, width, height);

         return walls;
      }

      private static void AddRightAndBottomWallAsNeeded(List<Wall> walls, List<Set<int>> sets, int setIndex, int width, int height)
      {
         if (NeedsRightWall(setIndex, width, height))
            walls.Add(new Wall(sets[setIndex], sets[setIndex + 1]));

         if (NeedsBottomWall(setIndex, width, height))
            walls.Add(new Wall(sets[setIndex], sets[setIndex + width]));
      }
      
      private static bool NeedsRightWall(int index, int width, int height)
      {
         return (index + 1)%width != 0;
      }

      private static bool NeedsBottomWall(int index, int width, int height)
      {
         return index < (width*(height-1));
      }
   }
}
