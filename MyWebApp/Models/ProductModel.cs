using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class ProductModel
    {
        [Key]
        public int id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên Sản phẩm")]

        public string Name { get; set; }

        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả sản phẩm")]


        public string Decription { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập giá sản phẩm")]

        public decimal Price { get; set; }
        public int Brandid { get; set; }
        public int Categoryid { get; set; }

        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }


    }
}
