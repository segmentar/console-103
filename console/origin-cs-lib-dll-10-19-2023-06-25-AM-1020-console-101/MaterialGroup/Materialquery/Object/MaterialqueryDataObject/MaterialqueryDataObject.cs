using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryData
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(MaterialqueryData) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "data",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Measure) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Runtime) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(InitialStringValue) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(InitialStringValue) + ':' + ' ' + $"<safe><<{InitialStringValue.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(SubsequentStringValue) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(SubsequentStringValue) + ':' + ' ' + $"<safe><<{SubsequentStringValue.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(IdentityName) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(IdentityName) + ':' + ' ' + $"<safe><<{IdentityName.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(VirtualName) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(VirtualName) + ':' + ' ' + $"<safe><<{VirtualName.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(StickyLeft) + ':' + ' ' + StickyLeft,
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(StickyRight) + ':' + ' ' + StickyRight,
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "14" + ' ' + nameof(LeftPosition) + ':' + ' ' + LeftPosition,
                String.Empty + '\t' + '~' + "15" + ' ' + nameof(LeftCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "16" + ' ' + nameof(LeftCharacter) + ':' + ' ' + $"<safe><<{LeftCharacter.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "17" + ' ' + nameof(LeftSymmetryCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "18" + ' ' + nameof(LeftSymmetryCharacter) + ':' + ' ' + $"<safe><<{LeftSymmetryCharacter.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "19" + ' ' + nameof(RightPosition) + ':' + ' ' + RightPosition,
                String.Empty + '\t' + '~' + "20" + ' ' + nameof(RightCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "21" + ' ' + nameof(RightCharacter) + ':' + ' ' + $"<safe><<{RightCharacter.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "22" + ' ' + nameof(RightSymmetryCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "23" + ' ' + nameof(RightSymmetryCharacter) + ':' + ' ' + $"<safe><<{RightSymmetryCharacter.CharacterValueSafe}>>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Measure) + ':',
                String.Empty + Measure,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Runtime) + ':',
                String.Empty + Runtime
            });
        }
    }
}
