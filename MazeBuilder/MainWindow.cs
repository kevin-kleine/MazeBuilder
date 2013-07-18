using System.Drawing;
using System.Windows.Forms;

namespace MazeBuilder
{
   public partial class MainWindow : Form
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private void drawButton_Click(object sender, System.EventArgs e)
      {
         var maze = MazeGenerator.Generate(50, 50);
         var graphics = CreateGraphics();
         graphics.Clear(Color.SlateGray);
         var mazeDrawer = new MazeDrawer(graphics, maze, Height, Width);
         mazeDrawer.DrawMaze();
      }
   }
}
