﻿using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        [Required( ErrorMessage = "Yêu cầu nhập Tên Thương hiệu")]

        public string Name { get; set; }
        [Required( ErrorMessage = "Yêu cầu nhập mô tả Thương hiệu")]

        public string Description { get; set; } 
        public string Slug { get; set; }
        public int Status { get; set; }
    }
}
