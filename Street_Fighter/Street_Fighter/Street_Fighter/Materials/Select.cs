using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Street_Fighter.Materials
{
    public class Select : Core.Material
    {
        string imagepath = Application.StartupPath + "\\Images\\char_select\\";
        List<Image> selects = new List<Image>();
        Image char_select, p1, p2;
        private int tempp1i = 0, tempp2i = 0;
        private RectangleF tempp1Rect = RectangleF.Empty, tempp2Rect = RectangleF.Empty;

        public int p1i = 0, p2i = 0;
        public bool p1selected = false, p2selected = false;
        public ClassicPortrait p1Portarait, p2Portarait;

        public Select()
        {
            Bitmap select = (Bitmap)Image.FromFile(imagepath + "select.png");
            Core.Sprite.SpriteReader selectReader = new Core.Sprite.SpriteReader();
            selectReader.GetTransparentColor(select, 1, 1);
            selectReader.spriteWidth = 24;
            selectReader.spriteHeight = 38;
            selectReader.ReadImage(select, 5, 2, 2, 0);
            for (int y = 0; y < selectReader.Images.Count; y++)
            {
                for (int x = 0; x < selectReader.Images[y].Count; x++)
                {
                    selects.Add((Image)selectReader.Images[y][x].Clone());
                }
            }
            selectReader.Dispose();
            char_select = Image.FromFile(imagepath + "char_select.png");
            p1 = Image.FromFile(imagepath + "p1.png");
            ((Bitmap)p1).MakeTransparent(((Bitmap)p1).GetPixel(1, 1));
            p2 = Image.FromFile(imagepath + "p2.png");
            ((Bitmap)p2).MakeTransparent(((Bitmap)p2).GetPixel(1, 1));

            this.Properties.CollisionRect = new RectangleF(0, 0, char_select.Width, char_select.Height);
        }

        public override void Update(float time, PointF CameraLocation)
        {
            int sx = (int)(this.Properties.GameScreen.ScreenSize.Width / 2) - 150;
            int sy = 154 + 68;

            if (p1i == 0)
            {
                tempp1i = 0;
                tempp1Rect = new RectangleF((this.Properties.GameScreen.ScreenSize.Width / 2) - 140, 154 + 80, 62, 80);
            }
            else
            {
                int tp1i = p1i;
                int p1ni = tp1i / 6;
                if (p1ni > 0)
                {
                    tp1i = p1i - (p1ni * 5) - p1ni;
                }
                float cx = sx + ((tp1i * 47) + (tp1i * 2));
                float cy = sy + ((p1ni * 69));
                float sint = ((p1selected) ? 3 : 0);


                tempp1i = (int)sint;
                tempp1Rect = new RectangleF(cx, cy, 62, 80);
            }
            if (p2i == 5)
            {
                tempp2i = 5;
                tempp2Rect = new RectangleF((this.Properties.GameScreen.ScreenSize.Width / 2) + 115, 154 + 80, 62, 80);
            }
            else
            {
                int tp2i = p2i;
                int p2ni = tp2i / 6;
                if (p2ni > 0)
                {
                    tp2i = p2i - (p2ni * 5) - p2ni;
                }
                float cx = sx + ((tp2i * 47) + (tp2i * 2));
                float cy = sy + ((p2ni * 69)) + 6;
                float sint = ((p2selected) ? 8 : 5);

                tempp2i = (int)sint;
                tempp2Rect = new RectangleF(cx, cy, 62, 80);
            }
            if (p1Portarait != null) p1Portarait.selectedIndex = p1i;
            if (p2Portarait != null) p2Portarait.selectedIndex = p2i;
        }

        public override void Draw(Graphics g, PointF CameraLocation)
        {
            g.DrawImage(char_select, (int)(g.VisibleClipBounds.Width / 2) - 150, 154 + 80, 300, 200);

            if (p1i == 0)
            {
                g.DrawImage(p1, tempp1Rect.X - 18, tempp1Rect.Y, tempp1Rect.Width, tempp1Rect.Height);
            }
            else
            {
                g.DrawImage(selects[tempp1i], tempp1Rect);
            }
            if (p2i == 5)
            {
                g.DrawImage(p2, tempp2Rect.X - 18, tempp2Rect.Y, tempp2Rect.Width, tempp2Rect.Height);
            }
            else
            {
                g.DrawImage(selects[tempp2i], tempp2Rect);
            }
        }
    }
}
