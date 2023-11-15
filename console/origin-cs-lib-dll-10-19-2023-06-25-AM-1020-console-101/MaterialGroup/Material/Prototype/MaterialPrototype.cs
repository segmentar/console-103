using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal Material(MaterialStringSplitcharacter headerSplitcharacterSubstring, MaterialStringSafe footerSubstring, Boolean answer_DEBUG_is)
        {
            this.HeaderSplitcharacterSubstring = headerSplitcharacterSubstring;

            this.FooterSubstring = footerSubstring;

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
