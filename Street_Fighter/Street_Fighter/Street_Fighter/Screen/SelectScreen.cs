using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Street_Fighter.Screen
{
    public class SelectScreen : Core.Screen
    {
        string imagepath = Application.StartupPath + "\\Images\\char_select\\";
        public Materials.Select select = new Materials.Select();
        float vx = 10.0f, vy = 10.0f;
        PointF nullCameraLocation = PointF.Empty;
        Core.BackGround backGround;

        public SelectScreen(SizeF GameSize, float time, Core.MainScreen MainScreen)
            : base(GameSize, time, MainScreen)
        {
            backGround = new Core.BackGround(Image.FromFile(imagepath + "background.png"), new Size(132, 64), PointF.Empty, false);
            select.Properties.GameScreen = this;
            
            select.p1Portarait = new Materials.ClassicPortrait();
            select.p1Portarait.Properties.GameScreen = this;

            select.p2Portarait = new Materials.ClassicPortrait();
            select.p2Portarait.Properties.CollisionRect.X = GameSize.Width - 200;
            select.p2Portarait.Properties.GameScreen = this;
            
            Materials.Logo logo = new Materials.Logo();
            logo.Properties.GameScreen = this;

            select.p1i = 0;
            select.p2i = 5;
            this.Materials.Add(logo);
            this.Materials.Add(select.p1Portarait);
            this.Materials.Add(select.p2Portarait);
            this.Materials.Add(select);
        }

        public override void Draw(Graphics g)
        {
            backGround.Draw(g, nullCameraLocation, g.VisibleClipBounds.Size);
            base.Draw(g);
            nullCameraLocation.X += vx;
            nullCameraLocation.Y += vy;
            if (nullCameraLocation.X < -2000.0f || nullCameraLocation.X > 2000f) vx = -vx;
            if (nullCameraLocation.Y < -500.0f || nullCameraLocation.Y > 500f) vy = -vy;
        }

        public override void KeyDown(KeyEventArgs e)
        {
            //Player1
            if (!select.p1selected)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (select.p1i <= 1) select.p1i = 17;
                    else select.p1i--;
                    if (select.p1i == 5) select.p1i = 4;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (select.p1i >= 17) select.p1i = 1;
                    else select.p1i++;
                    if (select.p1i == 5) select.p1i = 6;
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (select.p1i < 5)
                        select.p1i = select.p1i + 12;
                    else
                    {
                        select.p1i = select.p1i - 6;
                        if (select.p1i == 5 || select.p1i == 0) select.p1i = select.p1i + 12;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (select.p1i > 11)
                    {
                        select.p1i = select.p1i - 12;
                        if (select.p1i == 5 || select.p1i == 0) select.p1i = select.p1i + 6;
                    }
                    else
                    {
                        select.p1i = select.p1i + 6;
                    }
                }
                if (e.KeyCode == Keys.A)
                {
                    if (select.p1i > 0) select.p1selected = true;
                }
            }
            //Player2
            if (!select.p2selected)
            {
                if (e.KeyCode == Keys.NumPad4)
                {
                    if (select.p2i <= 1) select.p2i = 17;
                    else select.p2i--;
                    if (select.p2i == 5) select.p2i = 4;
                }
                if (e.KeyCode == Keys.NumPad6)
                {
                    if (select.p2i >= 17) select.p2i = 1;
                    else select.p2i++;
                    if (select.p2i == 5) select.p2i = 6;
                }
                if (e.KeyCode == Keys.NumPad8)
                {
                    if (select.p2i < 5)
                        select.p2i = select.p2i + 12;
                    else
                    {
                        select.p2i = select.p2i - 6;
                        if (select.p2i == 5 || select.p2i == 0) select.p2i = select.p2i + 12;
                    }
                }
                if (e.KeyCode == Keys.NumPad2)
                {
                    if (select.p2i > 11)
                    {
                        select.p2i = select.p2i - 12;
                        if (select.p2i == 5 || select.p2i == 0) select.p2i = select.p2i + 6;
                    }
                    else
                    {
                        select.p2i = select.p2i + 6;
                    }
                }
                if (e.KeyCode == Keys.L)
                {
                    if (select.p2i != 5) select.p2selected = true;
                }
            }
        }
    }
}
