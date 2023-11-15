using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class Tertiaryfunction
        {
            public static void MaterialpairSecondaryForeach()
            {
                var aoth = InputString.Length;

                foreach (FunctionTwenty FunctionFifty__VALUE in new ArrayList(FunctionFiftyArrayList))
                {
                    var boolean_safe_SMALLER_is = true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && FunctionFifty__VALUE.Character.Equals(Left.SymmetryCharacter) is true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && FunctionFifty__VALUE.HasSymmetry.Equals(true) is true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && (FunctionFifty__VALUE.Position > Position) is true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && (FunctionFifty__VALUE.Position < aoth) is true;

                    Boolean isSmallerCheck, shouldContinueCheck;

                    isSmallerCheck = boolean_safe_SMALLER_is is true;

                    shouldContinueCheck = isSmallerCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Right = FunctionFifty__VALUE;

                    aoth = FunctionFifty__VALUE.Position;

                    continue;
                }

                return;
            }
        }
    }
}
