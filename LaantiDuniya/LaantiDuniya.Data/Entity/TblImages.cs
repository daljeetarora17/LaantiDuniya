using System;
using System.Collections.Generic;

namespace LaantiDuniya.Data.Entity
{
    public partial class TblImages
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string ImagePath { get; set; }
    }
}
