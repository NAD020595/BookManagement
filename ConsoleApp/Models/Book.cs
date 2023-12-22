namespace ConsoleApp.Models
{
    class Book
    {
        private int _id = 1;
        private string _authors = "Unknown author";
        private string _title = "A new book";
        private string _publisher = "Unknown publisher";
        private int _year = 2023;
        private int _edition = 1;
        private int _rating = 1;
        private string _file;

        /// <summary> 
        ///  số định danh duy nhất cho mỗi object 
        /// </summary> 
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; } // id chỉ nhận giá trị >= 1
        }

        /// <summary> 
        /// tên tác giả hoặc nhóm tác giả, không nhận xâu rỗng 
        /// </summary> 
        public string Authors
        {
            get { return _authors; }
            set { if (!string.IsNullOrEmpty(value)) _authors = value; } // không nhận xâu rỗng
        }

        /// <summary>
        /// tiêu đề sách, không nhận xâu rỗng 
        /// </summary> 
        public string Title
        {
            get { return _title; }
            set { if (!string.IsNullOrEmpty(value)) _title = value; } // không nhận xâu rỗng
        }

        /// <summary> 
        /// nhà xuất bản, không nhận xâu rỗng 
        /// </summary> 
        public string Publisher
        {
            get { return _publisher; }
            set { if (!string.IsNullOrEmpty(value)) _publisher = value; } // không nhận xâu rỗng
        }

        /// <summary> 
        /// năm xuất bản, không nhỏ hơn 1950 
        /// </summary> 
        public int Year
        {
            get { return _year; }
            set { if (value >= 1950) _year = value; } // năm không nhỏ hơn 1950
        }

        /// <summary> 
        /// lần tái bản, không nhỏ hơn 1 
        /// </summary> 
        public int Edition
        {
            get { return _edition; }
            set { if (value >= 1) _edition = value; } // không nhận giá trị < 1
        }

        /// <summary>
        /// mã số quốc tế 
        /// </summary> 
        public string Isbn { get; set; } = "";

        /// <summary> 
        /// từ khóa mô tả nội dung / thể loại
        /// </summary> 
        public string Tags { get; set; } = "";

        /// <summary> 
        /// mô tả tóm tắt nội dung 
        /// </summary> 
        public string Description { get; set; } = "A new book";

        /// <summary>
        /// đánh giá cá nhân, giá trị từ 1 đến 5 
        /// </summary> 
        public int Rating
        {
            get { return _rating; }
            set { if (value >= 1 && value <= 5) _rating = value; } // giá trị từ 1 đến 5
        }

        /// <summary> 
        /// đánh dấu là đang đọc 
        /// </summary> 
        public bool Reading { get; set; }

        /// <summary> 
        /// file sách (gồm dường dẫn)
        /// </summary> 
        public string File
        {
            get { return _file; }
            set { if (System.IO.File.Exists(value)) _file = value; } // nhận đường dẫn đúng
        }

        /// <summary> 
        /// file sách (không có đường dẫn) 
        /// </summary> 
        public string FileName
        {
            get { return System.IO.Path.GetFileName(_file); } // trả lại tên file ngắn gọn
        }
    }
}