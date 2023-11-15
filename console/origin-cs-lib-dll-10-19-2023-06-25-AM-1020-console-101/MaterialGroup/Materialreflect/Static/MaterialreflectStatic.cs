using Core;

namespace Core
{
    using System;

    internal partial class Materialreflect
    {
        static Materialreflect()
        {
            return;
        }

        public static void Procedure()
        {
            MaterialreflectPolicy.MaterialreflectDebugPolicy = true;

            MaterialreflectPolicy.MaterialreflectInfoPolicy = true;
            
            return;
        }

        public static void Manual(MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY, out MaterialreflectPrimarymodule MaterialreflectModule__VALUE)
        {
            var materialreflect = MakeMaterialreflectDefaultSurface(StringFormat__VALUE, EscapeCharacter__ARRAY);

            MaterialreflectPrimarymodule materialreflectModule = MaterialreflectPrimarymodule.MaterialreflectModuleAction(materialreflect, true);

            MaterialreflectSecondarymodule materialreflectSecondarymodule = MaterialreflectSecondarymodule.MaterialreflectSecondarymoduleAction(materialreflect, true);

            MaterialreflectTertiarymodule materialreflectTertiarymodule = MaterialreflectTertiarymodule.MaterialreflectTertiarymoduleAction(materialreflect, true);

            materialreflect.OutputString = materialreflectModule.First.Function.StringResult.StringValue;

            MaterialreflectModule__VALUE = materialreflectModule;

            return;
        }

        public static void Raise()
        {
            if (MaterialreflectPolicy.MaterialreflectInfoPolicy is true)
            {
                Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Info}-{nameof(Materialreflect)}Info", MaterialreflectPolicy.MaterialreflectArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle(MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY, out MaterialreflectPrimarymodule MaterialreflectModule__VALUE)
        {
            Procedure();

            Manual(StringFormat__VALUE, EscapeCharacter__ARRAY, out MaterialreflectModule__VALUE);

            Raise();

            return;
        }
    }
}
