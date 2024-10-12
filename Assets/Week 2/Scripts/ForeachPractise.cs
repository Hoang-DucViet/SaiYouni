using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 1 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int i in arr)
        {
           Debug.Log(i);
        }

    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 2 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;

        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        foreach(int i in arr)
        {
            sum += i;
        }

        Debug.Log($"Tong cac phan tu trong mang: {sum}");
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 3 ---");

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int max = arr[0];
        
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        foreach(int i in arr)
        {
            if (i > max) 
                max = i;
        }

        Debug.Log($"Gia tri lon nhat: {max}");
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 4 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int count = 0;

        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        foreach (int i in arr)
        {
            if (i % 2 == 0)
                count++;
        }

        Debug.Log($"So luong so chan trong mang: {count}");
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("--- Bai tap 5 ---");
        List<string> listString = new List<string>();
        listString.Add("Cam");
        listString.Add("Quyt");
        listString.Add("Mit");
        listString.Add("Dua");

        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach (string str in listString)
        {
            Debug.Log(str);
        }

    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("--- Bai tap 6 ---");
        List<string> listString = new List<string>();
        listString.Add("Oi");
        listString.Add("Thanh Long");
        listString.Add("Mit");
        listString.Add("Dua");

        int index = 0;
        int lengthMax = listString[index].Length;

        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        foreach (string str in listString)
        {
            if ( str.Length > lengthMax)
            {
                lengthMax = str.Length;
                index = listString.IndexOf(str);
            }               
        }

        Debug.Log($"Phan tu dai nhat la {listString[index]} co {lengthMax} ki tu, o vi tri {index}");
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 7 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;

        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        foreach (int i in arr)
        {
            if ((i % 2) != 0)
                sum += i;
        }

        Debug.Log($"Tong cac so le trong mang: {sum}");
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 8 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach (int i in arr)
        {
            if ((i % 2) == 0)
                Debug.Log(i);
        }

    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        Debug.Log("--- Bai tap 9 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13 };
        int valueCheck = 13;
        bool isExist = false;

        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach (int i in arr)
        {
            if (i == valueCheck)
            {
                isExist = true;
                break;
            }
        }

        if (isExist)
            Debug.Log($"{valueCheck} co xuat hien trong mang");
        else
            Debug.Log($"{valueCheck} khong co trong mang");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 10 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -13 };
        int count = 0;

        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        foreach (int i in arr)
        {
            if (i < 0)
            {
                count++;
            }
        }

        if (count == 0)
            Debug.Log("Mang khong co so am");
        else
            Debug.Log($"Mang co {count} so am");
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 11 ---");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        bool isExist = false;

        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach (int i in arr)
        {
            if (i > 10)
            {
                Debug.Log(i);
                isExist = true;
            }
        }

        if (!isExist)
            Debug.Log("Mang khong co so so lon hon 10");     
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("--- Bai tap 12 ---");
        List<string> listString = new List<string>();
        
        listString.Add("Thanh Long");
        listString.Add("Mit");
        listString.Add("Oi");
        listString.Add("Dua");

        int index = 0;
        int lengthMin = listString[index].Length;
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách

        foreach (string str in listString)
        {
            if (str.Length < lengthMin)
            {
                lengthMin = str.Length;
                index = listString.IndexOf(str);
            }              
        }

        Debug.Log($"Phan tu ngan nhat la {listString[index]} co {lengthMin} ki tu, o vi tri {index}");
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 13 ---");
        int [] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int index = 0;
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        foreach (int i in arr)
        {
            arr[index] = i * 2;
            index++;
        }

        foreach (int i in arr)
            Debug.Log(i);
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 14 ---");
        int[] arr = { 12, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int max = arr[0];
        int totalMax = max;
        int maxSecond = 0;

        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        foreach (int i in arr)
        {
            if (i > max)
                max = i;
        }

        foreach(int i in arr)
        {
            if (totalMax < (max + i) && (max + i) != (max * 2))
            {
                totalMax = max + i;
                maxSecond = i;
            }
                
        }

        Debug.Log(maxSecond);
        
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("--- Bai tap 15 ---");
        List<string> listString = new List<string>();
        listString.Add("An nhan");
        listString.Add("An toan");
        listString.Add("An nhien");
        listString.Add("Binh An");
        listString.Add("Bao An");

        bool checkExist = false;

        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'

        foreach (string str in listString)
        {
            if (str.StartsWith("A"))
            {
                Debug.Log(str);
                checkExist = true;
            }
                
        }

        if (!checkExist)
        {
            Debug.Log("Danh sach khong co chuoi bat dau bang A");
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("--- Bai tap 16 ---");
        List<string> listString = new List<string>();
        listString.Add("Hello world");
        listString.Add("Code hello___ world");
        listString.Add("hEllO");

        bool checkExist = false;
        string searchString = "Hello";

        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        // Tìm kiếm không phân biệt Hoa thường 
        foreach (string str in listString)
        {
           if (str.ToLower().Contains(searchString.ToLower()))
            {
                Debug.Log(str);
                checkExist = true;
            }  
        }

        if (!checkExist)
            Debug.Log("Danh sach khong co chuoi chua chuoi Hello");

    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 17 ---");
        int[] number = { 1, -2, 3, 4, -5, 6, 7 };
        int count = 0;
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng

        foreach (int i in number)
        {
            if (i < 0)
            {
                Debug.Log(i);
                count++;
            }
        }

        if (count == 0)
            Debug.Log("Mang khong co gia tri am");
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        Debug.Log("--- Bai tap 18 ---");
        int element = 3;
        int[] numberArray = { 1, 3, 4, 5, 6, 3, 7 };
        int count = 0;

        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        foreach (int i in numberArray)
        {
            if(i == element)
                count++;
        }

        if (count == 0)
            Debug.Log($"Phan tu {element} khong xuat hien trong mang");
        else
            Debug.Log(($"Phan tu {element} xuat hien {count} lan trong mang"));
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        Debug.Log("--- Bai tap 19 ---");
        int[] numberArray = { 10, 13, 2, 41, 5, 6, 77, 56, 3, 9, 1 };
        List<int> numberList = new List<int>();

        //Debug.Log(numberList.Count);

        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        foreach (int i in numberArray)
        {
            if (i > 10)
                numberList.Add(i);
        }

        if (numberList.Count == 0)
            Debug.Log("mang khong co gia tri lon hon 10");
        else
            foreach (int i in numberList)
                Debug.Log(i);

    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("--- Bai tap 20 ---");
        List<string> stringList = new List<string>();
        stringList.Add("abc");
        stringList.Add("ab");
        stringList.Add("abcd");
        stringList.Add("abcde");
        stringList.Add("abcdef");
        stringList.Add("abcdefg");

        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự

        foreach (string str in stringList)
        {
            if (str.Length > 5)
                Debug.Log(str);
        }
    }

}
