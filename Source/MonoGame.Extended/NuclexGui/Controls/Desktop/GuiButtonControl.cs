﻿using System;

namespace MonoGame.Extended.NuclexGui.Controls.Desktop
{
    public class GuiButtonControl : GuiPressableControl
    {
        /// <summary>Will be triggered when the button is pressed</summary>
        public event EventHandler Pressed;

        /// <summary>Called when the button is pressed</summary>
        protected override void OnPressed()
        {
            if (Pressed != null)
            {
                Pressed(this, EventArgs.Empty);
            }
        }

        /// <summary>Text that will be shown on the button</summary>
        public string Text;
    }
}