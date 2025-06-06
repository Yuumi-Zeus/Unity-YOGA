using Sirenix.OdinInspector;
using UnityEngine;

namespace YOGA.Modules.OdinToolkits.Schwapo.Editor.Examples
{
    [ResolvedParameterExample]
    public class InlineButtonExamples_Label
    {
        [FoldoutGroup("Attribute Expression Example")] [InlineButton("Action", Label = "@Label")]
        public string AttributeExpressionExample;

        public string Label = "Peace, Love & Ducks";

        [FoldoutGroup("Method Name Example")] [InlineButton("Action", Label = "$GetLabel")]
        public string MethodNameExample;

        private void Action()
        {
            Debug.Log("We don't care about the action in this example");
        }

        private string GetLabel()
        {
            return Label;
        }
    }
    // End

    [ResolvedParameterExample]
    public class InlineButtonExamples_ShowIf
    {
        [FoldoutGroup("Attribute Expression Example")] [InlineButton("Action", Label = "Click", ShowIf = "@Show")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")] [InlineButton("Action", Label = "Click", ShowIf = "GetShowState")]
        public string MethodNameExample;

        public bool Show;

        private void Action()
        {
            Debug.Log("We don't care about the action in this example");
        }

        private bool GetShowState()
        {
            return Show;
        }
    }
    // End

    [ResolvedParameterExample]
    public class InlineButtonExamples_Action
    {
        [FoldoutGroup("Attribute Expression Example")]
        [InlineButton("@Debug.Log(\"Attribute Expression Example\")", Label = "Log Attribute Expression Example")]
        public string AttributeExpressionExample;

        [FoldoutGroup("Method Name Example")] [InlineButton("LogMethodNameExample")]
        public string MethodNameExample;

        private void LogMethodNameExample()
        {
            Debug.Log("Method Name Example");
        }
    }
    // End
}