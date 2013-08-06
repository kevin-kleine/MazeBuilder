using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MazeBuilder
{
   public partial class MainWindow : Form
   {
      private Maze maze;
      private Bitmap mazeBitmap;
      private bool mazeHasBeenDrawn;

      public MainWindow()
      {
         InitializeComponent();
      }

      private void drawButton_Click(object sender, System.EventArgs e)
      {
         maze = MazeGenerator.Generate((int) mazeWidthNumeric.Value, (int) mazeHeightNumeric.Value);
         var mazeForm = new MazeForm(maze, (int)cellSizeNumeric.Value);
         mazeBitmap = mazeForm.ShowAndReturnBitmap();
         mazeHasBeenDrawn = true;
      }

      private void analyzeButton_Click(object sender, System.EventArgs e)
      {
         MazeGenerationAnalyzer.AnalyzeMazeGeneration((int) startSizeNumeric.Value, (int) endSizeNumeric.Value,
            (int) incrementByNumeric.Value);
         MessageBox.Show("Finished!");
      }

      private void printButton_Click(object sender, System.EventArgs e)
      {
         if (!mazeHasBeenDrawn)
         {
            MessageBox.Show("You must draw a maze before you can print!");
            return;
         }
         var printDoc = new PrintDocument();
         printDoc.PrintPage += OnPrintPage;

         var printDialog = new PrintDialog { Document = printDoc };
         var preview = new PrintPreviewDialog { Document = printDoc };
         preview.ShowDialog();

         if (printDialog.ShowDialog() == DialogResult.OK)
            printDoc.Print();
      }

      private void OnPrintPage(object sender, PrintPageEventArgs e)
      {
         e.Graphics.DrawImage(mazeBitmap, 0, 0);
      }

      private void MainWindow_Load(object sender, System.EventArgs e)
      {

      }
   }
}
