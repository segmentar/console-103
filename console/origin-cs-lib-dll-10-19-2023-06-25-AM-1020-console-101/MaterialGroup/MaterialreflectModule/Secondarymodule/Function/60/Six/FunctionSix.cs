﻿using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule FunctionSix(MaterialreflectSecondarymodule module)
        {
            var array = FunctionSixty.FunctionDefaultSetSurface(module.Materialreflect.InputString.StringValue, module.Fifth.FunctionArray, module.Materialreflect.EscapeCharacterArray.CharacterArray);

            FunctionSixth sixth;

            sixth = new FunctionSixth(array);

            module.Sixth = sixth;

            return module;
        }
    }
}
