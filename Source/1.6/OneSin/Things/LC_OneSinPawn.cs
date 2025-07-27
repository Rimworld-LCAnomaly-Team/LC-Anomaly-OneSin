using LCAnomalyCore.Comp;
using LCAnomalyCore.Util;

namespace OneSin.Things
{
    public class LC_OneSinPawn : LC_EntityBasePawn
    {
        public LC_OneSinPawn()
        {

        }

        protected override void Tick()
        {
            ////收容状态下丢下就出逃
            //if (CarriedBy == null)
            //{
            //    GetComp<CompOneSin>()?.Notify_Escaped();
            //}

            base.Tick();
        }

        public override void TickHolded()
        {
            if (this.Drawer.renderer.CurAnimation != Def.AnimationDefOf.OneSin_Idle)
                this.Drawer.renderer.SetAnimation(Def.AnimationDefOf.OneSin_Idle);
        }
    }
}
