using System;
using System.IO;

namespace MazeBuilder
{
   public static class MazeGenerationAnalyzer
   {
      public static void AnalyzeMazeGeneration(int mazeStartSize, int mazeEndSize, int mazeSizeDensity)
      {
         using (var writer = new StreamWriter(@"..\..\GenerationTimes.txt"))
         {
            for (int currentMazeSize = mazeStartSize;
               currentMazeSize <= mazeEndSize;
               currentMazeSize += mazeSizeDensity)
            {
               var demension = (int) Math.Sqrt(currentMazeSize);

               var start = DateTime.Now;
               MazeGenerator.Generate(demension, demension);
               var end = DateTime.Now;
               writer.WriteLine("{0}, {1}", currentMazeSize, (end - start).Seconds.ToString() + ((end-start).Milliseconds / 1000.0).ToString(".###"));
            }
         }
      } 
   }
}
