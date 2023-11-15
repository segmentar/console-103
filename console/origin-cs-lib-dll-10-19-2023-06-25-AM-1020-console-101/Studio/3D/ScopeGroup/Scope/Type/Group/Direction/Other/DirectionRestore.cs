using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionRestore(Boolean answer_UNPAUSE_should)
        {
            MeasureWait = Template.MeasureWait;

            MeasureFileArray = Template.MeasureFileArray;

            MeasureFile = Template.MeasureFile;

            MeasureFlag = Template.MeasureFlag;

            MeasureValue = Template.MeasureValue;

            MeasureQuery = Template.MeasureQuery;

            if (answer_UNPAUSE_should is true)
            {
                MeasureWait.IsPause = false;
            }
            else
                "false".ToString();

            return;
        }
    }
}
