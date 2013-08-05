using System.Drawing;
using System.Windows.Forms;

namespace MazeBuilder
{
   public sealed class ImageBox : Panel
   {
      private Image image;

      public ImageBox()
      {
         AutoScroll = true;
         DoubleBuffered = true;
      }
   }
}
