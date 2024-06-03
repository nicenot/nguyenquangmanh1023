using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NQMBaiDanhGiaGiuaKy.Models
{
    public class NQMProduct
    {
        [Key]
        public int NQMId { get; set; }
        [DisplayName("NQM:Họ và Tên")]
        [Required(ErrorMessage = "NQM: Chưa nhập dữ liệu")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "NQM:Họ tên chứa tối thiểu 5 kí tự hoặc tối đa 100")]
        [RegularExpression(@"^[A-Za-z ]{5,100}$", ErrorMessage = "Họ tên chỉ chứa ký tự viết hoa và khoảng trắng")]
        public string NQMFullName { get; set; }
        [DisplayName("NQM:Ảnh")]
        [Required(ErrorMessage = "NQM: Chưa nhập dữ liệu")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Đth:Đây không phải là URL hình ảnh hợp lệ")]
        public string NQMImage { get; set; }
        [DisplayName("NQM:Số lượng")]
        [Required(ErrorMessage = "NQM: Chưa nhập dữ liệu")]
        [Range(1, 100, ErrorMessage = "NQM:Số lượng phải là số trong khoảng 1-100.")]
        public int NQMQuantity { get; set; }
        [DisplayName("NQM:Giá")]
        [Range(0.01, double.MaxValue, ErrorMessage = "NQM:Giá phải là số lớn hơn 0.")]
        [Required(ErrorMessage = "NQM: Chưa nhập dữ liệu")]

        public decimal NQMPrice { get; set; }
        [DisplayName("NQM:Trạng thái")]
        
        
        public bool NQMIsActive { get; set; } = true;
    }
}