using Core;

namespace Core
{
    using System;

    internal partial class Materialreflect
    {
        internal static Materialreflect MakeMaterialreflectDefault(MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY, Boolean answer_DEBUG_is)
        {
            Materialreflect materialreflectResult = default;

            var result = new MaterialreflectSequence(StringFormat__VALUE, EscapeCharacter__ARRAY, answer_DEBUG_is).Result;

            MaterialreflectPolicy.MaterialreflectArrayList.Add(result);

            materialreflectResult = result;

            return materialreflectResult;
        }
    }
}
