using System;
using System.Collections.Generic;
using System.Text;

namespace NTI.iMeter.ComponentStandard.UI
{
    /// <summary>
    /// UI Size
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Gets or sets height value.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets wight value.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Initializes a new instance of the Size.
        /// </summary>
        /// <param name="height">Height</param>
        /// <param name="width">Width</param>
        public Size(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
