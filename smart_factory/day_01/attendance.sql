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