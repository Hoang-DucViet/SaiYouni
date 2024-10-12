using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    public int var1;

    public int var2;

    public float markToPass;

    public float var4_1;
    public float var4_2;
    
    public float currentBalance;
    public float price;

    public int year;

    public int age1;

    public float excellentScore;

    public float var9_1;
    public float var9_2;
    public float var9_3;

    public float hour;
    public float fixSalary;

    public int age2;
    public bool isHave;

    public float mark;

    public int eBill;

    public int yearWorked;
    public bool employeeEvaluation;

    public int orderPrice;

    public int income;

    public float markSubject1;
    public float markSubject2;  
    public float markSubject3;

    public int stockQuantity;
    public bool storageSpace;

    public int var19;

    public bool isCompleted;
    public float gpa;
    public bool hasLetter;

    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        // Nhập một số từ bàn phím
        Debug.Log("---------- Bai tap 1 ----------");
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (var1 > 0)
            Debug.Log($"{var1} la so duong");
        else if (var1 < 0)
            Debug.Log($"{var1} la so am");
        else
            Debug.Log($"Day la so {var1}");
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        Debug.Log("---------- Bai tap 2 ----------");
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if (var2 % 2 == 0)
            Debug.Log($"{var2} la so chan");
        else
            Debug.Log($"{var2} la so le");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        Debug.Log("---------- Bai tap 3 ----------");

        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if (markToPass >= 5.0)
            Debug.Log($"Hoc vien do");
        else
            Debug.Log($"Hoc vien truot");
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        Debug.Log("---------- Bai tap 4 ----------");

        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if (var4_1 > var4_2)
            Debug.Log($"{var4_1} lon hon {var4_2}");
        else if (var4_1 < var4_2)
            Debug.Log($"{var4_2} lon hon {var4_1}");
        else
            Debug.Log($"{var4_1} bang {var4_2}");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        Debug.Log("---------- Bai tap 5 ----------");

        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if (currentBalance >= price)
            Debug.Log($"Du dieu kien thanh toan");
        else
            Debug.Log($"So du khong du de thuc hien giao dich");
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        Debug.Log("---------- Bai tap 6 ----------");


        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)               
                    Debug.Log($"{year} la nam nhuan");
                else
                    Debug.Log($"{year} khong phai la nam nhuan");
            }
            else            
                Debug.Log($"{year} la nam nhuan");                          
        }
        else       
            Debug.Log($"{year} khong phai la nam nhuan");                 
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        Debug.Log("---------- Bai tap 7 ----------");
        int price1 = 50000;
        int price2 = 100000;

        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        if (age1 >= 18)
            Debug.Log($"Gia ve cua ban la {price2}");
        else
            Debug.Log($"Gia ve cua ban la {price1}");      
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        Debug.Log("---------- Bai tap 8 ----------");

        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if (excellentScore >= 9.0)
            Debug.Log("Hoc sinh xuat sac");
        else
            Debug.Log("Chi la chua duoc xuat sac thoi");
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        Debug.Log("---------- Bai tap 9 ----------");

        // Kiểm tra và in ra số lớn nhất trong ba số đó
        float max = var9_1;
        if (max < var9_2)
            max = var9_2;
        if (max < var9_3)
            max = var9_3;

        Debug.Log($"Gia tri lon nhat trong 3 so la {max}");

    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        Debug.Log("---------- Bai tap 10 ----------");

        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định

        if (hour > 40)
            Debug.Log($"Luong: {((hour - 40) * 2 * fixSalary) + (40 * fixSalary)}");
        else
            Debug.Log($"Luong: {hour * fixSalary}");
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        Debug.Log("---------- Bai tap 11 ----------");

        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ

        if (age2 > 18 && isHave == true)
            Debug.Log("Co the tham gia");
        else
            Debug.Log("Chua du dieu kien tham gia");
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        Debug.Log("---------- Bai tap 12 ----------");

        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        if (mark >= 9.0 && mark <= 10.0)
            Debug.Log("Xuat sac");
        else if (mark >= 8.0 && mark < 9.0)
            Debug.Log("Gioi");
        else if (mark >= 7.0 && mark < 8.0)
            Debug.Log("Kha");
        else if (mark >= 5.0 && mark < 7.0)
            Debug.Log("Trung binh");
        else if (mark >= 0 && mark < 5.0)
            Debug.Log("Yeu");
        else
            Debug.Log("Diem so nay khong hop le");
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        Debug.Log("---------- Bai tap 13 ----------");
        int eCost = 0;
        int kWh1 = 1500;
        int kWh2 = 2000;

        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh

        if (eBill > 100)
            eCost = (eBill - 100) * kWh2 + (100 * kWh1);
        else
            eCost = eBill * kWh1;

        Debug.Log($"Chi phi tien dien la {eCost}");
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        Debug.Log("---------- Bai tap 14 ----------");

        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức

        if (yearWorked > 5 && employeeEvaluation == true)
            Debug.Log("Du dieu kien thang chuc");
        else
            Debug.Log("Chua du dieu kien thang chuc");
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        Debug.Log("---------- Bai tap 15 ----------");

        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if (orderPrice > 500000)
            Debug.Log("Don hang duoc mien phi van chuyen");
        else
            Debug.Log($"Mua them {500000 - orderPrice} de duoc voucher mien phi van chuyen");

    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        Debug.Log("---------- Bai tap 16 ----------");
        int tax = 0;
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập

        if (income <= 10000000)
            tax = 5 * income / 100;
        else if (income <= 20000000 && income > 10000000)
            tax = 10 * income / 100;
        else if (income > 20000000)
            tax = 20 * income / 100;

        Debug.Log($"Thue thu nhap ca nhan: {tax}");
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        Debug.Log("---------- Bai tap 17 ----------");

        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float overall = (markSubject1 + markSubject2 + markSubject3) / 3 ;

        if (overall > 5.0)
            Debug.Log("Dat yeu cau");
        else
            Debug.Log("Chua dat yeu cau");
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        Debug.Log("---------- Bai tap 18 ----------");

        if (stockQuantity < 100 && storageSpace == true)
            Debug.Log("Co the nhap hang");
        else
            Debug.Log("Chua can nhap hang");
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        Debug.Log("---------- Bai tap 19 ----------");

        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if (var19 > 10)
            Debug.Log($"{var19} lon hon 10");
        else
            Debug.Log($"{var19} khong lon hon 10" );
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        Debug.Log("---------- Bai tap 20 ----------");

        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không

        if (isCompleted == true && gpa >= 7.0 && hasLetter == true)
            Debug.Log("Du dieu kien tham gia khao nang cao");
        else
            Debug.Log("Chua du dieu kien tham gia khao nang cao");
    }
}
