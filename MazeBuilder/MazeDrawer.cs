using System;
using System.Drawing;
using System.Linq;

namespace MazeBuilder
{
   public class MazeDrawer
   {
      private readonly Graphics graphics;
      private static readonly Pen Pen = Pens.LightYellow;
      private readonly Maze maze;
      private readonly int cellWidth;
      private Point currentPoint;
      private int count = 0;

      public MazeDrawer(Graphics graphics, Maze maze, int windowHeight, int windowWidth)
      {
         this.graphics = graphics;
         this.maze = maze;

         cellWidth = Math.Min(windowWidth, windowHeight)/Math.Max(maze.Width, maze.Height);
         currentPoint = new Point(cellWidth, cellWidth);
      }

      public void DrawMaze()
      {
         DrawMazeBorder();

         for (int i = 0; i < maze.Walls.Count; i++)
            DrawWallIfUp(i);
      }

      private void DrawMazeBorder()
      {
         int width = maze.Width*cellWidth;
         int height = maze.Height*cellWidth;
         graphics.DrawRectangle(Pen, 0, 0, width, height);
      }

      private void DrawWallIfUp(int index)
      {
         var corner = maze.Corners[index];

         if (corner.Right.IsUp)
            DrawWall(index);
         else
            SkipWall(index);
      }

      private void DrawWall(int index)
      {
         if (IsVerticalWall(index))
            DrawVerticalWall();
         else
            DrawHorizontalWall(index);    
      }

      private bool IsVerticalWall(int index)
      {
         return CurrentRowIsEven(index) ? index%2 == 0 : index%2 == 1;
      }

      private void DrawVerticalWall()
      {
         var endPoint = new Point(currentPoint.X, currentPoint.Y - cellWidth);
         graphics.DrawLine(Pen, currentPoint, endPoint);
      }

      private void DrawHorizontalWall(int index)
      {
         var endPoint = new Point(currentPoint.X - cellWidth, currentPoint.Y);
         graphics.DrawLine(Pen, currentPoint, endPoint);

         if (WallIsAtRowEnd(index))
            GoToNextRow();
         else
            currentPoint.X += cellWidth;
      }

      private void GoToNextRow()
      {
         currentPoint.Y += cellWidth;
         currentPoint.X = cellWidth;
      }

      private void SkipWall(int index)
      {
         if (IsVerticalWall(index))
            return;
         
         if (WallIsAtRowEnd(index))
         {
            GoToNextRow();
            return;
         }

         currentPoint.X += cellWidth;
      }

      private bool WallIsAtRowEnd(int index)
      {
         return (count++%maze.Width) == 0; //index%((maze.Width*2) - 2) == 0;
      }

      private bool CurrentRowIsEven(int index)
      {
         return index/((maze.Width*2) - 2) % 2 == 0;
      }
   }
}
