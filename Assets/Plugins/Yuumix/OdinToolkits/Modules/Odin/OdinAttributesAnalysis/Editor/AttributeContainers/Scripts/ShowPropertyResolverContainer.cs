using Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Common.Editor;
using Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Editor.AttributePreviewExamples.Scripts;
using System.Collections.Generic;

namespace Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Editor.AttributeContainers.Scripts
{
    public class ShowPropertyResolverContainer : AbsContainer
    {
        protected override string SetHeader()
        {
            return "ShowPropertyResolver";
        }

        protected override string SetBrief()
        {
            return "显示负责将成员引入属性树的属性解析器";
        }

        protected override List<string> SetTip()
        {
            return new List<string>
            {
                "一个通常不会在检查器中显示的特定成员突然出现时，可以使用此特性调试",
                "此示例基于 Odin 序列化"
            };
        }

        protected override List<ParamValue> SetParamValues()
        {
            return new List<ParamValue>();
        }

        protected override string SetOriginalCode()
        {
            return ReadCodeWithoutNamespace(typeof(ShowPropertyResolverExample));
        }
    }
}