using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShipMedicineFast.Models
{
    public class FeedBack
    {
        public long ID { get; set; }
        [DisplayName("Tên khách hàng phản hồi"),UIHint("NumberBox")]
        public string FullNname { get; set; } 

        [Column(TypeName = "ntext"), UIHint("EditorBox")]
        [Required(ErrorMessage ="Hãy nhập nội dung")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Nội dung ngắn")]
        [StringLength(500), UIHint("TextArea")]
        public string Description { get; set; }

        [UIHint("NumberBox"), Required()]
        public int DisplayOrder { get; set; }

        [DisplayName("Hiện thị")]
        public bool Active { get; set; }

        [DisplayName("Hiện trang chủ")]
        public bool FlagHome { get; set; }
    }
}