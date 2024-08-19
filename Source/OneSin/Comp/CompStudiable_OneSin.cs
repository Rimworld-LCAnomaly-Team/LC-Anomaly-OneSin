using LCAnomalyLibrary.Comp;

namespace OneSin.Comp
{
    public class CompStudiable_OneSin : LC_CompStudiable
    {
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
