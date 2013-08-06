using System.Drawing;
using System.Windows.Forms;

namespace MazeBuilder
{
   public partial class MainWindow : Form
   {
      private Maze maze;

      public MainWindow()
      {
         InitializeComponent();
      }

      private void drawButton_Click(object sender, System.EventArgs e)
      {
         maze = MazeGenerator.Generate((int) mazeWidthNumeric.Value, (int) mazeHeightNumeric.Value);
         var mazeForm = new MazeForm(maze, (int)cellSizeNumeric.Value);
         mazeForm.Show();
      }

      private void analyzeButton_Click(object sender, System.EventArgs e)
      {
         MazeGenerationAnalyzer.AnalyzeMazeGeneration((int) startSizeNumeric.Value, (int) endSizeNumeric.Value,
            (int) incrementByNumeric.Value);
         MessageBox.Show("Finished!");
      }

      private void MainWindow_Load(object sender, System.EventArgs e)
      {

      }
   }
}
