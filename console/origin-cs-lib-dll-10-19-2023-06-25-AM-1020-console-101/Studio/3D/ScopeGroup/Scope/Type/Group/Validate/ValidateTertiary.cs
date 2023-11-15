using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ValidateTertiary()
        {
            foreach (Materialchain materialchain in MeasureWait.MaterialchainArrayList)
            {
                foreach (Materialquery materialquery in materialchain.MaterialqueryArray)
                {
                    var position = MeasureFileArray.Text.StringValue.IndexOf(materialquery.Data.IdentityName.StringValue, MeasureFile.PhysicalOffset);

                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = position.Equals(-1) is true;

                    shouldContinueCheck = isEqualCheck is true;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    MeasureWait.ValidateMaterialquery[materialquery] = true;

                    continue;
                }

                continue;
            }

            return;
        }
    }
}
