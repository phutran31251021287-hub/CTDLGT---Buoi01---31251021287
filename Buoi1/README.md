## 1. Thông tin sinh viên
Họ và tên: Trần Thiên Phú
Mã số sinh viên (MSSV): 31251021287
Lớp học phần: 26C1INF50900706

## 2. Hướng dẫn biên dịch và chạy chương trình
Ngôn ngữ sử dụng: C#
Cách chạy: Dowdload các file Bai1.cs, Bai2.cs, Bai3.cs về và mở trên các ứng dụng hỗ trợ ngôn ngữ C# để chạy.

## 3. Mô tả ngắn giải pháp của từng bài
Bài 1: Sử dụng toán tử 3 ngôi để tìm min, max và công thức trung bình cộng để tính trung bình
Bài 2: Cho nhập n (số nguyên) và chuỗi ký tự trong mảng (string) sau đó mới split ra ép về int và đem đi so sánh. Cho số lớn nhất là max_1 = phần tử đầu tiên trong mảng. max_2 số lớn nhì = phần tử đầu tiên trong mảng. Sau đó dùng for để chạy từng phần tử đem đi so sánh nếu giá trị tại vị trí i lớn nhất thì gán vào max_1, chuyển giá trị max_1 sang max_2.
Xử lý thêm trường hợp giá trị nhỏ hơn max_1 nhưng lại lớn hơn max_2 thì gán vào max_2
Bài 3: Phiên bản A xử dụng cộng liên tiếp và so sánh với biến max định sẵn không nếu có thì thay giá trị max, mỗi lần cộng thêm giá trị và mỗi lần so sánh. Phiên bản B là thuật toán Kadane.

## 4. Độ phức tạp thời gian và bộ nhớ

Bài 1 (Nhập xuất và xử lý điều kiện):
- Thời gian: O(1) hoặc Θ(1) vì thuật toán chỉ so sánh điều kiện trực tiếp và tính toán trên 3 số cố định, thời gian chạy không phụ thuộc vào dữ liệu nhập vào.
- Bộ nhớ: O(1) hoặc Θ(1) do chỉ sử dụng một vài biến đơn để lưu giá trị (a, b, c, max, min, avg).

Bài 2 (Hai giá trị lớn nhất phân biệt):
- Thời gian: Θ(n) vì thuật toán đáp ứng đúng ràng buộc chỉ duyệt qua mảng số nguyên gồm n phần tử đúng một lần duy nhất bằng vòng lặp.
- Bộ nhớ: Θ(1) bộ nhớ phụ vì chương trình chỉ sử dụng một số biến chạy và biến lưu trữ giá trị lớn nhất (max1, max2), không tạo thêm mảng phụ hay cấu trúc dữ liệu trung gian nào khác (đạt mục tiêu đề bài).

Bài 3 (Đoạn con liên tiếp có tổng lớn nhất):
- Phiên bản A (Thuật toán duyệt tích lũy):
  + Thời gian: Θ(n²) do sử dụng 2 vòng lặp lồng nhau để xét các vị trí bắt đầu, kết thúc và tích lũy tổng của mọi đoạn con, không dùng 3 vòng lặp Θ(n³).
  + Bộ nhớ: O(1) bộ nhớ phụ (ngoại trừ không gian lưu mảng chuỗi đầu vào rawNumbers).
- Phiên bản B (Thuật toán Kadane):
  + Thời gian: Θ(n) vì chỉ sử dụng duy nhất một vòng lặp từ đầu đến cuối mảng để tính tổng lớn nhất tại mỗi vị trí dựa trên kết quả của bước trước đó.
  + Bộ nhớ: Θ(1) bộ nhớ phụ, xử lý chính xác cả trường hợp tất cả phần tử trong mảng đều âm (trả về phần tử lớn nhất chứ không mặc định bằng 0).

---

## 5. Các test case đã sử dụng

### Bài 1 (Thử nghiệm đầy đủ 4 trường hợp biên theo yêu cầu)
- Test case 1 (Ba số khác nhau):
  + Input: 7 2 10
  + Expected Output: Lớn nhất: 10; nhỏ nhất: 2; tổng: 19; trung bình: 6.33
  + Actual Output: Lon nhat = 10, nho nhat = 2, trung binh = 6.33
- Test case 2 (Có số âm):
  + Input: -5 -2 -9
  + Expected Output: Lớn nhất: -2; nhỏ nhất: -9; tổng: -16; trung bình: -5.33
  + Actual Output: Lon nhat = -2, nho nhat = -9, trung binh = -5.33
- Test case 3 (Hai số bằng nhau):
  + Input: 5 8 5
  + Expected Output: Lớn nhất: 8; nhỏ nhất: 5; tổng: 18; trung bình: 6.00
  + Actual Output: Lon nhat = 8, nho nhat = 5, trung binh = 6.00
- Test case 4 (Ba số bằng nhau):
  + Input: 4 4 4
  + Expected Output: Lớn nhất: 4; nhỏ nhất: 4; tổng: 12; trung bình: 4.00
  + Actual Output: Lon nhat = 4, nho nhat = 4, trung binh = 4.00

### Bài 2 (Bộ kiểm thử tối thiểu chuẩn theo đề bài)
- Test case 1 (Trường hợp thông thường):
  + Input: n = 5, mang = 3 7 2 9 5
  + Expected Output: 9 7
  + Actual Output: 9 7
- Test case 2 (Có phần tử trùng):
  + Input: n = 4, mang = 8 8 8 3
  + Expected Output: 8 3
  + Actual Output: 8 3
- Test case 3 (Toàn số âm):
  + Input: n = 3, mang = -9 -2 -5
  + Expected Output: -2 -5
  + Actual Output: -2 -5
- Test case 4 (Không có số thứ hai):
  + Input: n = 4, mang = 4 4 4 4
  + Expected Output: NO
  + Actual Output: NO
- Test case 5 (Kích thước nhỏ nhất n = 2):
  + Input: n = 2, mang = 1 2
  + Expected Output: 2 1
  + Actual Output: 2 1

### Bài 3
- Test case 1 (Mảng hỗn hợp âm dương):
  + Input: -2 1 -3 4 -1 2 1 -5 4
  + Expected Output: Phiên bản A: 6, Phiên bản B: 6 (Đoạn con gợi ý: 4 -1 2 1)
  + Actual Output: Phiên bản A: 6, Phiên bản B: 6
- Test case 2 (Mảng toàn số âm - Kiểm tra điều kiện biên Kadane):
  + Input: -8 -3 -6 -2 -5 -4
  + Expected Output: Phiên bản A: -2, Phiên bản B: -2 (Đoạn con gợi ý: -2)
  + Actual Output: Phiên bản A: -2, Phiên bản B: -2
- Test case 3 (Mảng toàn số dương):
  + Input: 1 2 3
  + Expected Output: Phiên bản A: 6, Phiên bản B: 6 (Đoạn con gợi ý: 1 2 3)
  + Actual Output: Phiên bản A: 6, Phiên bản B: 6

## 6. Công cụ AI đã sử dụng
Mẫu khai báo tuân thủ theo đúng quy định sử dụng AI của học phần:
- Tôi đã sử dụng ChatGPT / Claude để giải thích thuật toán, phân tích độ phức tạp thời gian và chuẩn hóa định dạng văn bản Markdown cho tài liệu báo cáo này. Phần được hỗ trợ gồm: Phân tích lý thuyết Big-O và xây dựng cấu trúc file README.
