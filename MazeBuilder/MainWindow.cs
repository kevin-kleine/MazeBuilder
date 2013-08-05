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
         Controls.Clear();
         var maze = MazeGenerator.Generate(200, 200);

         var imageBox = new ImageBox
         {
            Width = 10 * 200,
            Height = 10 * 200
         };
         Controls.Add(imageBox);
         
         var graphics = imageBox.CreateGraphics();
         graphics.Clear(Color.SlateGray);
         var mazeDrawer = new MazeDrawer(graphics, maze, Height, Width);

         mazeDrawer.DrawMaze();
      }

      private void analyzeButton_Click(object sender, System.EventArgs e)
      {
         MazeGenerationAnalyzer.AnalyzeMazeGeneration(10000, 1000000, 10000);
         MessageBox.Show("Finished!");
      }
   }
}
