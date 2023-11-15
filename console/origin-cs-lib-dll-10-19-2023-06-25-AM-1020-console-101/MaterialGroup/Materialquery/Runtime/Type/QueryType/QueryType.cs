using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void QueryTypeRuntime(Char Left_CHARACTER, Char Right_CHARACTER)
        {
            var Entity_BOTH = String.Concat(Left_CHARACTER, Right_CHARACTER);

            switch (Entity_BOTH)
            {
                case "()":
                    QueryType = MaterialqueryCode.QueryType.Require;
                    break;

                case "[]":
                    QueryType = MaterialqueryCode.QueryType.Optional;
                    break;

                default:
                    QueryType = MaterialqueryCode.QueryType.Unset;
                    break;
            }

            return;
        }
    }
}
