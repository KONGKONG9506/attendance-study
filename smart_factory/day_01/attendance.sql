-- Students 테이블
CREATE TABLE Students (
    student_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50),
    gender ENUM('M','F'),
    enrollment_date DATE
);

-- Attendance 테이블
CREATE TABLE Attendance (
    attendance_id INT PRIMARY KEY AUTO_INCREMENT,
    student_id INT,
    date DATE,
    status ENUM('출석','지각','결석','조퇴'),
    FOREIGN KEY (student_id) REFERENCES Students(student_id)
);

-- Classes 테이블
CREATE TABLE Classes (
    class_id INT PRIMARY KEY AUTO_INCREMENT,
    class_name VARCHAR(100),
    class_time TIME
);

INSERT INTO students (name, gender, enrollment_date) values
('홍길동', 'm' , '2024-03-01'),
('김영희', 'f' , '2024-03-01'),
('이철수', 'm' , '2024-03-01');

alter table attendance change column data date date;

INSERT INTO attendance (student_id, date, status) values
(1,  CURDATE(), '출석'),
(2,  CURDATE(), '지각'),
(3,  CURDATE(), '결석');

select * from attendance;