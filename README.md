Bài tập trong Slide trang 80
---

Lập trình viên A đang phát triển ứng dụng quản lý mua bán cà phê cho một công ty. Công ty này bán các sản phẩm cà phê với thông tin gồm mã loại cà phê, tên loại cà phê, số lượng và đơn giá. Có tổng cộng 4 loại cà phê và cách tính thành tiền cho mỗi loại như sau:

- **Cà phê hạt:** Thành tiền = số lượng * đơn giá.

- **Cà phê xay nguyên chất:** Thành tiền = số lượng * đơn giá + công xay. Công xay được tính như sau: 100 * số lượng nếu số lượng < 100, ngược lại là 95 * số lượng.

- **Cà phê xay có hương liệu:** Thành tiền = số lượng * đơn giá + (số lượng hương liệu * giá hương liệu) + (công pha chế, với mỗi đơn vị số lượng tương ứng với 2 công pha chế).

- **Cà phê đã đóng gói:** Thành tiền phụ thuộc vào loại bao bì. Chỉ có 2 loại bao bì là "giấy" và "hộp nhựa". Nếu loại bao bì là "giấy", thành tiền sẽ là số lượng * đơn giá * 110%, ngược lại là số lượng * đơn giá * 120%.

Ngoài ra, để hỗ trợ việc phát triển và tiếp thị các mặt hàng cà phê hạt và cà phê xay nguyên chất (để hỗ trợ nông dân), nhà nước cung cấp hỗ trợ tài chính cho công ty (KinhPhiHoTro) như sau:

- **Cà phê hạt:** Số tiền hỗ trợ bằng số lượng * 10.

- **Cà phê xay nguyên chất:** Số tiền hỗ trợ bằng số lượng * 12.

Lập trình viên A được giao nhiệm vụ phân tích thiết kế và xây dựng các lớp và tính năng cho ứng dụng này.

---
