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

      public Image Image
      {
         get { return image; }
         set
         {
            image = value;
            
            if (image != null) 
               AutoScrollMinSize = image.Size;
            else AutoScrollMinSize = new Size(0, 0);
            
            Invalidate();
         }
      }

      protected override void OnPaint(PaintEventArgs e)
      {
         //e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

         //if (image == null)
         //   return;

         //e.Graphics.DrawImage(image, 0, 0);

         //base.OnPaint(e);
      }
   }
}
