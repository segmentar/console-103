using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void LoopFile()
        {
            try
            {
                do
                {
                    EndOfFileCheck();

                    if (MeasureFlag.EndOfFileFlag is true)
                    {
                        EndOfFileSync();

                        break;
                    }
                    else
                        "false".ToString();

                    GetVirtualOffset();

                    GetLineNumber();

                    GetCharacter();

                    GetProofCharacter();

                    GetLine();

                    ValidatePrimary();

                    ValidateSecondary();

                    ValidateTertiary();

                    ValidateQuaternary();

                    FilePrimaryIteration();

                    Frame();

                    if (MeasureFlag.MaterialValidateFlag is true)
                    {
                        MaterialValidateSync();

                        MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset + MeasureFile.Line.StringValue.Length;

                        var Entity_COMMA = Convert.ToChar(44);

                        var HeaderSubstringSplitcharacter___VALUE = MaterialStringSplitcharacter.Simple(MeasureValue.MaterialHeaderSubstring.StringValue, Entity_COMMA);

                        var FooterSubstringSafe___VALUE = MeasureValue.MaterialFooterSubstring.StringValue;

                        MaterialModule materialModule;

                        Material.Manual(HeaderSubstringSplitcharacter___VALUE, FooterSubstringSafe___VALUE, out materialModule);

                        MeasureQuery.ElementArrayList.Add(materialModule.Material);
                    }
                    else
                        "false".ToString();

                    FileSecondaryIteration();

                    AdvancePhysicalOffset();

                    continue;

                } while (true);

            } catch (Exception exception)
            {
                ScopeFatal.Action(new ScopeFatalLoopFile().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
