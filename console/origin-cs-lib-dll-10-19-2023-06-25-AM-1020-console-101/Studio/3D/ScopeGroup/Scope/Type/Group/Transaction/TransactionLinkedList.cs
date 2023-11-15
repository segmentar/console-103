using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void TransactionLinkedList(String Onefirst_VALUE, String Twosecond_VALUE, String Threethird_VALUE, String Fourfourth_VALUE, String Fivefifth_VALUE, String Sixsixth_VALUE)
        {
            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[0] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Onefirst_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[1] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Twosecond_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[2] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Threethird_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[3] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Fourfourth_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[4] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Fivefifth_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[5] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Sixsixth_VALUE;

            var array = new String[6];

            array[0] = Onefirst_VALUE;

            array[1] = Twosecond_VALUE;

            array[2] = Threethird_VALUE;

            array[3] = Fourfourth_VALUE;

            array[4] = Fivefifth_VALUE;

            array[5] = Sixsixth_VALUE;

            ScopeTransaction scopeTransaction;

            scopeTransaction = new ScopeTransaction(MeasureFileArray.Filename.StringValue, array);

            AdvanceLinkedList(scopeTransaction);

            return;
        }
    }
}
