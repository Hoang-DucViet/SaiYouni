# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle

### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.

### Cách sử dụng **NavMesh Obstacle** để chặn đường hoặc tạo vật cản cho các nhân vật điều hướng

**NavMesh Obstacle** trong Unity được sử dụng để tạo vật cản trong hệ thống điều hướng của nhân vật. Để sử dụng NavMesh Obstacle:

1. **Tạo vật cản (Obstacle)**:
   - Đặt vật thể bạn muốn dùng làm vật cản trong cảnh.
   - Thêm **NavMesh Obstacle** cho vật thể đó qua **Component > Navigation > NavMesh Obstacle**.
   - Điều chỉnh các thuộc tính cơ bản:
     - **Shape**: Chọn "Box" hoặc "Capsule" để phù hợp với hình dạng vật thể.
     - **Size**: Điều chỉnh kích thước vật cản để khớp với đối tượng thực tế.

Với **NavMesh Obstacle**, vật thể sẽ trở thành vật cản trong lưới điều hướng, khiến các nhân vật phải tìm con đường mới để đi qua.

### Cách thiết lập thuộc tính "Carving"

- **Carving** là thuộc tính quan trọng của NavMesh Obstacle, cho phép lưới NavMesh tự động thay đổi khi có vật cản xuất hiện hoặc di chuyển.
  - **Enable Carving**: Kích hoạt tùy chọn này để NavMesh có thể cắt (carve) phần lưới điều hướng xung quanh vật cản. Điều này sẽ giúp nhân vật thay đổi đường đi khi gặp vật cản di động.
  - **Carving Move Threshold**: Đặt giá trị này để quyết định khoảng cách vật cản cần di chuyển trước khi NavMesh được cập nhật. Giá trị nhỏ sẽ giúp carving phản ứng nhanh hơn nhưng có thể tốn tài nguyên.
  - **Carving Time To Stationary**: Quyết định thời gian mà vật cản cần đứng yên trước khi lưới điều hướng được cập nhật.

Khi **Carving** được kích hoạt, nhân vật sẽ tự động tránh các vật cản theo thời gian thực nếu các vật cản này di chuyển hoặc xuất hiện trong môi trường.

### Kiểm tra và điều chỉnh hệ thống **NavMesh** cho phù hợp với các vật cản mới

1. **Kiểm tra lưới điều hướng**:
   - Đảm bảo rằng lưới điều hướng đã được cập nhật theo các vật cản. Mở **Window > AI > Navigation** để xem NavMesh và các vùng bị chặn bởi vật cản.
   - Nếu lưới điều hướng không cập nhật chính xác, thử thay đổi kích thước vật cản hoặc kiểm tra thuộc tính carving.

2. **Điều chỉnh NavMesh**:
   - Nếu nhân vật gặp khó khăn khi điều hướng qua các vật cản, bạn có thể điều chỉnh **Agent Radius** trong **Navigation Mesh Agent** để nhân vật có khoảng cách an toàn hơn từ các vật cản.
   - Sử dụng **NavMesh Bake** để tạo lại lưới điều hướng nếu cần thiết sau khi điều chỉnh vật cản.

Bằng cách kết hợp **NavMesh Obstacle** và **Carving**, bạn có thể tạo môi trường điều hướng linh hoạt, giúp nhân vật phản ứng tốt hơn với các thay đổi trong môi trường.