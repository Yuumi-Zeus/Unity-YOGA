using Sirenix.OdinInspector;
using UnityEngine;
using Yuumix.OdinToolkits.Modules.Odin.OdinAttributesAnalysis.Common.Editor;

namespace Yuumix.OdinToolkits.Modules.Odin.OdinAttributesAnalysis.Editor.AttributePreviewExamples.Scripts
{
    [IsChineseAttributeExample]
    public class SuffixLabelExample : ExampleScriptableObject
    {
        [SuffixLabel("Prefab")]
        public GameObject GameObject;

        [Space(15)]
        [SuffixLabel("ms", Overlay = true)]
        public float Speed;

        [SuffixLabel("radians", Overlay = true)]
        public float Angle;

        [Space(15)]
        [SuffixLabel("$Suffix", Overlay = true)]
        public string Suffix = "Dynamic suffix label";

        [InfoBox("The Suffix attribute also supports expressions by using @.")]
        [SuffixLabel("@DateTime.Now.ToString(\"HH:mm:ss\")", true)]
        public string Expression;

        [SuffixLabel("Suffix with icon", SdfIconType.HeartFill)]
        public string IconAndText1;

        [SuffixLabel(SdfIconType.HeartFill)]
        public string OnlyIcon1;

        [SuffixLabel("Suffix with icon", SdfIconType.HeartFill, Overlay = true)]
        public string IconAndText2;

        [SuffixLabel(SdfIconType.HeartFill, Overlay = true)]
        public string OnlyIcon2;
    }
}
