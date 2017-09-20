using System;
using UIKit;
using CoreGraphics;

namespace testAppIOS
{
    public class MyViewController : UIViewController
    {
        public MyViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Black;

			//create a text field control with the specified properties
			var totalAmount = new UITextField()
			{
				Frame = new CGRect(20, 28, View.Bounds.Width - 40, 35),
				KeyboardType = UIKeyboardType.DecimalPad,
				BorderStyle = UITextBorderStyle.RoundedRect,
				Placeholder = "Enter Total Amount",
			};

			//create a button control with the specified properties
			var calcButton = new UIButton(UIButtonType.Custom)
			{
				Frame = new CGRect(20, 71, View.Bounds.Width - 40, 45),
				BackgroundColor = UIColor.FromRGB(0, 0, 0.2f),
			};
			calcButton.SetTitle("Calculate", UIControlState.Normal);

			//create lable control with the specified properties
			var resultLabel = new UILabel(new CGRect(20, 124, View.Bounds.Width - 40, 40))
			{
				TextColor = UIColor.Blue,
				TextAlignment = UITextAlignment.Center,
				Font = UIFont.SystemFontOfSize(24),
				Text = "Tip is $0.00",
			};

			//add all the child views (controls defined about) to screen (root view)
			View.AddSubviews(totalAmount, calcButton, resultLabel);

			//add touch event handler, anonymous delegate method
			calcButton.TouchUpInside += delegate (object sender, EventArgs e)
			{
				//review first responder*
				totalAmount.ResignFirstResponder();
				//get the amount entered by the user
				Double.TryParse(totalAmount.Text, out double amount);
				//calcualte and display the tip
				resultLabel.Text = string.Format("Tip is {0:C}", amount * 0.15);
			};

		}
    }
}
