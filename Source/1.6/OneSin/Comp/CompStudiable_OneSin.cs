using LCAnomalyCore.Comp;

namespace OneSin.Comp
{
    /// <summary>
    /// 根据研究解锁进度提供“一罪与百善”的工作加成。
    /// </summary>
    public class CompStudiable_OneSin : CompAbnormalityStudiable
    {
        /// <inheritdoc />
        public override float GetWorkSpeedOffset()
        {
            if (CompStudyUnlocks.Completed)
            {
                return 0.1f;
            }
            else if (CompStudyUnlocks.Progress >= 2)
            {
                return 0.05f;
            }

            return 0;
        }

        /// <inheritdoc />
        public override float GetWorkSuccessRateOffset()
        {
            if (CompStudyUnlocks.Progress >= 3)
            {
                return 0.1f;
            }
            else if (CompStudyUnlocks.Progress >= 1)
            {
                return 0.05f;
            }

            return 0;
        }
    }
}
