GIỚI THIỆU - HƯỠNG DẪN SỬ DỤNG VÀ CHẠY PROJECT LẦN ĐẦU TIÊN
 * Công nghệ sử dụng:
    .Net windown form, SQL Server
 * Chạy project lần đầu tiên
   1 Tải hoặc clone về máy tính của bạn và mở project.
   2 restore database với file cafe.bak vào sql server
   3 kiểm tra và sửa đổi file db.cs ở trong project nếu cần để kết nối sql đúng đường dẫn:
         + public static SqlConnection Connect() {
      	    + SqlConnection conn = null;
            + conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=cafe;Integrated Security=True;MultipleActiveResultSets=true;");
            +return conn;
         + }
   4 build và chạy project
     1 Mở cmd (terminal) chạy lệnh
        + dotnet restore
        + dotnet run
* một số chức năng nổi bật và cách sử dụng
    0. đăng ký đăng nhập
      Bạn có thể đăng ký không giới hạn và  đăng nhập nếu là admin thì sẽ vào trang admin còn nếu là user thì sẽ vào trang user.
    1. trang admin
      Để đăng nhập với admin thì bạn có thể đăng nhập với tài khoản: username: admin. password: admin123.
      * chức năng nổi bật: phần quyền cho user

    2. trang user
       + xuất file cho order
* một số hình ảnh tham khảo

  
   ![image](https://github.com/user-attachments/assets/9745e4ef-9a68-4e73-914b-30485391ea57)
   ![image](https://github.com/user-attachments/assets/ebdf04dd-fd3c-48b8-9e69-9916ab2b3076)
  ![image](https://github.com/user-attachments/assets/2f176b2b-193e-40e3-9e0b-7f6ad6790ce8)
  ![image](https://github.com/user-attachments/assets/12b86f36-9f85-4e66-a8ef-4ed1b72e8351)
  ![image](https://github.com/user-attachments/assets/8201eb8a-b895-4457-8d19-0850a15346b5)





  
