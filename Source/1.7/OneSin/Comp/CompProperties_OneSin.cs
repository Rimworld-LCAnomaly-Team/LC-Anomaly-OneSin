using LCAnomalyCore.Comp;

namespace OneSin.Comp
{
    /// <summary>
    /// 定义“一罪与百善”异常实体组件的配置。
    /// </summary>
    public class CompProperties_OneSin : CompProperties_Abnormality
    {
        /// <summary>
        /// 初始化组件类型。
        /// </summary>
        public CompProperties_OneSin()
        {
            compClass = typeof(CompOneSin);
        }
    }
}
