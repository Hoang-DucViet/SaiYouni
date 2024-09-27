# Giải Thích Câu Lệnh `int[] scores = new int[10]`;
	
## Nhờ AI Giải Thích Câu Lệnh

	int[]: Đây là kiểu dữ liệu mảng, trong trường hợp này là một mảng các số nguyên (int).

	scores: Đây là tên biến mà bạn đặt cho mảng. Bạn có thể sử dụng tên này để truy cập vào mảng trong suốt chương trình.

	new int[10]: Phần này khởi tạo một mảng mới với kích thước là 10. Điều này có nghĩa là mảng scores sẽ có thể chứa tối đa 10 phần tử kiểu int. Tất cả các phần tử trong mảng này sẽ được khởi tạo với giá trị mặc định là 0.	

## Nội Dung Đã Tìm Hiểu
	
	Mảng: giá trị đầu tiên của mảng có chỉ số là 0
		Ví dụ: scores[0] là giá trị đầu tiên của mảng
	Có thể sử dụng vòng lặp để duyệt qua các biến trong mảng 
	Các phương thức làm việc với mảng:
		Array.Length: Trả về số lượng phần tử trong mảng.
			int length = scores.Length; 
		Array.Clear: Xóa các phần tử trong mảng (đặt giá trị về 0 cho kiểu số).
			Array.Clear(scores, 0, scores.Length);
		Array.IndexOf: Tìm chỉ số của một phần tử trong mảng.
			int index = Array.IndexOf(scores, 10); // Tìm chỉ số (vị trí) của 10
		...

# Giải Thích về Rigidbody

## Nhờ AI Giải Thích về Rigidbody

	Rigidbody là một thành phần (component) quan trọng giúp bạn áp dụng vật lý cho các đối tượng trong trò chơi

	Các thuộc tính chính của Rigidbody:
		Mass: Khối lượng của đối tượng. Khối lượng ảnh hưởng đến cách mà đối tượng phản ứng với lực.
		Drag: Sức cản không khí. Làm giảm tốc độ của đối tượng khi di chuyển.
		Angular Drag: Sức cản xoay. Làm giảm tốc độ xoay của đối tượng.
		Use Gravity: Nếu bật, đối tượng sẽ bị ảnh hưởng bởi trọng lực.
		Is Kinematic: Nếu bật, đối tượng sẽ không bị ảnh hưởng bởi lực và va chạm. Bạn có thể điều khiển nó thông qua mã.

	Cách sử dụng Rigidbody trong C#
		rb = GetComponent<Rigidbody>(); // Lấy component Rigidbody của đối tượng
		rb.useGravity = true; // Bật trọng lực
		rb.isKinematic = true; // Đối tượng không bị ảnh hưởng bởi vật lý

## Nội Dung Đã Tìm Hiểu
	
	Ngoài ra, Rigidbody còn:

	Constraints:
		Freeze Position: Giới hạn chuyển động của đối tượng trong không gian 3D. Bạn có thể đóng băng vị trí theo các trục X, Y, Z.
		Freeze Rotation: Giới hạn sự xoay của đối tượng. Bạn có thể đóng băng xoay theo các trục X, Y, Z.

	Collision Detection:
		Continuous: Kiểm tra va chạm liên tục, hữu ích cho các đối tượng di chuyển nhanh để tránh việc bị bỏ qua va chạm.
		Discrete: Kiểm tra va chạm theo từng khung hình, là mặc định.

	Interpolate:
		None: Không sử dụng nội suy. Đối tượng có thể di chuyển một cách giật cục.
		Interpolate: Làm mượt chuyển động bằng cách nội suy vị trí giữa các khung hình.
		Extrapolate: Dự đoán vị trí trong khung hình tiếp theo dựa trên tốc độ.
		* Khác nhau giữa Interpolate và Extrapolate
			Interpolate làm mượt bằng cách thêm khung hình tính với thời điểm hiện tại, còn Extrapolate sử dụng khung hình hiện tại, vận tốc, hướng để dự đoán chuyển động tương lai. Do đó đôi khi Extrapolate có thể xuất hiện sai lệch khi va chạm.

# Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ

## Nhờ AI Giải Thích về Phép Chia Lấy Dư

	Sử dụng toán tử % để chia và lấy dư

## Nội Dung Đã Tìm Hiểu

	Số chia * Thương + Số dư = Số bị chia 
	Số bị chia % Số chia = Số dư

	Dùng trong các trường hợp như:
		Tính Chẵn/Lẻ 
		Kiểm Tra Chia Hết 
		Xử Lý Thời Gian
		...

# 5 Kiểu Dữ Liệu Khác của Unity C#

## Giới Thiệu

	Ngoài các kiểu dữ liệu cơ bản như `int`, `float`, `bool`, và `string`, Unity C# còn hỗ trợ nhiều kiểu dữ liệu khác để giúp lập trình viên quản lý và xử lý dữ liệu hiệu quả hơn. Dưới đây là 5 kiểu dữ liệu khác mà bạn có thể sử dụng trong Unity C#.

## Nội Dung Đã Tìm Hiểu

	Kiểu Dữ Liệu Cơ Bản (Value Types) - ngoài `in`, `float`, `bool`
		long: Số nguyên 64-bit.
		short: Số nguyên 16-bit.
		byte: Số nguyên không dấu 8-bit.
		Vector2, Vector3, Color (kiểu cấu trúc - một bộ số)

	Kiểu Dữ Liệu Tham Chiếu (Reference Types) - ngoài `string`
		Có thể coi Coroutine là một dạng tham chiếu 
		
# 3 Toán Tử Khác trong Unity C#

## Giới Thiệu

	Ngoài các toán tử cơ bản như toán tử số học, toán tử quan hệ, và toán tử logic, Unity C# còn hỗ trợ nhiều toán tử khác để giúp lập trình viên thực hiện các thao tác phức tạp hơn.

	Dưới đây là 3 toán tử khác mà bạn có thể sử dụng trong Unity C#.

		Toán tử gán (Assignment Operators)
			=: Gán giá trị cho biến.
			+=: Gán giá trị và cộng thêm.
			-=: Gán giá trị và trừ đi.
			*=: Gán giá trị và nhân.
			/=: Gán giá trị và chia.
			%=: Gán giá trị và lấy phần dư.
		Toán tử tăng giảm (Increment and Decrement Operators)
			++: Tăng giá trị lên 1
			--: Giảm giá trị xuống 1.
		Toán tử điều kiện (Ternary Operator)
			?:: Toán tử điều kiện ba ngôi, dùng để rút gọn câu lệnh if-else.
				ví dụ: int a = (điều kiện) ? 1 : 2:
						nếu điều kiện == true   a = 1
						ngược lại				a = 2
	Ngoài ra:
		Toán tử null (Null Coalescing Operator)
			??: Trả về giá trị bên trái nếu nó không null, ngược lại trả về giá trị bên phải.
		Toán tử null-conditional
			?.: Kiểm tra null trước khi truy cập thuộc tính hoặc phương thức.
		Toán tử Bitwise
			&: AND bitwise.
			|: OR bitwise.
			^: XOR bitwise.
			~: NOT bitwise.
			<<: Shift trái.
			>>: Shift phải.
		Toán tử kiểu (Type Operators)
			is: Kiểm tra xem một đối tượng có phải là một loại cụ thể không.
			as: Ép kiểu an toàn.