using Core;

namespace Core
{
    using System;

    public partial class Materialquery
    {
        public Materialquery(MaterialqueryMeasure measure, MaterialqueryData data)
        {
            MaterialqueryRuntime runtime;

            runtime = new MaterialqueryRuntime();

            runtime.QueryTypeRuntime(data.LeftCharacter.CharacterValue, data.RightCharacter.CharacterValue);

            data.Measure = measure;

            data.Runtime = runtime;

            this.Data = data;

            return;
        }

        public Materialquery
(
MaterialqueryMeasure measure,
MaterialStringSafe initialStringValue,
MaterialStringSafe subsequentStringValue,
MaterialStringSafe identityName,
MaterialStringSafe virtualName,
Boolean stickyLeft,
Boolean stickyRight,
Int32 layer,
Int32 leftPosition,
MaterialCharacterSafe leftCharacter,
MaterialCharacterSafe leftSymmetryCharacter,
Boolean leftSymmetryHas,
Int32 rightPosition,
MaterialCharacterSafe rightCharacter,
MaterialCharacterSafe rightSymmetryCharacter,
Boolean rightSymmetryHas
)
        {
            MaterialqueryData data;

            data = new MaterialqueryData();

            data.InitialStringValue = initialStringValue;

            data.SubsequentStringValue = subsequentStringValue;

            data.IdentityName = identityName;

            data.VirtualName = virtualName;

            data.StickyLeft = stickyLeft;

            data.StickyRight = stickyRight;

            data.Layer = layer;

            data.LeftPosition = leftPosition;

            data.LeftCharacter = leftCharacter;

            data.LeftSymmetryCharacter = leftSymmetryCharacter;

            data.LeftSymmetryHas = leftSymmetryHas;

            data.RightPosition = rightPosition;

            data.RightCharacter = rightCharacter;

            data.RightSymmetryCharacter = rightSymmetryCharacter;

            data.RightSymmetryHas = rightSymmetryHas;

            Materialquery materialquery;

            materialquery = new Materialquery(measure, data);

            this.Data = materialquery.Data;

            return;
        }
    }
}
