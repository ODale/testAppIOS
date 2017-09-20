using System;
using CoreGraphics;

using UIKit;

namespace testAppIOS
{
    public partial class MyViewController : UIViewController
    {
        public MyViewController() : base("MyViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.View.BackgroundColor = UIColor.Yellow;

            var nameFieldTxt = new UITextField()
            {
                Frame = new CGRect(20, 28, View.Bounds.Width - 40, 35),
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Your Name Here",
            };

            View.Add(nameFieldTxt);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

