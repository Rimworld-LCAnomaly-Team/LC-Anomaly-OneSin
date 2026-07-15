using LCAnomalyCore.Defs;
using RimWorld;
using Verse;

namespace OneSin.Def
{
    /// <summary>
    /// 提供本模组使用的物体定义引用。
    /// </summary>
    [DefOf]
    public static class ThingDefOf
    {
        /// <summary>
        /// “一罪与百善”的死亡特效对象定义。
        /// </summary>
        public static ThingDef_AbnormalityEntity_Spawn DyingOneSin;

        /// <summary>
        /// “一罪与百善”的重生蛋定义。
        /// </summary>
        public static ThingDef OneSinEgg;

        static ThingDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
        }
    }
}
