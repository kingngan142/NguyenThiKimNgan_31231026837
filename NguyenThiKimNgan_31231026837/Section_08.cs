using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiKimNgan_31231026837
{
    internal class Section_08
    {
        static void Main()
        {
            // Nhập chuỗi
            Console.Write("Nhap mot chuoi: ");
            string input = Console.ReadLine();

            // In ra chuỗi vừa nhập
            Console.WriteLine($"Chuoi da nhap: {input}"); 

            // Tìm độ dài chuỗi mà không dùng thư viện
            int length = 0;
            foreach (char charac in input) 
            {
                length++;
            }
            Console.WriteLine($"Do dai cua chuoi da nhap: {length}");

            // Tách các ký tự riêng biệt trong chuỗi
            Console.WriteLine("Cac ky tu rieng biet trong chuoi:");
            foreach (char charac in input)
            {
                Console.Write($"{charac}  ");
            }
            
            // In ra các ký tự trong chuỗi theo thứ tự ngược lại
            Console.WriteLine("Cac ky tu trong chuoi theo thu tu nguoc lai: ");
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]}  ");
            }

            // Đếm số lượng từ trong chuỗi
            int wordCount = 0;
            bool inWord = false;
            foreach (char c in input)
            {
                if (Char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }
            Console.WriteLine($"So luong tu trong chuoi: {wordCount}");

            // So sánh hai chuỗi mà không dùng thư viện
            Console.Write("Nhap mot chuoi khac de so sanh: ");
            string otherString = Console.ReadLine();
            bool areEqual = true;
            if (input.Length == otherString.Length)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != otherString[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            else
            {
                areEqual = false;
            }
            Console.WriteLine("Hai chuoi co bang nhau khong? " + (areEqual ? "Co" : "Khong"));

            // Đếm số lượng chữ cái, chữ số và ký tự đặc biệt
            int letterCount = 0, digitCount = 0, specialCharCount = 0;
            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                    letterCount++;
                else if (Char.IsDigit(c))
                    digitCount++;
                else
                    specialCharCount++;
            }
            Console.WriteLine("\nSo luong chu cai: " + letterCount);
            Console.WriteLine("So luong chu so: " + digitCount);
            Console.WriteLine("So luong ky tu dac biet: " + specialCharCount);

            // Đếm số lượng nguyên âm và phụ âm
            int vowelCount = 0, consonantCount = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                        vowelCount++;
                    else
                        consonantCount++;
                }
            }
            Console.WriteLine("\nSố lượng nguyên âm: " + vowelCount);
            Console.WriteLine("Số lượng phụ âm: " + consonantCount);

            // Kiểm tra chuỗi con có xuất hiện trong chuỗi không
            Console.Write("\nNhập chuỗi con để kiểm tra: ");
            string substring = Console.ReadLine();
            bool containsSubstring = input.Contains(substring);
            Console.WriteLine("Chuỗi con có xuất hiện trong chuỗi ban đầu không? " + (containsSubstring ? "Có" : "Không"));

            // Tìm vị trí của chuỗi con trong chuỗi
            int position = input.IndexOf(substring);
            if (position != -1)
                Console.WriteLine("Vị trí của chuỗi con là: " + position);
            else
                Console.WriteLine("Chuỗi con không có trong chuỗi ban đầu.");

            // Kiểm tra một ký tự có phải là chữ cái và kiểm tra chữ hoa hay thường
            Console.Write("\nNhập một ký tự để kiểm tra: ");
            char character = Console.ReadLine()[0];
            if (Char.IsLetter(character))
            {
                Console.WriteLine("Đây là một chữ cái.");
                if (Char.IsUpper(character))
                    Console.WriteLine("Chữ cái này là chữ hoa.");
                else
                    Console.WriteLine("Chữ cái này là chữ thường.");
            }
            else
            {
                Console.WriteLine("Đây không phải là một chữ cái.");
            }

            // Tìm số lần chuỗi con xuất hiện trong chuỗi
            int countSubstringOccurrences = 0;
            int currentIndex = 0;
            while ((currentIndex = input.IndexOf(substring, currentIndex)) != -1)
            {
                countSubstringOccurrences++;
                currentIndex += substring.Length;
            }
            Console.WriteLine("\nSố lần chuỗi con xuất hiện: " + countSubstringOccurrences);

            // Chèn chuỗi con trước lần xuất hiện đầu tiên của chuỗi con
            Console.Write("\nNhập chuỗi con để chèn vào trước lần xuất hiện đầu tiên: ");
            string insertSubstring = Console.ReadLine();
            int insertIndex = input.IndexOf(substring);
            if (insertIndex != -1)
            {
                string result = input.Substring(0, insertIndex) + insertSubstring + input.Substring(insertIndex);
                Console.WriteLine("Chuỗi mới sau khi chèn: " + result);
            }
            else
            {
                Console.WriteLine("Chuỗi con không có trong chuỗi ban đầu.");
            }
        }
    }

}

