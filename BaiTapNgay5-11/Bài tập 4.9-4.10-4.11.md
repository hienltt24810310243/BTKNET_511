**Bài tập 1: Quản lý lịch hẹn phòng khám** 

**Bối cảnh:** Lễ tân phòng khám cần theo dõi lịch hẹn trong ngày, tra cứu nhanh  thông tin bệnh nhân và cập nhật trạng thái khám. 

Xây dựng ứng dụng Windows Forms **Clinic Appointment Manager** với các yêu  cầu: 

1\. **Giao diện:** Dùng TableLayoutPanel chia khu vực nhập liệu  và DataGridView; bố cục co giãn khi thay đổi kích thước Form. 

2\. **Thông tin lịch hẹn:** Mã lịch hẹn, họ tên bệnh nhân, số điện thoại, ngày giờ hẹn, bác sĩ, lý do khám và trạng thái. Dùng DateTimePicker cho ngày  giờ; ComboBox cho bác sĩ và trạng thái (Chờ khám, Đang khám, Hoàn tất,  Đã hủy). 

3\. **Danh sách:** Hiển thị lịch hẹn bằng DataGridView với cột tự định  nghĩa, AutoGenerateColumns \= false, SelectionMode \= FullRowSelect;  dùng BindingSource và BindingList\<T\>. Chọn một dòng để nạp dữ liệu lên  khu vực nhập. 

4\. **Chức năng:** Thêm, cập nhật, xóa có hộp thoại xác nhận; tìm kiếm tức thời  theo tên bệnh nhân hoặc số điện thoại; lọc theo ngày hẹn và trạng thái. 

5\. **Kiểm tra dữ liệu:** Bắt buộc có tên, số điện thoại hợp lệ, lý do khám và mã  lịch hẹn duy nhất; ngày hẹn không được nằm trong quá khứ.  

Dùng ErrorProvider báo lỗi cạnh trường tương ứng. 

6\. **Menu và trạng thái:** MenuStrip có chức năng xuất danh sách đang hiển thị ra CSV bằng SaveFileDialog; StatusStrip hiển thị số lịch hẹn sau khi lọc. 

**Kiểm thử tối thiểu:** Không cho lưu lịch hẹn có số điện thoại sai hoặc ngày trong  quá khứ; tìm kiếm theo số điện thoại trả về đúng lịch; trạng thái và số lượng trên  bảng/trạng thái cập nhật sau khi sửa, xóa và lọc. 

**Bài tập 2: Quản lý mượn trả thiết bị tại phòng thực hành** 

**Bối cảnh:** Phòng thực hành cần ghi nhận thiết bị được sinh viên mượn, thời hạn trả và tình trạng thiết bị khi hoàn trả.  
Xây dựng ứng dụng Windows Forms **Lab Equipment Checkout** với các yêu cầu: 

1\. **Giao diện:** Thiết kế Form co giãn với khu vực nhập phiếu mượn và bảng  danh sách; dùng Anchor hoặc Dock phù hợp. 

2\. **Thông tin phiếu mượn:** Mã phiếu, mã sinh viên, họ tên sinh viên, thiết bị,  số lượng, ngày mượn, hạn trả, ngày trả thực tế và tình trạng (Đang mượn, Đã  trả, Quá hạn). Dùng ComboBox chọn thiết bị và DateTimePicker nhập ngày. 

3\. **Danh sách:** Dùng DataGridView có cột cấu hình thủ 

công, BindingSource và BindingList\<T\>; chọn dòng để xem hoặc cập nhật  phiếu. 

4\. **Chức năng:** Thêm, cập nhật, xóa có xác nhận; tìm kiếm theo mã sinh viên  hoặc tên thiết bị; lọc phiếu đang mượn/quá hạn/đã trả. Khi đánh dấu đã trả,  cập nhật ngày trả thực tế. 

5\. **Kiểm tra dữ liệu:** Mã phiếu không trùng; mã sinh viên và thiết bị không để trống; số lượng phải lớn hơn 0; hạn trả không trước ngày mượn; ngày trả thực tế không trước ngày mượn. Dùng ErrorProvider hiển thị lỗi. 

6\. **Tính toán và xuất dữ liệu:** Tự xác định phiếu quá hạn khi hạn trả trước  ngày hiện tại và phiếu chưa trả; StatusStrip hiển thị tổng số phiếu và số phiếu quá hạn. Cho phép xuất các phiếu đang lọc ra CSV  

bằng SaveFileDialog. 

**Kiểm thử tối thiểu:** Không cho nhập hạn trả trước ngày mượn; phiếu chưa trả có  hạn đã qua phải được nhận diện là quá hạn; thao tác đánh dấu đã trả phải cập nhật  trạng thái và ngày trả trên bảng. 

**Bài tập 3: Quản lý đơn đăng ký dịch vụ sửa chữa** 

**Bối cảnh:** Một cửa hàng sửa chữa thiết bị cần tiếp nhận yêu cầu, theo dõi tiến độ và ước tính chi phí cho từng đơn. 

Xây dựng ứng dụng Windows Forms **Repair Service Tracker** với các yêu cầu:  
1\. **Giao diện:** Dùng bố cục responsive gồm khu vực thông tin đơn  và DataGridView; có PictureBox hiển thị ảnh thiết bị nếu khách hàng chọn  ảnh. 

2\. **Thông tin đơn:** Mã đơn, tên khách hàng, số điện thoại, loại thiết bị, mô tả lỗi, ngày tiếp nhận, chi phí dự kiến và trạng thái (Mới tiếp nhận, Đang sửa,  Chờ linh kiện, Hoàn tất, Đã hủy). Dùng ComboBox cho loại thiết bị/trạng  thái và DateTimePicker cho ngày tiếp nhận. 

3\. **Danh sách:** Hiển thị các đơn bằng DataGridView với cột tự định nghĩa, định  dạng chi phí theo "N0", AutoGenerateColumns \= false; sử 

dụng BindingSource và BindingList\<T\>. Chọn dòng để nạp thông tin lên  Form. 

4\. **Chức năng:** Thêm, cập nhật, xóa có xác nhận; tìm kiếm tức thời theo mã  đơn, tên khách hàng hoặc số điện thoại; lọc theo trạng thái.  

Dùng OpenFileDialog chọn ảnh thiết bị và PictureBoxSizeMode.Zoom để hiển thị ảnh đúng tỷ lệ. 

5\. **Kiểm tra dữ liệu:** Mã đơn không trùng; tên và số điện thoại không để trống;  chi phí dự kiến phải là số không âm; mô tả lỗi bắt buộc.  

Dùng ErrorProvider báo lỗi và không cho lưu khi dữ liệu không hợp lệ. 

6\. **Menu và trạng thái:** MenuStrip cung cấp xuất danh sách đang hiển thị ra  CSV qua SaveFileDialog và thoát ứng dụng; StatusStrip hiển thị số đơn theo  bộ lọc và tổng chi phí dự kiến của các đơn chưa hoàn tất. 

**Kiểm thử tối thiểu:** Không cho lưu chi phí âm hoặc thiếu mô tả lỗi; ảnh đã chọn  hiển thị không méo; tìm kiếm và lọc trạng thái cho kết quả chính xác; tổng chi phí  trên StatusStrip thay đổi sau khi cập nhật trạng thái hoặc chi phí.