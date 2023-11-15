using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scope
    {
        public static void Frame()
        {
            while (true)
            {
                if (MeasureWait.IsPause is false)
                {
                    break;
                }
                else
                    "false".ToString();

                continue;
            }

            TransactionLinkedList(MeasureWait.ToString(), MeasureFileArray.ToString(), MeasureFile.ToString(), MeasureFlag.ToString(), MeasureValue.ToString(), MeasureQuery.ToString());

            Thread.Sleep(MeasureWait.SecondaryWait);

            return;
        }
    }
}
