using System.Drawing;
using System.Windows.Forms;

namespace MazeBuilder
{
   public partial class MainWindow : Form
   {
      private ImageBox imageBox;
      private Maze maze;

      public MainWindow()
      {
         InitializeComponent();
      }

      private void drawButton_Click(object sender, System.EventArgs e)
      {
         Controls.Clear();
         maze = MazeGenerator.Generate(1000, 1000);

         imageBox = new ImageBox
         {
            Width = 10 * 1000,
            Height = 10 * 1000
         };
         Controls.Add(imageBox);

         imageBox.Paint += OnPaint;
      }

      private void OnPaint(object sender, PaintEventArgs e)
      {
         Graphics g = e.Graphics;

         g.Clear(Color.SlateGray);
         var mazeDrawer = new MazeDrawer(g, maze, Height, Width);
         mazeDrawer.DrawMaze();
      }

      private void analyzeButton_Click(object sender, System.EventArgs e)
      {
         MazeGenerationAnalyzer.AnalyzeMazeGeneration(10000, 1000000, 10000);
         MessageBox.Show("Finished!");
      }

      private void MainWindow_Load(object sender, System.EventArgs e)
      {

      }
   }
}
