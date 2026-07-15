using LCAnomalyCore.Comp;

namespace OneSin.Things
{
    /// <summary>
    /// 表示“一罪与百善”异常实体。
    /// </summary>
    public class LC_OneSinPawn : LC_EntityBasePawn
    {
        /// <inheritdoc />
        public override void TickHolded()
        {
            if (Drawer.renderer.CurAnimation != Def.AnimationDefOf.OneSin_Idle)
                Drawer.renderer.SetAnimation(Def.AnimationDefOf.OneSin_Idle);
        }
    }
}
