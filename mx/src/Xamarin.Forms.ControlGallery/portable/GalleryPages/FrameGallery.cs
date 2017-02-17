﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.Controls
{
	public class FrameGallery : ContentPage
	{
		readonly StackLayout _stack;

		public FrameGallery ()
		{
			Content = _stack = new StackLayout { Padding = new Size (20, 20) };

			//BackgroundColor = new Color (0.5, 0.5, 0.5);
			BackgroundColor = Color.FromHex ("#8a2be2");
			//BackgroundColor = Color.Aqua;

			var frame = new Frame {
				Content = new Button {
					Text = "Framous!"
				},
				BackgroundColor = Device.OnPlatform (iOS: new Color (1), Android: new Color (0), WinPhone: new Color (0)),
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			_stack.Children.Add (frame);
		}
	}
}