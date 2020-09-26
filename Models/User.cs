using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime ModifiedTs { get; set; }
        public short? IsDeleted { get; set; }
        public string Email { get; set; }
    }
}
