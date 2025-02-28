﻿using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Thương hiệu")]

        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả Thương hiệu")]

        public string Description { get; set; }
        public string slug { get; set; }
        public int status { get; set; }
    }
}
