using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class CategoryModel
    {
        [Key]
        public int id { get; set; }
        [Required,MinLength(4, ErrorMessage ="Yêu cầu nhập tên danh mục")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên danh mục")]

        public string Description { get; set; }
        [Required]
        public string slug { get; set; }
        public int status { get; set; }

    }
}
