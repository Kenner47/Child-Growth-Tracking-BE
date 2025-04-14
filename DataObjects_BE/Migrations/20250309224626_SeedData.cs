using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataObjects_BE.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                -- Insert Accounts
                INSERT INTO Accounts (AccountId, FirstName, LastName, UserName, Password, Email, PhoneNumber, Address, Role, DateCreateAt, DateUpdateAt, ImageUrl, IsActive, Otp, OtpCreatedAt, ResetPasswordToken, ResetPasswordTokenExpiration) VALUES
                (NEWID(), 'Doc', 'tor001', 'doctor001', N'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'doctor001@root.com', '0987654321', '456 Elm St', 2, CAST(N'2025-02-27T04:06:45.0300000' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Ha', 'Vu Minh', 'Vu Minh Ha', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'havuminh@root.com', '0501247836', '2534 To Ky str', 2, CAST(N'2025-02-27T04:12:44.6166667' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'LNSE', 'Thong', 'thonglyngocse@gmail.com', 'AQAAAAIAAYagAAAAEHoSc6xRzzI2Lnyaj9Mb+/GaSbF9Og+NZEC2vnRsLIJU7qjouvwqIlhDXFpsnDgySQ==', 'thonglyngocse@gmail.com', '0399554477', 'Hoc Mon', 1, CAST('2025-02-20T03:24:42.2506616' AS DateTime2), CAST('2025-02-20T03:24:42.2508234' AS DateTime2), 'abc', 1, NULL, CAST('2025-02-20T03:24:42.5697700' AS DateTime2), NULL, NULL),
                (NEWID(), 'Doc', 'tor002', 'doctor002', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'doctor002@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T04:08:55.9500000' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Ad', 'min', 'admin', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'admin@root.com', '1234567890', '123 Main St', 0, CAST('2025-02-23T13:48:39.2000000' AS DateTime2), NULL, 'https://example.com/johndoe.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Jake', 'Nguyen', 'JakeNguyen', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'JakeNguyen@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T13:18:49.7233333' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Kim', 'Lee', 'KimLee', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'KimLee@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T13:17:00.1433333' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Nguyen ', 'Dat', 'Nguyen Dat', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'nguyendat@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T13:20:29.8700000' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Kim', 'Ha', 'KimHa', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'KimHa@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T04:10:45.8500000' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'tai khoan', 'gia dinh', 'noname0909435766@gmail.com', 'AQAAAAIAAYagAAAAELMPe3zNxJFfFHDrxTeZ1NH8Uqxy2RybXHgWffxhf87zswshcaIJSk8MUgd4d8e1zg==', 'noname0909435766@gmail.com', '0544321846', '125/14/5/7/9 Nguyễn Thị Đường Dài, ấp Xa Xôi, huyện Triền Miên, tỉnh Táo Cả Ngày', 1, CAST('2025-03-01T08:52:41.7042079' AS DateTime2), CAST('2025-03-01T08:52:41.7043470' AS DateTime2), 'abc', 1, NULL, CAST('2025-03-01T08:52:41.9391328' AS DateTime2), NULL, NULL),
                (NEWID(), 'Anna', 'Lee', 'AnnaLee', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'AnnaLee@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T04:10:25.3800000' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Jerry', 'Bones', 'JamesBones', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'JerryBones@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T04:09:52.4233333' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'doctor', 'tai khoan', 'VictorChing', 'AQAAAAIAAYagAAAAEK02WLlMz4Jm0aa80tqWDLIEeX/0eMlaV+ZfVU7MeoP2UwwlJto01DRmiX2YW7obzA==', 'VictorChing@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T04:11:12.1100000' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Hana', 'Ha', 'HanaHa', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'HanaHa@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T13:18:04.6233333' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Ha Anh', 'Kieu', 'Kieu Ha Anh', 'AQAAAAIAAYagAAAAELObGZZG6vqAQaRa1m71QSDs2h1pUHdryohuqFT/OV71Zbq997QA4CJP6i4zzFHeOw==', 'kieuhaanh@root.com', '0987654321', '456 Elm St', 2, CAST('2025-02-27T13:19:53.0300000' AS DateTime2), NULL, 'https://example.com/janesmith.jpg', 1, NULL, NULL, NULL, NULL),
                (NEWID(), 'Thu Nghiem', 'Tai Khoan', 'nguyenthaitoanphuc2304@gmail.com', 'AQAAAAIAAYagAAAAEK35sPVvQ5NHoD59gZiIX2sS0Wvv+uutFknwPf+lIXa0VB6cW9uXyc9Z7jB+7s3mtg==', 'nguyenthaitoanphuc2304@gmail.com', '0147521478', 'quận 9', 1, CAST('2025-03-13T06:58:39.8475106' AS DateTime2), CAST('2025-03-13T06:58:39.8478221' AS DateTime2), 'abc', 1, NULL, CAST('2025-03-13T06:58:39.9198465' AS DateTime2), NULL, NULL);

                -- Insert Managers
                INSERT INTO Managers (ManagerId, AccountId) VALUES
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'admin'));

                -- Insert Doctors
                INSERT INTO Doctors (DoctorId, AccountId, Specialization, ExperienceYears, HospitalAddressWork) VALUES
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'VictorChing'), N'Cardiology', 10, N'General Hospital'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'doctor001'), N'Neurology', 8, N'City Medical Center'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'HanaHa'), N'Pediatrics', 5, N'Sunshine Children Hospital'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'JamesBones'), N'Orthopedics', 12, N'Central Orthopedic Clinic'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'AnnaLee'), N'Dermatology', 7, N'Skin Care Clinic'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'Nguyen Dat'), N'Oncology', 15, N'Cancer Research Center'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'JakeNguyen'), N'Ophthalmology', 9, N'Vision Eye Hospital'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'Vu Minh Ha'), N'Endocrinology', 6, N'Diabetes and Metabolism Clinic'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'Kieu Ha Anh'), N'Gastroenterology', 10, N'Digestive Health Institute'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'doctor002'), N'Pulmonology', 11, N'Lung and Respiratory Center'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'KimHa'), N'Urology', 8, N'Men’s Health Hospital'),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'KimLee'), N'Hematology', 7, N'Blood Disease Center');

                -- Insert Parents
                INSERT INTO Parents (ParentId, AccountId) VALUES
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'thonglyngocse@gmail.com')),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'noname0909435766@gmail.com')),
                (NEWID(), (SELECT AccountId FROM Accounts WHERE UserName = N'nguyenthaitoanphuc2304@gmail.com'));

                -- Insert Childs
                INSERT INTO Childs (ChildId, ParentId, FirstName, LastName, Gender, DOB, DateCreateAt, DateUpdateAt, ImageUrl) VALUES
                (NEWID(), (SELECT ParentId FROM Parents WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'thonglyngocse@gmail.com')), N'Duyên', N'Nguyễn Thị Mỹ', N'Female', CAST(N'2010-02-08T00:00:00.0000000' AS DateTime2), CAST(N'2025-03-05T09:32:44.5947830' AS DateTime2), CAST(N'2025-03-12T14:10:38.1685989' AS DateTime2), N'child1.jpg'),
                (NEWID(), (SELECT ParentId FROM Parents WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'thonglyngocse@gmail.com')), N'Huỳnh Thị Liên', N'Nguyễn', N'Female', CAST(N'2008-05-01T00:00:00.0000000' AS DateTime2), CAST(N'2025-03-12T15:32:03.8253244' AS DateTime2), CAST(N'2025-03-12T15:33:20.5601298' AS DateTime2), N'child2.jpg');

                -- Insert Appointments
                INSERT INTO Appointments (AppointmentId, DoctorId, ParentId, ChildId, ScheduledTime, Status, CreatedAt, UpdatedAt) VALUES
                (NEWID(), (SELECT DoctorId FROM Doctors WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'HanaHa')), (SELECT ParentId FROM Parents WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'thonglyngocse@gmail.com')), (SELECT ChildId FROM Childs WHERE FirstName = N'Duyên'), N'2025-04-01 10:00:00', 1, GETUTCDATE(), GETUTCDATE()),
                (NEWID(), (SELECT DoctorId FROM Doctors WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'JakeNguyen')), (SELECT ParentId FROM Parents WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'thonglyngocse@gmail.com')), (SELECT ChildId FROM Childs WHERE FirstName = N'Huỳnh Thị Liên'), N'2025-04-02 14:00:00', 2, GETUTCDATE(), GETUTCDATE());

                -- Insert Reports
                INSERT INTO Reports (ReportId, ChildId, ReportMark, ReportContent, ReprotCreateDate, ReportIsActive, ReportName, Height, Weight, BMI) VALUES
                (NEWID(), (SELECT ChildId FROM Childs WHERE FirstName = N'Duyên'), 'A', N'Cân đối', GETUTCDATE(), 1, N'Report 1', 120.5, 30.5, 18.5),
                (NEWID(), (SELECT ChildId FROM Childs WHERE FirstName = N'Huỳnh Thị Liên'), 'B', N'Cần thêm vitamin', GETUTCDATE(), 1, N'Report 2', 130.5, 35.5, 20.5);

                -- Insert Feedbacks
                INSERT INTO Feedbacks (FeedbackId, ReportId, DoctorId, FeedbackContentRequest, FeedbackCreateDate, FeedbackUpdateDate, FeedbackIsActive, FeedbackName, FeedbackContentResponse) VALUES
                (NEWID(), (SELECT ReportId FROM Reports WHERE ReportName = N'Report 1'), (SELECT DoctorId FROM Doctors WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'HanaHa')), N'Tư vấn tuyệt vời!', GETUTCDATE(), GETUTCDATE(), 1, N'Feedback 1', N'Response 1'),
                (NEWID(), (SELECT ReportId FROM Reports WHERE ReportName = N'Report 2'), (SELECT DoctorId FROM Doctors WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'JakeNguyen')), N'Lời khuyên rất hữu ích', GETUTCDATE(), GETUTCDATE(), 1, N'Feedback 2', N'Response 2');

                -- Insert Ratings
                INSERT INTO Ratings (RatingId, FeedbackId, ParentId, RatingValue, RatingDate, IsActive) VALUES
                (NEWID(), (SELECT FeedbackId FROM Feedbacks WHERE FeedbackName = N'Feedback 1'), (SELECT ParentId FROM Parents WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'thonglyngocse@gmail.com')), 5, GETUTCDATE(), 1),
                (NEWID(), (SELECT FeedbackId FROM Feedbacks WHERE FeedbackName = N'Feedback 2'), (SELECT ParentId FROM Parents WHERE AccountId = (SELECT AccountId FROM Accounts WHERE UserName = N'thonglyngocse@gmail.com')), 4, GETUTCDATE(), 1);

                -- Insert ProductLists
                INSERT INTO ProductLists (ProductListId, ProductName, ProductDescription, Price, MinAge, MaxAge, SafetyFeature, Rating, RecommendedBy, ImageUrl, Brand, IsActive, ProductType) VALUES
                (NEWID(), N'Multivitamin', N'Siro vitamin tổng hợp hằng ngày cho trẻ', 1500.0000, 3, 5, N'Feature 1', 4.5, N'Recommender 1', N'url1', N'Brand 1', 1, N'Cân nặng bình thường - Bình thường'),
                (NEWID(), N'Baby Formula', N'Sữa bột dành cho trẻ sơ sinh', 3000.0000, 0, 1, N'Feature 2', 4.0, N'Recommender 2', N'url2', N'Brand 2', 1, N'Cân nặng bình thường - Bình thường'),
                (NEWID(), N'Rice Cereal', N'Bột ăn dặm giàu dinh dưỡng với hàm lượng béo thấp', 2500.0000, 0, 2, N'Feature 3', 4.2, N'Recommender 3', N'url3', N'Brand 3', 1, N'Thừa cân - Nguy cơ tăng nhẹ'),
                (NEWID(), N'Fruit Puree', N'Súp trái cây tự nhiên không thêm đường', 1800.0000, 1, 3, N'Feature 4', 4.6, N'Recommender 4', N'url4', N'Brand 4', 1, N'Thừa cân - Nguy cơ tăng nhẹ'),
                (NEWID(), N'Brain Booster', N'Bổ sung DHA giúp phát triển trí não', 3200.0000, 0, 5, N'Feature 5', 4.8, N'Recommender 5', N'url5', N'Brand 5', 1, N'Béo phì độ I - Nguy cơ trung bình'),
                (NEWID(), N'Gummies', N'Kẹo dẻo giúp xương chắc khỏe', 2100.0000, 3, 10, N'Feature 6', 4.7, N'Recommender 6', N'url6', N'Brand 6', 1, N'Béo phì độ I - Nguy cơ trung bình'),
                (NEWID(), N'Probiotic', N'Giúp hỗ trợ tiêu hóa và tăng cường lợi khuẩn', 2900.0000, 0, 3, N'Feature 7', 4.4, N'Recommender 7', N'url7', N'Brand 7', 1, N'Béo phì độ II - Nguy cơ cao'),
                (NEWID(), N'Iron-Baby', N'Cháo giàu sắt giúp ngăn ngừa thiếu máu', 2600.0000, 0, 2, N'Feature 8', 4.5, N'Recommender 8', N'url8', N'Brand 8', 1, N'Béo phì độ II - Nguy cơ cao'),
                (NEWID(), N'Toddler Snack', N'Thanh ăn vặt giàu chất xơ từ ngũ cốc nguyên cám', 2000.0000, 1, 5, N'Feature 9', 4.3, N'Recommender 9', N'url9', N'Brand 9', 1, N'Béo phì độ III - Nguy cơ rất cao'),
                (NEWID(), N'Hypoallergenic', N'Sữa công thức dành cho trẻ không dung nạp lactose', 3100.0000, 0, 1, N'Feature 10', 4.2, N'Recommender 10', N'url10', N'Brand 10', 1, N'Béo phì độ III - Nguy cơ rất cao'),
                (NEWID(), N'Growth Drink', N'Cung cấp protein và vitamin hỗ trợ phát triển', 3500.0000, 2, 8, N'Feature 11', 4.9, N'Recommender 11', N'url11', N'Brand 11', 1, N'Gầy độ I - Nguy cơ thấp'),
                (NEWID(), N'Organic Green', N'Súp rau xanh hữu cơ dễ tiêu hóa', 1900.0000, 1, 4, N'Feature 12', 4.6, N'Recommender 12', N'url12', N'Brand 12', 1, N'Gầy độ I - Nguy cơ thấp'),
                (NEWID(), N'Protein-Boosted', N'Bánh quy bổ sung đạm cho trẻ suy dinh dưỡng', 2300.0000, 3, 6, N'Feature 13', 4.5, N'Recommender 13', N'url13', N'Brand 13', 1, N'Gầy độ II - Nguy cơ vừa'),
                (NEWID(), N'Powder', N'Hỗ trợ bù nước và điện giải cho trẻ', 2700.0000, 4, 12, N'Feature 14', 4.3, N'Recommender 14', N'url14', N'Brand 14', 1, N'Gầy độ II - Nguy cơ vừa'),
                (NEWID(), N'Brain Chews', N'Bổ sung Omega-3 giúp tăng cường trí não', 2800.0000, 3, 10, N'Feature 15', 4.7, N'Recommender 15', N'url15', N'Brand 15', 1, N'Gầy độ III (Rất gầy) - Nguy cơ cao'),
                (NEWID(), N'Grain Cereal', N'Ngũ cốc nguyên cám giúp hỗ trợ tiêu hóa', 2500.0000, 2, 6, N'Feature 16', 4.4, N'Recommender 16', N'url16', N'Brand 16', 1, N'Gầy độ III (Rất gầy) - Nguy cơ cao');


                -- Insert ReportProducts
                INSERT INTO ReportProducts (ReportProductId, ReportId, ProductListId) VALUES
                (NEWID(), (SELECT ReportId FROM Reports WHERE ReportName = N'Report 1'), (SELECT ProductListId FROM ProductLists WHERE ProductName = N'Multivitamin')),
                (NEWID(), (SELECT ReportId FROM Reports WHERE ReportName = N'Report 2'), (SELECT ProductListId FROM ProductLists WHERE ProductName = N'Baby Formula'));

                -- Insert Services
                INSERT INTO Services (ServiceName, ServicePrice, ServiceDescription, ServiceDuration, ServiceCreateDate, IsActive) VALUES
                (N'Gói Basic', 5000.00, N'Thời hạn trong vòng 7 ngày', 7, GETUTCDATE(), 1),
                (N'Gói Plus', 10000.00, N'Thời hạn trong vòng 14 ngày', 14, GETUTCDATE(), 1),
                (N'Gói Pro', 15000.00, N'Thời hạn trong vòng 30 ngày', 30, GETUTCDATE(), 1),
                (N'Gói Ultra', 30000.00, N'Thời hạn trong vòng 60 ngày', 60, GETUTCDATE(), 0),
                (N'Gói Đại gia', 60000.00, N'Thời hạn trong vòng 120 ngày', 120, GETUTCDATE(), 0);


            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM ReportProducts;
                DELETE FROM Ratings;
                DELETE FROM Feedbacks;
                DELETE FROM Services;
                DELETE FROM Reports;
                DELETE FROM Appointments;
                DELETE FROM Childs;
                DELETE FROM Parents;
                DELETE FROM Managers;
                DELETE FROM Doctors;
                DELETE FROM ProductLists;
                DELETE FROM Accounts;
            ");
        }
    }
}
