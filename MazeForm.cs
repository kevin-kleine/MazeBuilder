using System.Drawing;
using System.Windows.Forms;

namespace MazeBuilder
{
   public partial class MazeForm : Form
   {
      private Maze maze;
      private int cellSize;

      public MazeForm(Maze maze, int cellSize)
      {
         InitializeComponent();

         this.maze = maze;
         this.cellSize = cellSize;
         
         Controls.Clear();

         var imageBox = new ImageBox
         {
            Width = cellSize * maze.Width,
            Height = cellSize * maze.Height
         };
         Controls.Add(imageBox);

         imageBox.Paint += OnPaint;
      }

      private void OnPaint(object sender, PaintEventArgs e)
      {
         Graphics g = e.Graphics;

         g.Clear(Color.SlateGray);
         var mazeDrawer = new MazeDrawer(g, maze, cellSize);
         mazeDrawer.DrawMaze();
      }
   }
}
