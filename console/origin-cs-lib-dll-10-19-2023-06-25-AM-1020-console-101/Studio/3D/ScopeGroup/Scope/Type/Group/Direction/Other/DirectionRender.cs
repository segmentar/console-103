using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scope
    {
        public static void DirectionRender()
        {
            var result = String.Empty;

            if (MeasureWait.IsPause is true)
            {
                result = result + "pause";
            }
            else
                "false".ToString();

            var path_NAME_file = Path.GetFileName(MeasureFileArray.Filename.StringValue);

            var format = ForgeJoinfulFormat(path_NAME_file, true);

            result = result + format;

            Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}-{nameof(MeasureWait.MaterialchainArrayList)}", MeasureWait.MaterialchainArrayList.ToArray());

            Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}-{nameof(MeasureWait.ValidateMaterialchain)}", SolidDictionary(MeasureWait.ValidateMaterialchain, MeasureWait.ValidateMaterialchain.Count));

            Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}-{nameof(MeasureWait.ValidateMaterialquery)}", SolidDictionary(MeasureWait.ValidateMaterialquery, MeasureWait.ValidateMaterialquery.Count));

            return;
        }
    }
}
