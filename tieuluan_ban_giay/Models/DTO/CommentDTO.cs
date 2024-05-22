using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tieuluan_ban_giay.Models.DTO
{
    public class CommentDTO
    {
        public int parentId { get; set; }
        public string commentText { get; set; }
        public string username { get; set; }
        public int productId { get; set; }

    }

    public class commentViewModel : CommentDTO
    {
        public int commentId { get; set; }
        public DateTime createdDate { get; set; }
        public string strcreatedDate { get {; return this.createdDate.ToString("dd-MM-yyyy"); } 
        }
    
    }
}