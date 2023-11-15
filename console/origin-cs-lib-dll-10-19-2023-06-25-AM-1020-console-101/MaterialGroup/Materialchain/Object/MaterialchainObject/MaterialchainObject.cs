using Core;

namespace Core
{
    using System;

    public partial class Materialchain
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialchain) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(MaterialqueryArray) + ':' + ' ' + ". . ." + ' ' + $"<{MaterialqueryArray.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Expression) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(MaterialqueryArray) + ':',
                String.Empty + String.Join('\n'.ToString(), (Object[])(MaterialqueryArray as Array)),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Expression) + ':',
                String.Empty + Expression
            });
        }
    }
}
