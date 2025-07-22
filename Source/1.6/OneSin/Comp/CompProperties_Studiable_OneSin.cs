using LCAnomalyCore.Comp;

namespace OneSin.Comp
{
    public class CompProperties_Studiable_OneSin : CompProperties_AbnormalityStudiable
    {
        public CompProperties_Studiable_OneSin()
        {
            compClass = typeof(CompStudiable_OneSin);
        }
    }
}