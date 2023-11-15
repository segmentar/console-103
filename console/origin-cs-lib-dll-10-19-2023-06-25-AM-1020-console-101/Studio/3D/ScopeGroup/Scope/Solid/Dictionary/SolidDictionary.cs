using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scope
    {
        public static String SolidDictionary(IDictionary Dictionary_VALUE, Int32 Count_VALUE)
        {
            String stringResult = default;

            var list = new ArrayList(Dictionary_VALUE);

            var result = String.Empty;

            result = result + Count_VALUE;

            result = result + ':';

            result = result + '\n';

            var indexer = 0;

            foreach (var value in list)
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = Count_VALUE.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                result = result + value;

                result = result + '\n';

                indexer = indexer + 1;

                continue;
            }

            stringResult = result;
            
            return stringResult;
        }
    }
}
