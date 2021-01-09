using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterPages.Model
{
    interface VerificationResponse
    {
        public void OnWaVerificationSucceed(object source, EventArgs e);
        public void OnEmailVerificationSucceed(object source, EventArgs e);
    }
}
