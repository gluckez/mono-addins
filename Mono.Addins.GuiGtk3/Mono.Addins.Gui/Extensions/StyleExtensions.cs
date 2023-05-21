//
// StyleExtensions.cs
//
// Author:
//       glenn <>
//
// Copyright (c) 2023 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using Cairo;
using Gtk;
namespace Extensions
{
	public static class StyleExtensions
	{
		/// This is only here to support obsolete api's, for now.
		public static void PaintFocus(this Style style, Style st, Cairo.Context cr, StateType type, Widget wdg, string str, double x, double y, int width, int height)
		{
			wdg.StyleContext.RenderFocus (cr, x, y, width, height);
		}

		/// This is only here to support obsolete api's, for now.
		public static Gdk.RGBA Base (this Style style, StateType stateType)
		{
			return style.Context.GetColor (stateType.ToStateFlags ());
		}

		/// This is only here to support obsolete api's, for now.
		public static Gdk.RGBA BackGround (this Style style, StateType type)
		{
			return style.Context.GetColor(type.ToStateFlags());
		}

		public static StateFlags ToStateFlags(this StateType type)
		{
			switch (type) {
				case StateType.Normal: return StateFlags.Normal;
				default: return StateFlags.Normal;
			}
		}

		public static Gdk.RGBA ToRGBA(this Gdk.Color color)
		{
			return new Gdk.RGBA () {
				Red = color.Red,
				Green = color.Green,
				Blue = color.Blue
			};

		}
	}
}
