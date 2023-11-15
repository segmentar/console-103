using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionThirty
        {
            public static IList<FunctionThirty> FunctionDefaultSet(String value_STRING, FunctionTwenty[] array_FUNCTION)
            {
                ICollection<FunctionThirty> collectionResult = default;

                collectionResult = new Collection<FunctionThirty>();
                
                var list = new ArrayList(array_FUNCTION);

                do
                {
                    FunctionTwenty left, right;

                    left = default;

                    right = default;

                    var zeroth = -1;

                    foreach (FunctionTwenty FunctionFifty__VALUE in new ArrayList(list))
                    {
                        var boolean_safe_LARGER_is = true;

                        boolean_safe_LARGER_is = boolean_safe_LARGER_is && (FunctionFifty__VALUE.Position > zeroth) is true;

                        boolean_safe_LARGER_is = boolean_safe_LARGER_is && FunctionFifty__VALUE.HasSymmetry.Equals(false) is true;

                        Boolean isLargerCheck, shouldContinueCheck;

                        isLargerCheck = boolean_safe_LARGER_is is true;

                        shouldContinueCheck = isLargerCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        zeroth = FunctionFifty__VALUE.Position;

                        left = FunctionFifty__VALUE;

                        continue;
                    }

                    var aoth = value_STRING.Length;

                    foreach (FunctionTwenty item_FUNCTION in new ArrayList(list))
                    {
                        var boolean_safe_SMALLER_is = true;

                        boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && item_FUNCTION.Character.Equals(left.SymmetryCharacter) is true;

                        boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && item_FUNCTION.HasSymmetry.Equals(true) is true;

                        boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && (item_FUNCTION.Position > zeroth) is true;

                        boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && (item_FUNCTION.Position < aoth) is true;

                        Boolean isSmallerCheck, shouldContinueCheck;

                        isSmallerCheck = boolean_safe_SMALLER_is is true;

                        shouldContinueCheck = isSmallerCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        if (isSmallerCheck is true)
                        {
                            aoth = item_FUNCTION.Position;
                        }
                        else
                            "false".ToString();

                        right = item_FUNCTION;

                        continue;
                    }

                    var boolean_contagious_BREAK_should = false;

                    boolean_contagious_BREAK_should = boolean_contagious_BREAK_should || (left == default) is true;

                    boolean_contagious_BREAK_should = boolean_contagious_BREAK_should || (right == default) is true;

                    Boolean shouldBreakCheck;

                    shouldBreakCheck = boolean_contagious_BREAK_should is true;

                    if (shouldBreakCheck)
                    {
                        break;
                    }
                    else
                    {
                        var layer = 1;

                        foreach (FunctionTwenty entry_FUNCTION in list)
                        {
                            var boolean_safe_EQUAL_is = true;

                            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && ReferenceEquals(entry_FUNCTION, right) is false;

                            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && (entry_FUNCTION.Position > right.Position) is true;

                            boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && entry_FUNCTION.Character.Equals(right.Character) is true;

                            Boolean shouldContinueCheck;

                            shouldContinueCheck = boolean_safe_EQUAL_is is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            layer = layer + 1;

                            continue;
                        }

                        list.Remove(left);

                        list.Remove(right);

                        var start = left.Position;

                        var difference = (right.Position - start);

                        var align_LEFT = (start + 1);

                        var align_RIGHT = (difference - 1);

                        var sub = value_STRING.Substring(align_LEFT, align_RIGHT);

                        var ReflectStringSafe___VALUE = MaterialStringSafe.Simple(sub);

                        var item_FUNCTION = new FunctionThirty(left, right, ReflectStringSafe___VALUE);

                        collectionResult.Add(item_FUNCTION);
                    }

                    continue;

                } while (true);

                return new List<FunctionThirty>(collectionResult);
            }
        }
    }
}
