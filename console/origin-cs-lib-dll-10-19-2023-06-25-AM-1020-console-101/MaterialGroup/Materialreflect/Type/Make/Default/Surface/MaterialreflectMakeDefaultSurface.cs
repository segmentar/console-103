using Core;

namespace Core
{
    using System;

    internal partial class Materialreflect
    {
        internal static Materialreflect MakeMaterialreflectDefaultSurface(MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY)
        {
            Materialreflect materialreflectResult = default;

            materialreflectResult = MakeMaterialreflectDefault(StringFormat__VALUE, EscapeCharacter__ARRAY, MaterialreflectPolicy.MaterialreflectDebugPolicy);

            return materialreflectResult;
        }
    }
}
