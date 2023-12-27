using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Views
{
    /// <summary>
    /// class để thêm một cuốn sách mới
    /// </summary>
    internal class BookCreateView
    {
        public BookCreateView()
        {

        }

        /// <summary>
        /// yêu cầu người dùng nhập từng thông tin và lưu lại thông tin đó
        /// </summary>
        public void Render()
        {
            WriteLine("CREATE A NEW BOOK", ConsoleColor.Green);
            var title = InputString("Title"); // đọc vào biến title
            var authors = InputString("Authors"); // đọc vào biến authors
            var publisher = InputString("Publisher"); // đọc vào biến publisher
            var year = InputInt("Year");
            var edition = InputInt("Edition");
            var tags = InputString("Tags");
            var description = InputString("Description");
            var rate = InputInt("Rate");
            var reading = InputBool("Reading");
            var file = InputString("File");
        }

        /// <summary>
        /// In ra thông báo và tiếp nhận chuỗi ký tự người dùng nhập
        /// </summary>
        /// <param name="lable">dòng thông báo</param>
        /// <param name="lableColor">màu chữ thông báo</param>
        /// <param name="valueColor">màu chữ người dùng nhập</param>
        /// <returns></returns>
        private string InputString(string lable, ConsoleColor lableColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{lable}: ", lableColor, false);
            Console.ForegroundColor = valueColor;
            string value = Console.ReadLine();
            Console.ResetColor();
            return value;
        }

        /// <summary>
        /// In ra thông báo và tiếp nhận chuỗi ký tự người dùng nhập rồi chuyển sang số nguyên
        /// </summary>
        /// <param name="lable">dòng thông báo</param>
        /// <param name="lableColor">màu chữ thông báo</param>
        /// <param name="valueColor">màu chữ người dùng nhập</param>
        /// <returns></returns>
        private int InputInt(string lable, ConsoleColor lableColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            while (true)
            {
                var str = InputString(lable, lableColor, valueColor);
                var result = int.TryParse(str, out int i);
                if (result == true)
                {
                    return i;
                }
            }
        }

        /// <summary>
        /// In ra thông báo và tiếp nhận chuỗi ký tự người dùng nhập rồi chuyển sang kiểu bool
        /// </summary>
        /// <param name="lable">dòng thông báo</param>
        /// <param name="lableColor">màu chữ thông báo</param>
        /// <param name="valueColor">màu chữ người dùng nhập</param>
        /// <returns></returns>
        private bool InputBool(string lable, ConsoleColor lableColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{lable} [y/n]: ", lableColor); 
            ConsoleKeyInfo key = Console.ReadKey(); // đọc 1 ký tự vào biến key
            Console.WriteLine();
            bool @char = key.KeyChar == 'y' || key.KeyChar == 'Y' ? true : false; // chuyển sang kiểu bool dùng biểu thức điều kiện
            return @char;
        }

        /// <summary>
        /// Xuất thông tin ra console với màu sắc (Writeline có màu)
        /// </summary>
        /// <param name="message">thông tin cần xuất</param>
        /// <param name="color">màu chữ</param>
        /// <param name="resetColor">có trả lại màu sắc mặc định hay không</param>
        private void WriteLine(string message, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if (resetColor)
                Console.ResetColor();
        }

        /// <summary>
        /// Xuất thông tin ra console với màu sắc (Write có màu)
        /// </summary>
        /// <param name="message">thông tin cần xuất</param>
        /// <param name="color">màu chữ</param>
        /// <param name="resetColor">có trả lại màu sắc mặc định hay không</param>
        private void Write(string message, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            if (resetColor)
                Console.ResetColor();
        }
    }
}
