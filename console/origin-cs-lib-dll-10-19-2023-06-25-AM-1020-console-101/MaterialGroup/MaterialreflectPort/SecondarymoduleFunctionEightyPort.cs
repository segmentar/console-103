﻿using Core;

namespace Core
{
    using System;

    [MaterialIntentionalShortClass]
    public partial struct SecondarymoduleFunctionEightyPort
    {
        public SecondarymoduleFunctionSeventyPort Origin;

        public MaterialStringSafe InitialStringValue;

        public MaterialStringSafe SubsequentStringValue;

        public MaterialStringSafe IdentityName;

        public MaterialStringSafe VirtualName;

        public Boolean StickyLeft;

        public Boolean StickyRight;

        public Int32 Layer;

        public Int32 LeftPosition;

        public MaterialCharacterSafe LeftCharacter;

        public MaterialCharacterSafe LeftSymmetryCharacter;

        public Boolean LeftSymmetryHas;

        public Int32 RightPosition;

        public MaterialCharacterSafe RightCharacter;

        public MaterialCharacterSafe RightSymmetryCharacter;

        public Boolean RightSymmetryHas;


        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(SecondarymoduleFunctionEightyPort) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Origin) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(InitialStringValue) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(InitialStringValue) + ':' + ' ' + $"<safe><<{InitialStringValue.StringValueSafe}>>",
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(SubsequentStringValue) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(SubsequentStringValue) + ':' + ' ' + $"<safe><<{SubsequentStringValue.StringValueSafe}>>",
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(IdentityName) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "07" + ' ' + nameof(IdentityName) + ':' + ' ' + $"<safe><<{IdentityName.StringValueSafe}>>",
                    String.Empty + '\t' + '~' + "08" + ' ' + nameof(VirtualName) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "09" + ' ' + nameof(VirtualName) + ':' + ' ' + $"<safe><<{VirtualName.StringValueSafe}>>",
                    String.Empty + '\t' + '~' + "10" + ' ' + nameof(StickyLeft) + ':' + ' ' + StickyLeft,
                    String.Empty + '\t' + '~' + "11" + ' ' + nameof(StickyRight) + ':' + ' ' + StickyRight,
                    String.Empty + '\t' + '~' + "12" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                    String.Empty + '\t' + '~' + "13" + ' ' + nameof(LeftPosition) + ':' + ' ' + LeftPosition,
                    String.Empty + '\t' + '~' + "14" + ' ' + nameof(LeftCharacter) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "15" + ' ' + nameof(LeftCharacter) + ':' + ' ' + $"<safe><<{LeftCharacter.CharacterValueSafe}>>",
                    String.Empty + '\t' + '~' + "16" + ' ' + nameof(LeftSymmetryCharacter) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "17" + ' ' + nameof(LeftSymmetryCharacter) + ':' + ' ' + $"<safe><<{LeftSymmetryCharacter.CharacterValueSafe}>>",
                    String.Empty + '\t' + '~' + "18" + ' ' + nameof(RightPosition) + ':' + ' ' + RightPosition,
                    String.Empty + '\t' + '~' + "19" + ' ' + nameof(RightCharacter) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "20" + ' ' + nameof(RightCharacter) + ':' + ' ' + $"<safe><<{RightCharacter.CharacterValueSafe}>>",
                    String.Empty + '\t' + '~' + "21" + ' ' + nameof(RightSymmetryCharacter) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "22" + ' ' + nameof(RightSymmetryCharacter) + ':' + ' ' + $"<safe><<{RightSymmetryCharacter.CharacterValueSafe}>>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(Origin) + ':',
                    String.Empty + Origin,
                });
        }
    }
}
