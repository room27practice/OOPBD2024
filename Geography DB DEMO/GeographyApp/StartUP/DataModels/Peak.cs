﻿using System;
using System.Collections.Generic;

namespace StartUP.DataModels
{
    public partial class Peak
    {
        public int Id { get; set; }
        public string PeakName { get; set; } = null!;
        public int Elevation { get; set; }
        public int MountainId { get; set; }

        public virtual Mountain Mountain { get; set; } = null!;
    }
}
