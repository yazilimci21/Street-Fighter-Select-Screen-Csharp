using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Street_Fighter.Chars
{
    public class Cammy : ClassicChar
    {
        public Keys[] Dashing_Uppercut = new Keys[] { Keys.Left, Keys.Right, Keys.A },
            Dashing_Punch = new Keys[] { Keys.Left, Keys.Right, Keys.Z };

        public override void Update(float time, System.Drawing.PointF CameraLocation)
        {
            if (this.PlayerKeyList.Count == 0) return;
            RemoveNullKeys(1);
            Core.Sprite.SpriteProperties.StatusTypes Status = Core.Sprite.SpriteProperties.StatusTypes.Normal;
            Animations Animation = Animations.idle;
            if (findKeys(Dashing_Punch, true))
            {
                Status = Core.Sprite.SpriteProperties.StatusTypes.Attack;
            }
            else if (findKeys(Dashing_Uppercut, true))
            {
                Status = Core.Sprite.SpriteProperties.StatusTypes.Attack;
            }
            else if (this.LookClassicAction(ref Animation))
            {
                DoClassicAction(Animation);
            }
            else
            {

            }
            this.Properties.Status = Status;
        }

        public override bool OtherCollided(Core.Sprite.Sprite sprite, Core.Sprite.SpriteProperties.Directions collidedDirection, System.Drawing.PointF CameraLocation)
        {
            HitKontrol((Core.Material)sprite);
            return true;
        }

        private void DoClassicAction(Animations Animation)
        {
            if (Animation == Animations.jumpnext)
            {

            }
            else if (Animation == Animations.jumpback)
            {

            }
            else if (Animation == Animations.crouch)
            {

            }
            else if (Animation == Animations.jump)
            {

            }
            else if (Animation == Animations.next)
            {

            }
            else if (Animation == Animations.back)
            {

            }
            else if (Animation == Animations.idleSmallKick)
            {

            }
            else if (Animation == Animations.idleNormalKick)
            {

            }
            else if (Animation == Animations.idleBigKick)
            {

            }
            if (Animation == Animations.idleSmallPunch)
            {

            }
            else if (Animation == Animations.idleNormalPunch)
            {

            }
            else if (Animation == Animations.idleBigPunch)
            {

            }
        }
    }
}
