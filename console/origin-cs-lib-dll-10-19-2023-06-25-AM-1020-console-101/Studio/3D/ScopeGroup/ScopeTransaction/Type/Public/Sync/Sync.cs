using Core;

namespace Core
{
    using System;

    public partial class ScopeTransaction
    {
        public void Sync()
        {
            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[0] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = WindowArray[0];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[1] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = WindowArray[1];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[2] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = WindowArray[2];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[3] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = WindowArray[3];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[4] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = WindowArray[4];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[5] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = WindowArray[5];

            return;
        }
    }
}
