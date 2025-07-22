using LCAnomalyCore.Comp;
using LCAnomalyCore.Comp.Pawns;
using LCAnomalyCore.Util;
using RimWorld;
using Verse;

namespace OneSin.Comp
{
    public class CompOneSin : CompAbnormality
    {
        #region 变量

        public new CompProperties_OneSin Props => (CompProperties_OneSin)props;

        #endregion 变量

        #region 触发事件

        public override void Notify_Killed(Map prevMap, DamageInfo? dinfo = null)
        {
            Util.EffectUtil.OnOneSinDeath((Pawn)parent, prevMap);
        }

        public override void Notify_Escaped()
        {
            parent.Kill();
        }

        /// <summary>
        /// 绑到收容平台上后的操作
        /// </summary>
        public override void Notify_Holded()
        {
            CheckIsDiscovered();
        }

        #endregion 触发事件

        #region 研究与图鉴

        protected override float StudySuccessRateCalculate(CompPawnStatus studier, EAnomalyWorkType workType)
        {
            float baseRate = base.StudySuccessRateCalculate(studier, workType);
            float workTypeRate = 0;
            float finalRate = 0;

            switch (workType)
            {
                case EAnomalyWorkType.Instinct:
                    //本能：I级50%，II级40%，别的30%
                    switch (studier.GetPawnStatusELevel(EPawnStatus.Fortitude))
                    {
                        case EPawnLevel.I:
                            workTypeRate = 0.5f;
                            break;
                        case EPawnLevel.II:
                            workTypeRate = 0.4f;
                            break;
                        default:
                            workTypeRate = 0.3f;
                            break;
                    }
                    break;
                case EAnomalyWorkType.Insight:
                    //洞察：I和II级70%，别的50%
                    switch (studier.GetPawnStatusELevel(EPawnStatus.Prudence))
                    {
                        case EPawnLevel.I:
                        case EPawnLevel.II:
                            workTypeRate = 0.7f;
                            break;
                        default:
                            workTypeRate = 0.5f;
                            break;
                    }
                    break;
                case EAnomalyWorkType.Attachment:
                    //沟通：70%
                    switch (studier.GetPawnStatusELevel(EPawnStatus.Temperance))
                    {
                        default:
                            workTypeRate = 0.7f;
                            break;
                    }
                    break;
                case EAnomalyWorkType.Repression:
                    //压迫：I级50%，II级40%，别的30%
                    switch (studier.GetPawnStatusELevel(EPawnStatus.Justice))
                    {
                        case EPawnLevel.I:
                            workTypeRate = 0.5f;
                            break;
                        case EPawnLevel.II:
                            workTypeRate = 0.4f;
                            break;
                        default:
                            workTypeRate = 0.3f;
                            break;
                    }
                    break;
            }

            finalRate = baseRate + workTypeRate;

            //成功率不能超过95%
            if (finalRate > 0.95f)
                finalRate = 0.95f;

            return finalRate;
        }

        /// <summary>
        /// 检查是否已在图鉴中被解锁
        /// </summary>
        private void CheckIsDiscovered()
        {
            if (AnomalyUtility.ShouldNotifyCodex((Pawn)parent, EntityDiscoveryType.BecameVisible, out var entries))
            {
                Find.EntityCodex.SetDiscovered(entries, Def.PawnKindDefOf.OneSin.race, (Pawn)parent);
            }
        }

        #endregion 研究与图鉴
    }
}
