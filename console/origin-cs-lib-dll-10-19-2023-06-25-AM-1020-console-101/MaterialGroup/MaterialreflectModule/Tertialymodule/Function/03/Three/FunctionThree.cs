using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        public static MaterialreflectTertiarymodule FunctionThree(MaterialreflectTertiarymodule module)
        {
            Materialchain materialchain;

            materialchain = new Materialchain(module.Second.Function.MaterialqueryArray);

            var function = new FunctionThirty(materialchain);

            FunctionThird third;

            third = new FunctionThird(function);

            module.Third = third;

            return module;
        }
    }
}
