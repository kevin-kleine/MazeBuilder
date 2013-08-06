using System.Drawing;
using System.Windows.Forms;

namespace MazeBuilder
{
   public partial class MazeForm : Form
   {
      private readonly Maze maze;
      private readonly Bitmap mazeBitmap;
      private readonly int cellSize;

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
         imageBox.Paint += OnPaint;
         Controls.Add(imageBox);

         mazeBitmap = new Bitmap(imageBox.Width, imageBox.Height);
         imageBox.DrawToBitmap(mazeBitmap, new Rectangle(0, 0, imageBox.Width, imageBox.Height));

      }

      public Bitmap ShowAndReturnBitmap()
      {
         Show();
         return mazeBitmap;
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
