using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Street_Fighter.Chars
{
    public class ClassicChar : Core.Player
    {
        public enum Animations : int
        {
            idle = 0, idleSmallKick, idleNormalKick, idleBigKick, idleSmallPunch, idleNormalPunch, idleBigPunch,
            next, nextSmallKick, nextNormalKick, nextBigKick, nextSmallPunch, nextNormalPunch, nextBigPunch,
            back, backSmallKick, backNormalKick, backBigKick, backSmallPunch, backNormalPunch, backBigPunch,
            crouch, crouchSmallKick, crouchNormalKick, crouchBigKick, crouchSmallPunch, crouchNormalPunch, crouchBigPunch,
            jump, jumpSmallKick, jumpNormalKick, jumpBigKick, jumpSmallPunch, jumpNormalPunch, jumpBigPunch,
            jumpnext, jumpnextSmallKick, jumpnextNormalKick, jumpnextBigKick, jumpnextSmallPunch, jumpnextNormalPunch, jumpnextBigPunch,
            jumpback, jumpbackSmallKick, jumpbackNormalKick, jumpbackBigKick, jumpbackSmallPunch, jumpbackNormalPunch, jumpbackBigPunch,
            jumpProtect, crouchProtect, NormalProtect,
            jumpHit, crouchHit, NormalHit
        }

        #region Classic Animations
        public Core.Animation.Animator jump = new Core.Animation.Animator();
        public Core.Animation.Animator jumpSmallKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpNormalKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpBigKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpSmallPunch = new Core.Animation.Animator();
        public Core.Animation.Animator jumpNormalPunch = new Core.Animation.Animator();
        public Core.Animation.Animator jumpBigPunch = new Core.Animation.Animator();

        public Core.Animation.Animator jumpnext = new Core.Animation.Animator();
        public Core.Animation.Animator jumpnextSmallKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpnextNormalKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpnextBigKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpnextSmallPunch = new Core.Animation.Animator();
        public Core.Animation.Animator jumpnextNormalPunch = new Core.Animation.Animator();
        public Core.Animation.Animator jumpnextBigPunch = new Core.Animation.Animator();
        
        public Core.Animation.Animator jumpback = new Core.Animation.Animator();
        public Core.Animation.Animator jumpbackSmallKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpbackNormalKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpbackBigKick = new Core.Animation.Animator();
        public Core.Animation.Animator jumpbackSmallPunch = new Core.Animation.Animator();
        public Core.Animation.Animator jumpbackNormalPunch = new Core.Animation.Animator();
        public Core.Animation.Animator jumpbackBigPunch = new Core.Animation.Animator();
        
        public Core.Animation.Animator next = new Core.Animation.Animator();
        public Core.Animation.Animator nextSmallKick = new Core.Animation.Animator();
        public Core.Animation.Animator nextNormalKick = new Core.Animation.Animator();
        public Core.Animation.Animator nextBigKick = new Core.Animation.Animator();
        public Core.Animation.Animator nextSmallPunch = new Core.Animation.Animator();
        public Core.Animation.Animator nextNormalPunch = new Core.Animation.Animator();
        public Core.Animation.Animator nextBigPunch = new Core.Animation.Animator();

        public Core.Animation.Animator back = new Core.Animation.Animator();
        public Core.Animation.Animator backSmallKick = new Core.Animation.Animator();
        public Core.Animation.Animator backNormalKick = new Core.Animation.Animator();
        public Core.Animation.Animator backBigKick = new Core.Animation.Animator();
        public Core.Animation.Animator backSmallPunch = new Core.Animation.Animator();
        public Core.Animation.Animator backNormalPunch = new Core.Animation.Animator();
        public Core.Animation.Animator backBigPunch = new Core.Animation.Animator();

        public Core.Animation.Animator idle = new Core.Animation.Animator();
        public Core.Animation.Animator idleSmallKick = new Core.Animation.Animator();
        public Core.Animation.Animator idleNormalKick = new Core.Animation.Animator();
        public Core.Animation.Animator idleBigKick = new Core.Animation.Animator();
        public Core.Animation.Animator idleSmallPunch = new Core.Animation.Animator();
        public Core.Animation.Animator idleNormalPunch = new Core.Animation.Animator();
        public Core.Animation.Animator idleBigPunch = new Core.Animation.Animator();


        public Core.Animation.Animator crouch = new Core.Animation.Animator();
        public Core.Animation.Animator crouchSmallKick = new Core.Animation.Animator();
        public Core.Animation.Animator crouchNormalKick = new Core.Animation.Animator();
        public Core.Animation.Animator crouchBigKick = new Core.Animation.Animator();
        public Core.Animation.Animator crouchSmallPunch = new Core.Animation.Animator();
        public Core.Animation.Animator crouchNormalPunch = new Core.Animation.Animator();
        public Core.Animation.Animator crouchBigPunch = new Core.Animation.Animator();

        public Core.Animation.Animator jumpProtect = new Core.Animation.Animator();
        public Core.Animation.Animator crouchProtect = new Core.Animation.Animator();
        public Core.Animation.Animator NormalProtect = new Core.Animation.Animator();

        public Core.Animation.Animator jumpHit = new Core.Animation.Animator();
        public Core.Animation.Animator crouchHit = new Core.Animation.Animator();
        public Core.Animation.Animator NormalHit = new Core.Animation.Animator();
        #endregion

        public Keys CrouchButton = Keys.Down, JumpButton = Keys.Up, NextButton = Keys.Right, BackButton = Keys.Left;
        public Keys[] JumpNextButton = new Keys[] { Keys.Right, Keys.Up }, JumpBackButton = new Keys[] { Keys.Left, Keys.Up };
        public Keys SmallKickButton = Keys.D, NormalKickButton = Keys.S, BigKickButton = Keys.A,
            SmallPunchButton = Keys.C, NormalPunchButton = Keys.X, BigPunchButton = Keys.Z;

        public ClassicChar()
        {
            this.Properties.GravityValue = 0.28f;
            listedKey = true;
            AnimatorList.AddRange(new Core.Animation.Animator[] {
            idle, idleSmallKick, idleNormalKick, idleBigKick, idleSmallPunch, idleNormalPunch, idleBigPunch,
            next, nextSmallKick, nextNormalKick, nextBigKick, nextSmallPunch, nextNormalPunch, nextBigPunch,
            back, backSmallKick, backNormalKick, backBigKick, backSmallPunch, backNormalPunch, backBigPunch,
            crouch, crouchSmallKick, crouchNormalKick, crouchBigKick, crouchSmallPunch, crouchNormalPunch, crouchBigPunch,
            jump, jumpSmallKick, jumpNormalKick, jumpBigKick, jumpSmallPunch, jumpNormalPunch, jumpBigPunch,
            jumpnext, jumpnextSmallKick, jumpnextNormalKick, jumpnextBigKick, jumpnextSmallPunch, jumpnextNormalPunch, jumpnextBigPunch,
            jumpback, jumpbackSmallKick, jumpbackNormalKick, jumpbackBigKick, jumpbackSmallPunch, jumpbackNormalPunch, jumpbackBigPunch,
            jumpProtect, crouchProtect, NormalProtect,
            jumpHit, crouchHit, NormalHit
            });
            this.setAnimation((int)Animations.idle);
            this.Properties.CollisionRect.Size = this.currentAnimator.AnimSize;
        }

        public bool LookClassicAction(ref Animations Animation)
        {
            if(findKeys(JumpNextButton, true))
            {
                Animation = Animations.jumpnext;
                return true;
            }
            else if (findKeys(JumpBackButton, true))
            {
                Animation = Animations.jumpback;
                return true;
            }
            else if (findKeys(new Keys[]{ CrouchButton }, false))
            {
                Animation = Animations.crouch;
                return true;
            }
            else if (findKeys(new Keys[] { JumpButton }, false))
            {
                Animation = Animations.jump;
                return true;
            }
            else if (findKeys(new Keys[] { NextButton }, false))
            {
                Animation = Animations.next;
                return true;
            }
            else if (findKeys(new Keys[] { BackButton }, false))
            {
                Animation = Animations.back;
                return true;
            }
            else if (findKeys(new Keys[] { SmallKickButton }, true))
            {
                Animation = Animations.idleSmallKick;
                return true;
            }
            else if (findKeys(new Keys[] { NormalKickButton }, true))
            {
                Animation = Animations.idleNormalKick;
                return true;
            }
            else if (findKeys(new Keys[] { BigKickButton }, true))
            {
                Animation = Animations.idleBigKick;
                return true;
            }
            else if (findKeys(new Keys[] { SmallPunchButton }, true))
            {
                Animation = Animations.idleSmallPunch;
                return true;
            }
            else if (findKeys(new Keys[] { NormalPunchButton }, true))
            {
                Animation = Animations.idleNormalPunch;
                return true;
            }
            else if (findKeys(new Keys[] { BigPunchButton }, true))
            {
                Animation = Animations.idleBigPunch;
                return true;
            }
            return false;
        }

        public void HitKontrol(Core.Material material)
        {

        }

        public bool findKeys(Keys[] fkeys, bool removeKeys)
        {
            if (PlayerKeyList.Count < fkeys.Length || fkeys.Length == 0) return false;

            for(int i=0;i<fkeys.Length;i++)
            {
                if (this.Properties.Direction == Core.Sprite.SpriteProperties.Directions.Left)
                {
                    if (fkeys[i] == Keys.Left) fkeys[i] = Keys.Right;
                    if (fkeys[i] == Keys.Right) fkeys[i] = Keys.Left;
                }
                if (PlayerKeyList[i].Key.KeyCode != fkeys[i])
                    return false;
            }
            if (removeKeys)
            {
                if (fkeys.Length == 1)
                    PlayerKeyList.RemoveAt(0);
                else
                    PlayerKeyList.RemoveRange(0, fkeys.Length);
            }
            return true;
        }

        public void RemoveNullKeys(int betweensecond)
        {
            for (int i = 0; i < PlayerKeyList.Count; i++)
            {
                if (PlayerKeyList[i].BetweenClick > betweensecond)
                {
                    if (i == 0)
                    {
                        PlayerKeyList.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        PlayerKeyList.RemoveRange(0, i+1);
                        i = -1;
                    }
                }
                if(i > 0)
                {

                }
            }
        }
    }
}
