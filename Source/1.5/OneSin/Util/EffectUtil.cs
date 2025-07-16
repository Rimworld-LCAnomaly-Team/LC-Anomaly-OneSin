using OneSin.Effect;
using RimWorld;
using Verse;

namespace OneSin.Util
{
    public static class EffectUtil
    {
        /// <summary>
        /// 一罪与百善死后操作
        /// </summary>
        /// <param name="pawn">单位</param>
        /// <param name="map">地图</param>
        public static void OnOneSinDeath(Pawn pawn, Map map)
        {
            Find.LetterStack.ReceiveLetter("LetterLabelOneSinKilled".Translate()
                , "LetterOneSinKilled".Translate()
                , LetterDefOf.PositiveEvent
                , new LookTargets(pawn.PositionHeld, pawn.MapHeld));

            ((DyingOneSin)GenSpawn
                .Spawn(Def.ThingDefOf.DyingOneSin, pawn.Position, map))
                .InitWith(pawn);
        }
    }
}
