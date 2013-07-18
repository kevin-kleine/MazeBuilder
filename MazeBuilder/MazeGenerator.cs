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
         IList<Wall> walls = ConstructWalls(sets, width, height);

         RandomlyDestroyWalls(walls, sets);

         return new Maze(walls, height, width);
      }

      private static void RandomlyDestroyWalls(IList<Wall> walls, IList<Set<int>> sets)
      {
         var indexOrder = GenerateListOfSequentialNumbers(walls.Count);
         ShuffleList(indexOrder);

         foreach (int index in indexOrder)
            RemoveIfNeeded(walls[index]);
      }

      private static void RemoveIfNeeded(Wall wall)
      {
         if (wall.SeparatesDisjointCellSets)
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

      private static IList<Wall> ConstructWalls(IList<Set<int>> sets, int width, int height)
      {
         var walls = new List<Wall>();

         for (int i = 0; i < sets.Count; i++)
            AddRightAndBottomWallAsNeeded(walls, sets, i, width, height);

         return walls;
      }

      private static void AddRightAndBottomWallAsNeeded(IList<Wall> walls, IList<Set<int>> sets, int setIndex, int width, int height)
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
