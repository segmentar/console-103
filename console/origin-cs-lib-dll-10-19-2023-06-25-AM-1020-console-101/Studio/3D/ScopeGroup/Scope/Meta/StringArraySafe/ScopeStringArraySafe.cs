using Core;

namespace Core
{
    using System;

    public partial struct ScopeStringArraySafe
    {
        public String[] StringArrayValue;

        public String[] StringArrayValueSafe;

        public static ScopeStringArraySafe Simple(String[] array_STRING)
        {
            ScopeStringArraySafe safeResult = default;

            String[] stringArrayValue, stringArrayValueSafe;

            stringArrayValue = array_STRING;

            stringArrayValueSafe = Scope.SolidStringArray(array_STRING);

            ScopeStringArraySafe safe;

            safe = new ScopeStringArraySafe();

            safe.StringArrayValue = stringArrayValue;

            safe.StringArrayValueSafe = stringArrayValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
