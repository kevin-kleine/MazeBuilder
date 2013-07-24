using System;
using System.Collections.Generic;

namespace MazeBuilder
{
   public static class MazeGenerator
   {
      public static Maze Generate(int height, int width)
      {
         int totalCells = width*height;
         IList<Set<int>> sets = ConstructSets(totalCells);
         IList<Corner> corners = ConstructWalls(sets, width, height);

         IList<Wall> walls = new List<Wall>();
         foreach (var corner in corners)
         {
            walls.Add(corner.Bottom);
            walls.Add(corner.Right);
         }

         RandomlyDestroyWalls(walls);

         return new Maze(corners, height, width);
      }

      private static void RandomlyDestroyWalls(IList<Wall> walls)
      {
         var indexOrder = GenerateListOfSequentialNumbers(walls.Count);
         ShuffleList(indexOrder);

         foreach (int index in indexOrder)
            RemoveIfNeeded(walls[index]);
      }

      private static void RemoveIfNeeded(Wall wall)
      {
         if (wall.IsUp && wall.SeparatesDisjointCellSets)
         {
            wall.KnockDown();
            wall.MergeCells();
         }
      }

      private static IList<int> GenerateListOfSequentialNumbers(int count)
      {
         var numbers = new List<int>();

         for (int i = 0; i < count; i++)
            numbers.Add(i);

         return numbers;
      }

      private static void ShuffleList<T>(IList<T> list)
      {
         var random = new Random();
         int count = list.Count;

         for (int i = 0; i < count; i++)
         {
            int swapIndex = random.Next(0, count);
            T temp = list[i];
            list[i] = list[swapIndex];
            list[swapIndex] = temp;
         }
      }

      private static IList<Set<int>> ConstructSets(int totalCells)
      {
         var sets = new List<Set<int>>(totalCells);

         for (int i = 0; i < totalCells; i++)
            sets.Add(new Set<int>(i));

         return sets;
      } 

      private static IList<Corner> ConstructWalls(IList<Set<int>> sets, int width, int height)
      {
         var corners = new List<Corner>();

         for (int i = 0; i < sets.Count; i++)
            AddRightAndBottomWallAsNeeded(corners, sets, i, width, height);

         return corners;
      }

      private static void AddRightAndBottomWallAsNeeded(IList<Corner> corners, IList<Set<int>> sets, int setIndex, int width, int height)
      {
         var corner = new Corner();

         if (NeedsRightWall(setIndex, width))
            corner.Right = new Wall(sets[setIndex], sets[setIndex + 1]);
         else
            corner.Right = new Wall();
         
         if (NeedsBottomWall(setIndex, width, height))
            corner.Bottom = new Wall(sets[setIndex], sets[setIndex + width]);
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
