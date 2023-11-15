using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ValidateSecondary()
        {
            foreach (Materialchain materialchain in MeasureWait.MaterialchainArrayList)
            {
                MeasureWait.ValidateMaterialchain.Add(materialchain, false);

                continue;
            }

            foreach (Materialchain materialchain in MeasureWait.MaterialchainArrayList)
            {
                foreach (Materialquery materialquery in materialchain.MaterialqueryArray)
                {
                    MeasureWait.ValidateMaterialquery.Add(materialquery, false);

                    continue;
                }

                continue;
            }

            return;
        }
    }
}
