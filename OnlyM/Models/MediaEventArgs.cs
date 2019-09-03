﻿namespace OnlyM.Models
{
    using System;
    using OnlyM.Core.Models;

    public class MediaEventArgs : EventArgs
    {
        public Guid MediaItemId { get; set; }

        public MediaClassification Classification { get; set; }

        public MediaChange Change { get; set; }
    }
}
