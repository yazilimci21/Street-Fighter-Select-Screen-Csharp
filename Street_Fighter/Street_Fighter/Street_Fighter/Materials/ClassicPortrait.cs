using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Street_Fighter.Materials
{
    public class ClassicPortrait : Core.Material
    {
        string imagepath = Application.StartupPath + "\\Images\\char_select\\";
        List<Image> portraits = new List<Image>();
        public int selectedIndex = 0;

        public ClassicPortrait()
        {
            Bitmap port = (Bitmap)Image.FromFile(imagepath + "portraits.png");
            Core.Sprite.SpriteReader portReader = new Core.Sprite.SpriteReader();
            portReader.GetTransparentColor(port, 1, 1);
            portReader.spriteWidth = 64;
            portReader.spriteHeight = 104;
            portReader.ReadImage(port, 8, 2, 0, 0);
            for (int y = 0; y < portReader.Images.Count; y++)
            {
                for (int x = 0; x < portReader.Images[y].Count; x++)
                {
                    portraits.Add((Image)portReader.Images[y][x].Clone());
                }
            }
            portReader.Dispose();

            this.Properties.CollisionRect = new RectangleF(0, 0, 200, 300);
        }

        private int getPortrait(int index)
        {
            if (index == 0 || index == 5) return 0;
            if (index > 5 && index <= 11)
            {
                if (index == 6) index = 13;
                else if (index == 11) index = 15;
                else
                {
                    index -= 2;
                }
                index -= 1;
                return index;
            }
            if (index >= 12)
            {
                if (index == 12) index = 14;
                else if (index == 17) index = 16;
                else
                {
                    index -= 4;
                }
                index -= 1;
                return index;
            }
            index -= 1;
            return index;
        }

        public override void Draw(Graphics g, PointF CameraLocation)
        {
            g.DrawImage(portraits[getPortrait(selectedIndex)], this.Properties.CollisionRect);
        }
    }
}
