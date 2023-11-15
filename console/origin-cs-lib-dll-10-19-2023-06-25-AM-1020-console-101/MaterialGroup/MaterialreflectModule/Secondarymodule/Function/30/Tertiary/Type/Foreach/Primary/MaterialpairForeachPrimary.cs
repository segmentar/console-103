using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class Tertiaryfunction
        {
            public static void MaterialpairPrimaryForeach()
            {
                Position = -1;

                foreach (FunctionTwenty FunctionFifty__VALUE in new ArrayList(FunctionFiftyArrayList))
                {
                    var boolean_safe_LARGER_is = true;

                    boolean_safe_LARGER_is = boolean_safe_LARGER_is && (FunctionFifty__VALUE.Position > Position) is true;

                    boolean_safe_LARGER_is = boolean_safe_LARGER_is && FunctionFifty__VALUE.HasSymmetry is false;

                    Boolean isLargerCheck, shouldContinueCheck;

                    isLargerCheck = boolean_safe_LARGER_is is true;

                    shouldContinueCheck = isLargerCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Left = FunctionFifty__VALUE;

                    Position = FunctionFifty__VALUE.Position;

                    continue;
                }

                return;
            }
        }
    }
}
