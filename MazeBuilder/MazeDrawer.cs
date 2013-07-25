using System;
using System.Drawing;

namespace MazeBuilder
{
   public class MazeDrawer
   {
      private readonly Graphics graphics;
      private static readonly Pen Pen = Pens.LightYellow;
      private readonly Maze maze;
      private readonly int cellWidth;
      private Point currentPoint;

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

         for (int i = 0; i < maze.Corners.Count; i++)
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
            DrawVerticalWall();
         
         if (corner.Bottom.IsUp)
            DrawHorizontalWall();

         MoveToNextCell(index);
      }

      private void MoveToNextCell(int index)
      {
         if (IsLastCellInRow(index))
            GoToNextRow();
         else
            currentPoint.X += cellWidth;
      }

      private void DrawVerticalWall()
      {
         var endPoint = new Point(currentPoint.X, currentPoint.Y - cellWidth);
         graphics.DrawLine(Pen, currentPoint, endPoint);
      }

      private void DrawHorizontalWall()
      {
         var endPoint = new Point(currentPoint.X - cellWidth, currentPoint.Y);
         graphics.DrawLine(Pen, currentPoint, endPoint);
      }

      private void GoToNextRow()
      {
         currentPoint.Y += cellWidth;
         currentPoint.X = cellWidth;
      }

      private bool IsLastCellInRow(int index)
      {
         return (index + 1)%maze.Width == 0;
      }
   }
}
