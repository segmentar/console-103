using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureWait
    {
        [ScopeIntentionalShortMethod]
        [ScopeIntentionalLineEndingMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureWait) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsRunning) + ':' + ' ' + IsRunning,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsPause) + ':' + ' ' + IsPause,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ShouldGUI) + ':' + ' ' + ShouldGUI,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(PrimaryWait) + ':' + ' ' + PrimaryWait,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(SecondaryWait) + ':' + ' ' + SecondaryWait,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(LinkedList) + ':' + ' ' + "<hidden>" + ' ' + $"<{LinkedList.Count}>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(LinkedListPointer) + ':' + ' ' + LinkedListPointer,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(MaterialchainArrayList) + ':' + ' ' + "<too-large>" + ' ' + $"<{MaterialchainArrayList.Count}>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(ValidateMaterialchain) + ':' + ' ' + "<too-large>" + ' ' + $"<{ValidateMaterialchain.Count}>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(ValidateMaterialquery) + ':' + ' ' + "<too-large>" + ' ' + $"<{ValidateMaterialquery.Count}>",
                String.Empty + '}'
            });
        }
    }
}
