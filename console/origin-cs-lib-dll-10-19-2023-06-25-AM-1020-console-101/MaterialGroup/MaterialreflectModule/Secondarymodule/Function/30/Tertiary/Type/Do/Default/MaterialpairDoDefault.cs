using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class Tertiaryfunction
        {
            public static void MaterialpairDefaultDo()
            {
                do
                {
                    Left = default(FunctionTwenty);

                    Right = default(FunctionTwenty);

                    MaterialpairPrimaryForeach();

                    MaterialpairSecondaryForeach();

                    var boolean_contagent_BREAK_should = false;

                    boolean_contagent_BREAK_should = boolean_contagent_BREAK_should || (Left == default) is true;

                    boolean_contagent_BREAK_should = boolean_contagent_BREAK_should || (Right == default) is true;

                    Boolean shouldBreakCheck;

                    shouldBreakCheck = boolean_contagent_BREAK_should is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    MaterialpairSecondaryVoid();

                    continue;

                } while (true);

                return;
            }
        }
    }
}
