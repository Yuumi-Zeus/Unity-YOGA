using Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Common.Editor;
using Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Editor.AttributePreviewExamples.Scripts;
using System.Collections.Generic;

namespace Plugins.YOGA.OdinToolkits.Modules.OdinAttributesAnalysis.Editor.AttributeContainers.Scripts
{
    public class EnableIfContainer : AbsContainer
    {
        protected override string SetHeader()
        {
            return "EnableIf";
        }

        protected override string SetBrief()
        {
            return "满足条件时，Property 才可获取焦点";
        }

        protected override List<string> SetTip()
        {
            return new List<string>();
        }

        protected override List<ParamValue> SetParamValues()
        {
            return new List<ParamValue>
            {
                new()
                {
                    returnType = "string",
                    paramName = "condition",
                    paramDescription = "成员名，" + DescriptionConfigs.SupportAllResolver
                },
                new()
                {
                    returnType = "object",
                    paramName = "optionalValue",
                    paramDescription = "成员名的值，需要与 condition 参数配合使用，如果成员的值 == optionalValue，则满足条件"
                }
            };
        }

        protected override string SetOriginalCode()
        {
            return ReadCodeWithoutNamespace(typeof(EnableIfExample));
        }
    }
}