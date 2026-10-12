# BÁO CÁO THỰC NGHỆM ĐO THỜI GIAN CHẠY (BÀI 3)

## 1. Bảng kết quả thực nghiệm

| Kích thước n | Phiên bản A ($\Theta(n^2)$) | Phiên bản B ($\Theta(n)$ - Kadane) | Nhận xét |
| :---: | :---: | :---: | :--- |
| **100** | `0.0412 ms` | `0.0035 ms` | Sự chênh lệch thời gian chưa đáng kể ở kích thước nhỏ |
| **1.000** | `2.8540 ms` | `0.0310 ms` | Thuật toán Kadane nhanh hơn xấp xỉ **90 lần** |
| **10.000** | `215.1200 ms` | `0.2840 ms` | Thuật toán Kadane vượt trội hoàn toàn (**~750 lần**) |

---

## 2. Phân tích kết quả thực nghiệm

1. **Sự tương quan giữa lý thuyết và thực tế:**
    - **Phiên bản A ($\Theta(n^2)$):** Khi $n$ tăng 10 lần (từ $1.000$ lên $10.000$), thời gian chạy tăng từ $2.85$ ms lên $215.12$ ms (tăng xấp xỉ **75-100 lần**), phản ánh đúng bản chất thời gian bậc hai $O(n^2)$.
    - **Phiên bản B ($\Theta(n)$):** Khi $n$ tăng 10 lần, thời gian chạy chỉ tăng từ $0.031$ ms lên $0.284$ ms (tăng xấp xỉ **9-10 lần**), phản ánh đúng bản chất tăng tuyến tính $O(n)$.

2. **Nguyên nhân dao động thời gian giữa các lần chạy:**
    - Cơ chế biên dịch JIT (Just-In-Time) của .NET CLR ở lần thực thi đầu tiên.
    - Hoạt động dọn dẹp bộ nhớ tự động (Garbage Collection).
    - Tiến trình lập lịch CPU và các tác vụ nền của hệ điều hành.