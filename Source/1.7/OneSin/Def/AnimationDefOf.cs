using RimWorld;
using Verse;

namespace OneSin.Def
{
    /// <summary>
    /// 提供本模组使用的动画定义引用。
    /// </summary>
    [DefOf]
    public static class AnimationDefOf
    {
        /// <summary>
        /// “一罪与百善”的待机动画。
        /// </summary>
        public static AnimationDef OneSin_Idle;

        static AnimationDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(AnimationDefOf));
        }
    }
}
