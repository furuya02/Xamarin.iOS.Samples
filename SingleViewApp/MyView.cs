using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace SingleViewApp {
    partial class MyView : UIView {
        public MyView(IntPtr handle) : base(handle) {
        }

        public override void Draw(CGRect rect) {
            base.Draw(rect);
            var str = new NSString("Developers.IO");
            str.DrawString(new CGPoint(75, 60), UIFont.FromName("HiraKakuProN-W3", 24f));
        }

    }
}