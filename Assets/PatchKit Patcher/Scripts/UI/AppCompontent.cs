﻿using System.Threading;

namespace PatchKit.Patching.Unity.UI
{
    public abstract class AppCompontent : UIApiComponent
    {
        public string AppSecret;

        public CancellationToken CancellationToken {
            get {
                return Patcher.Instance.ThreadCancellationToken;
            }
        }
    }
}
