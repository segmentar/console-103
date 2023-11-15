using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionThirty
        {
            public static FunctionThirty[] FunctionDefaultSetSurface(String InputString__VALUE, FunctionTwenty[] FunctionFifty__ARRAY)
            {
                FunctionThirty[] arrayResult = default;

                var list = FunctionDefaultSet(InputString__VALUE, FunctionFifty__ARRAY);

                var array = new FunctionThirty[list.Count];

                list.CopyTo(array, MaterialreflectPolicy.MaterialreflectIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
    