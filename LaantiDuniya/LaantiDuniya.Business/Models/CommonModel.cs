using System;
using System.Collections.Generic;
using System.Text;

namespace LaantiDuniya.Business
{
    public class CommonModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
