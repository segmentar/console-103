using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionSixty
        {
            public static FunctionSixty[] FunctionDefaultSetSurface(String item_STRING, FunctionFifty[] array_FUNCTION, Char[] array_CHARACTER)
            {
                FunctionSixty[] arrayResult = default;

                var list = FunctionDefaultSet(item_STRING, array_FUNCTION, array_CHARACTER);

                var array = new FunctionSixty[list.Count];

                list.CopyTo(array, MaterialreflectPolicy.MaterialreflectIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
