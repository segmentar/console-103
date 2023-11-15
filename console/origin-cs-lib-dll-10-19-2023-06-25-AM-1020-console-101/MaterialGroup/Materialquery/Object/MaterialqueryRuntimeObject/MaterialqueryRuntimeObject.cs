using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Materialquery) + ' ' + "::" + ' ' + nameof(MaterialqueryRuntime) + ' ' + '{',
                String.Empty + '.' + "runtime",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(QueryType) + ':' + ' ' + QueryType,
                String.Empty + '}'
            });
        }
    }
}
