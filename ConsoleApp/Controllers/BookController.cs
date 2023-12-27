﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Controllers
{
    using ConsoleApp.Views;
    using Models; //lưu ý cách dùng using với không gian tên con using Views; 

    /// <summary> 
    /// lớp điều khiển, giúp ghép nối dữ liệu sách với giao diện
    /// </summary> 
    class BookController
    {
        /// <summary> 
        /// ghép nối dữ liệu 1 cuốn sách với giao diện hiển thị 1 cuốn sách 
        /// </summary> 
        /// <param name="id">mã định danh của cuốn sách</param> 
        public void Single(int id)
        {
            Book model = new Book
            {
                Id = 1,
                Authors = "Adam Freeman",
                Title = "Expert ASP.NET Web API 2 for MVC Developers (The Expert's Voice in .NET)",
                Publisher = "Apress",
                Year = 2014,
                Tags = "c#, asp.net, mvc",
                Description = "Expert insight and understanding of how to create, customize, and deploy complex, flexible, and robust HTTP web services",
                Rating = 5,
                Reading = true
            };

            BookSingleView view = new BookSingleView(model);// khởi tạo view
            view.Render(); // gọi phương thức Render để thực sự hiển thị ra màn hình
        }

        public void Create()
        {
            BookCreateView view = new BookCreateView(); // khởi tạo object 
            view.Render(); // hiển thị ra màn hình
        }
    }
}
