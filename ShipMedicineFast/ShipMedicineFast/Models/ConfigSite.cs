using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShipMedicineFast.Models
{
    public class ConfigSite
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự"), Display(Name = "Đường dẫn Facebook"), Url(ErrorMessage = "Đường dẫn không chính xác"), UIHint("TextBox")]
        public string Facebook { get; set; } 

        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự"), Display(Name = "Đường dẫn Youtube"), Url(ErrorMessage = "Đường dẫn không chính xác"), UIHint("TextBox")]
        public string Youtube { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự"), Display(Name = "Đường dẫn Instagram"), Url(ErrorMessage = "Đường dẫn không chính xác"), UIHint("TextBox")]
        public string Instagram { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự"), Display(Name = "Đường dẫn Telegram"), Url(ErrorMessage = "Đường dẫn không chính xác"), UIHint("TextBox")]
        public string Twitter { get; set; }

        [Display(Name = "Mã nhúng Bản đồ Google map"), StringLength(4000, ErrorMessage = "Tối đa 4000 ký tự"), UIHint("TextArea")]
        public string FacebookPage { get; set; }

        [Display(Name = "Tiêu đề đầu trang"), StringLength(200, ErrorMessage = "Tối đa 200 ký tự"), UIHint("TextBox")]
        public string TitleHeader { get; set; }

        [Display(Name = "Địa chỉ"), StringLength(500, ErrorMessage = "Tối đa 500 ký tự"), UIHint("TextArea")]
        public string Address { get; set; }

        [Display(Name = "Số điện thoại"), StringLength(15, ErrorMessage = "Tối đa 15s ký tự"), UIHint("TextBox")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email"), EmailAddress(ErrorMessage = "Email không hợp lệ"), StringLength(100, ErrorMessage = "Tối đa 100 ký tự"), UIHint("TextBox")]
        public string Email { get; set; }

        [Display(Name = "Hình ảnh"), StringLength(500, ErrorMessage = "Tối đa 500 ký tự")]
        public string Logo { get; set; }

        [Display(Name = "Chính sách bảo mật"),Column(TypeName ="ntext"), UIHint("TextBox")]
        public string PrivacyPolicy { get; set; }

        [Display(Name = "Thông tin giới thiệu"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string About { get; set; }

        [Display(Name = "Điều khoản và dịch vụ"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string Services { get; set; }

        [Display(Name = "Hướng dẫn thanh toán"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string Payment { get; set; } 

        [Display(Name = "Liên hệ"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string Contact { get; set; }

        [Display(Name = "Giúp đỡ và tư vấn"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string Helper { get; set; }

        [Display(Name = "Vận chuyển và trả hàng"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string  Transport { get; set; }

        [Display(Name = "Các điều kiện và điều khoản"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string Conditions { get; set; }

        [Display(Name = "Chính sách hoàn tiền"), Column(TypeName = "ntext"), UIHint("TextBox")]
        public string RefundPolicy { get; set; }

        public bool Active { get; set; }
    }
}