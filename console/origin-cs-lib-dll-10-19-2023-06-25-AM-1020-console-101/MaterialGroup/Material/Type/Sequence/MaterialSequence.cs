using Core;

namespace Core
{
    using System;

    internal partial class MaterialSequence
    {
        internal Material Result { get; set; } = default;

        internal MaterialSequence(MaterialStringSplitcharacter HeaderSplitcharacter__VALUE, String BodySubstring__VALUE, Boolean answer_DEBUG_is)
        {
            Debug(HeaderSplitcharacter__VALUE, BodySubstring__VALUE, answer_DEBUG_is);

            var Entity_COMMA = Convert.ToChar(44);

            var HeaderSplitcharacterSubstring___VALUE = MaterialStringSplitcharacter.Simple(HeaderSplitcharacter__VALUE.StringValue, Entity_COMMA);

            var BodySubstringSafe___VALUE = MaterialStringSafe.Simple(BodySubstring__VALUE);

            Material element;

            element = new Material(HeaderSplitcharacterSubstring___VALUE, BodySubstringSafe___VALUE, answer_DEBUG_is);

            this.Result = element;

            return;
        }

        ~MaterialSequence()
        {
            return;
        }
    }
}
