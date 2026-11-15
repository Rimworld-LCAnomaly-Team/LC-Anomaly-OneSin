using LCAnomalyCore.Comp;

namespace OneSin.Comp
{
    /// <summary>
    /// 定义“一罪与百善”可研究组件的配置。
    /// </summary>
    public class CompProperties_Studiable_OneSin : CompProperties_AbnormalityStudiable
    {
        /// <summary>
        /// 初始化可研究组件类型。
        /// </summary>
        public CompProperties_Studiable_OneSin()
        {
            compClass = typeof(CompStudiable_OneSin);
        }
    }
}
