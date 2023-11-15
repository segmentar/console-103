using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryMeasure
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialquery) + ' ' + "::" + ' ' + nameof(MaterialqueryMeasure) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Parent) + ':' + ' ' + ". . ." + ' ' + $"<{Parent == default}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ChildArray) + ':' + ' ' + ". . ." + ' ' + $"<{ChildArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Parent) + ':',
                String.Empty + "<cannot-display>",//Parent,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ChildArray) + ':',
                String.Empty + "<cannot-display>"//String.Join('\n'.ToString(), (Object[])(ChildArray as Array))
            });
        }
    }
}
