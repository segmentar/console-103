using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static String[] SolidStringArray(String[] String_ARRAY)
        {
            String[] arrayResult = default;

            var indexer = 0;

            foreach (String String_ITEM in String_ARRAY)
            {
                var item_STRING = String_ARRAY[indexer];

                var entry_STRING = SolidString(item_STRING);

                String_ARRAY[indexer] = entry_STRING;

                indexer = indexer + 1;

                continue;
            }

            var array = String_ARRAY;

            arrayResult = array;

            return arrayResult;
        }
    }
}
