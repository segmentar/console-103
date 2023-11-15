﻿using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void HLock(String Filename_VALUE, String[] SplitTruncate__ARRAY)
        {
            try
            {
                Boolean hasLengthCheck, isFatalCheck;

                hasLengthCheck = SplitTruncate__ARRAY.Length.Equals(1) is true;

                isFatalCheck = hasLengthCheck is false;

                if (isFatalCheck is true)
                {
                    var information = new String[] {

                        String.Empty + nameof(hasLengthCheck) + ':' + ' ' + hasLengthCheck,
                        String.Empty + nameof(isFatalCheck) + ':' + ' ' + isFatalCheck
                    };

                    HFatal.Action(new HLockFatal().Initialize(Filename_VALUE, information, default));

                    return;
                }
                else
                    "false".ToString();

                var first = SplitTruncate__ARRAY[0];

                var format = ForgeDashlessFormat(first);

                Lock(format);
            }
            catch (Exception exception)
            {
                HFatal.Action(new HLockFatal().Initialize(Filename_VALUE, new String[0], exception));
            }

            return;
        }
    }
}
