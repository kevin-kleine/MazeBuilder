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

         cellWidth = windowHeight < windowWidth ? windowHeight/maze.Height : windowWidth/maze.Width;//Fix
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
         var wall = maze.Walls[index];
         
         if (wall.IsUp)
            DrawWall(index);
         else
            SkipWall(index);
      }

      private void DrawWall(int index)
      {
         if (IsVerticalWall(index))
            DrawVerticalWall();
         else
            DrawHorizontalWall();

         IncreaseYPositionIfNeeded(index);
      }

      private bool IsVerticalWall(int index)
      {
         return index%2 == 0;
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
         
         currentPoint.X += cellWidth;
      }

      private void IncreaseYPositionIfNeeded(int index)
      {
         if (WallIsAtRowEnd(index))
            GoToNextRow();
      }

      private bool WallIsAtRowEnd(int index)
      {
         return index%((maze.Width*2) - 1) == 0;
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
   }
}
