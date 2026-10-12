# BÀI TẬP THỰC HÀNH 01 - LẬP TRÌNH C# VÀ PHÂN TÍCH THUẬT TOÁN

## 1. Thông tin sinh viên
- **Họ và tên:** Trần Thiên Phú
- **Mã số sinh viên (MSSV):** 31251021287
- **Lớp học phần:** 26C1INF50900706
- **Môn học:** Cấu trúc dữ liệu và Giải thuật

---

## 2. Hướng dẫn biên dịch và chạy chương trình
- **Ngôn ngữ:** C# (.NET 6.0 trở lên)
- **Môi trường phát triển:** JetBrains Rider / Visual Studio / VS Code
- **Cách chạy:**
  1. Tải repository hoặc clone về máy.
  2. Mở dự án trong JetBrains Rider.
  3. Chọn file cần chạy (`Bai1.cs`, `Bai2.cs`, hoặc `Bai3.cs`), giữ hàm `static void Main` ở file đó và đổi tên hàm `Main` ở 2 file còn lại thành `Main1`/`Main2`/`Main3` để tránh xung đột điểm chạy.
  4. Mở **Terminal** trong Rider (`Alt + F12`) và gõ lệnh:
     ```bash
     dotnet run
     ```

---

## 3. Mô tả ngắn giải pháp của từng bài

### Bài 1: Nhập xuất và xử lý điều kiện
- **Giải pháp:** Nhập 3 số $a, b, c$. Sử dụng toán tử ba ngôi `? :` để xác định số lớn nhất (`max`) và số nhỏ nhất (`min`). Tính `tổng = a + b + c` và `trung bình = tổng / 3.0` (định dạng hiển thị `:F2`).

### Bài 2: Hai giá trị lớn nhất phân biệt
- **Giải pháp:** Duyệt mảng đúng một lần ($\Theta(n)$). Sử dụng biến `max1` giữ giá trị lớn nhất và `max2` (kiểu `int?`) giữ giá trị lớn thứ hai phân biệt.
  - Nếu gặp $x > max1$, cập nhật $max2 = max1$ và $max1 = x$.
  - Nếu gặp $max1 > x > max2$, cập nhật $max2 = x$.
  - Xuất `NO` nếu không tồn tại `max2`.

### Bài 3: Đoạn con liên tiếp có tổng lớn nhất
- **Phiên bản A ($\Theta(n^2)$):** Sử dụng 2 vòng lặp lồng nhau để tính tổng tích lũy từ chỉ số $i$ đến $j$ và cập nhật tổng lớn nhất.
- **Phiên bản B ($\Theta(n)$ - Kadane):** Duyệt mảng 1 lần, duy trì `maxEndingHere = Math.Max(x, maxEndingHere + x)` và `maxSoFar`. Xử lý đúng trường hợp mảng toàn số âm (trả về phần tử lớn nhất).

---

## 4. Độ phức tạp thời gian và bộ nhớ

| Bài | Thời gian | Bộ nhớ phụ | Ghi chú |
| :--- | :---: | :---: | :--- |
| **Bài 1** | $\Theta(1)$ | $\Theta(1)$ | Chỉ tính toán trên 3 biến cố định |
| **Bài 2** | $\Theta(n)$ | $\Theta(1)$ | Chỉ duyệt mảng 1 lần, xử lý trùng & số âm |
| **Bài 3 (Phiên bản A)** | $\Theta(n^2)$ | $\Theta(1)$ | Thuật toán duyệt tích lũy 2 vòng lặp |
| **Bài 3 (Phiên bản B)** | $\Theta(n)$ | $\Theta(1)$ | Thuật toán Kadane tối ưu |

---

## 5. Các test case đã sử dụng

### Bài 1
- **Test case 1 (3 số khác nhau):**
  - Input: `7 2 10`
  - Output: `Lon nhat: 10; nho nhat: 2; tong: 19; trung binh: 6.33`
- **Test case 2 (Có số âm):**
  - Input: `-5 -2 -9`
  - Output: `Lon nhat: -2; nho nhat: -9; tong: -16; trung binh: -5.33`
- **Test case 3 (2 số bằng nhau):**
  - Input: `5 8 5`
  - Output: `Lon nhat: 8; nho nhat: 5; tong: 18; trung binh: 6.00`
- **Test case 4 (3 số bằng nhau):**
  - Input: `4 4 4`
  - Output: `Lon nhat: 4; nho nhat: 4; tong: 12; trung binh: 4.00`

### Bài 2
- **Test case 1 (Thông thường):** Input `n = 5`, mảng `3 7 2 9 5` $\rightarrow$ Output: `9 7`
- **Test case 2 (Có phần tử trùng):** Input `n = 4`, mảng `8 8 8 3` $\rightarrow$ Output: `8 3`
- **Test case 3 (Toàn số âm):** Input `n = 3`, mảng `-9 -2 -5` $\rightarrow$ Output: `-2 -5`
- **Test case 4 (Không có số thứ hai):** Input `n = 4`, mảng `4 4 4 4` $\rightarrow$ Output: `NO`
- **Test case 5 (Kích thước nhỏ nhất):** Input `n = 2`, mảng `1 2` $\rightarrow$ Output: `2 1`

### Bài 3
- **Test case 1 (Mảng hỗn hợp):** Input `-2 1 -3 4 -1 2 1 -5 4` $\rightarrow$ Kết quả A: `6` | B: `6`
- **Test case 2 (Mảng toàn số âm):** Input `-8 -3 -6 -2 -5 -4` $\rightarrow$ Kết quả A: `-2` | B: `-2`
- **Test case 3 (Mảng toàn số dương):** Input `1 2 3` $\rightarrow$ Kết quả A: `6` | B: `6`

---

## 6. Công cụ AI đã sử dụng
Em đã sử dụng công cụ AI (Gemini và Claude) để hỗ trợ kiểm tra lỗi logic xử lý mảng, tối ưu việc đo thời gian chạy của bài 3 và định dạng tài liệu báo cáo. Toàn bộ mã nguồn đã được em kiểm thử trực tiếp trên JetBrains Rider và chịu trách nhiệm hoàn toàn về kết quả.
