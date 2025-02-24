using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class BrandModel
    {
        [Key]
        public int id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên Thương hiệu")]

        public string name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả Thương hiệu")]

        public string Description { get; set; }
        public string slug { get; set; }
        public int status { get; set; }
    }
}
