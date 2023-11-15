using Core;

namespace Core
{
    using System;

    public partial class MaterialqueryCode
    {
        public enum QueryType
        {
            Unset,
            Require,
            Optional,
            Any,
            Some,
            Separate,
            Sequence,
            Sentence,
            Paragraph
        }
    }
}
