using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLychiTieu
{
    internal class MD5Hash
    {
        public string EncryptionMD5Hash(string input)
        {
            // Tạo một đối tượng MD5 mới từ System.Security.Cryptography
            MD5 md5 = System.Security.Cryptography.MD5.Create();

            // Chuyển đổi chuỗi đầu vào thành mảng byte và tính toán băm
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Tạo một StringBuilder mới để thu thập các byte
            // và tạo một chuỗi.
            StringBuilder sb = new StringBuilder();

            // Lặp qua mỗi byte của dữ liệu băm
            // và định dạng từng byte dưới dạng chuỗi thập lục phân
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            // Trả về chuỗi thập lục phân
            return sb.ToString();
        }
    }
}
