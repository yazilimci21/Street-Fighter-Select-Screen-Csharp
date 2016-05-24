using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Street_Fighter.Materials
{
    public class Logo : Core.Material
    {
        Core.Animation.Animator logoAnim = new Core.Animation.Animator();
        string imagepath = Application.StartupPath + "\\Images\\char_select\\";

        public Logo()
        {
            Image logo = Image.FromFile(imagepath + "logo.png");
            logoAnim.AddFrame(logo, "", new SizeF(290, 204));
            this.Properties.CollisionRect = new RectangleF(230, 0, logoAnim.AnimSize.Width, logoAnim.AnimSize.Height);
            this.AnimatorList.Add(logoAnim);
            this.setAnimation(0);
            logo.Dispose();
        }
    }
}
