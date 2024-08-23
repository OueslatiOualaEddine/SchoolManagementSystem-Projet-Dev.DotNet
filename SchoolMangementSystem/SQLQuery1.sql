CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL
)
SELECT * FROM users

INSERT users (username, password) VALUES ('admin', 'admin123')

CREATE TABLE students
(
	id INT PRIMARY KEY IDENTITY(1,1),
	student_id VARCHAR(MAX) NULL,
	student_name VARCHAR(MAX) NULL,
	student_gender VARCHAR (MAX) NULL,
	student_address VARCHAR(MAX) NULL,
	student_grade VARCHAR(MAX) NULL,
	student_section VARCHAR(MAX) NULL,
	student_image VARCHAR(MAX) NULL,
	student_status VARCHAR (MAX) NULL,
	date_insert DATE NULL,
	date_update DATE NULL,
	date_delete DATE NULL
)

SELECT * FROM students

INSERT INTO students (student_id, student_name, student_gender, student_address, student_grade, student_section, student_image, student_status, date_insert, date_update, date_delete)
VALUES
('S001', 'John Doe', 'Male', '123 Oak Street, New York', 'Grade 6', 'A', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S002', 'Jane Smith', 'Female', '456 Maple Street, Los Angeles', 'Grade 6', 'B', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S003', 'David Johnson', 'Male', '789 Pine Avenue, Chicago', 'Grade 5', 'C', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S004', 'Emily Davis', 'Female', '1011 Elm Street, Houston', 'Grade 5', 'D', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S005', 'Michael Brown', 'Male', '1213 Cedar Street, Miami', 'Grade 4', 'E', NULL, 'Graduated', GETDATE(), NULL, NULL),
('S006', 'Sarah Wilson', 'Female', '1415 Birch Street, Atlanta', 'Grade 4', 'A', NULL, 'Pending', GETDATE(), NULL, NULL),
('S007', 'Daniel Martinez', 'Male', '1617 Spruce Street, Dallas', 'Grade 3', 'B', NULL, 'Pending', GETDATE(), NULL, NULL),
('S008', 'Olivia Anderson', 'Female', '1819 Walnut Street, Seattle', 'Grade 3', 'C', NULL, 'Pending', GETDATE(), NULL, NULL),
('S009', 'William Taylor', 'Male', '2021 Ash Street, San Francisco', 'Grade 2', 'D', NULL, 'Pending', GETDATE(), NULL, NULL),
('S010', 'Sophia Thomas', 'Female', '2223 Oak Avenue, Boston', 'Grade 2', 'E', NULL, 'Graduated', GETDATE(), NULL, NULL),
('S011', 'Alexander Garcia', 'Male', '2425 Pine Street, Philadelphia', 'Grade 1', 'A', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S012', 'Sophia Martinez', 'Female', '2627 Elm Street, Phoenix', 'Grade 1', 'B', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S013', 'Mason Robinson', 'Male', '2829 Cedar Street, San Antonio', 'Grade 2', 'C', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S014', 'Amelia Clark', 'Female', '3031 Birch Street, San Diego', 'Grade 2', 'D', NULL, 'Enrolled', GETDATE(), NULL, NULL),
('S015', 'Ethan Rodriguez', 'Male', '3233 Spruce Street, San Jose', 'Grade 3', 'E', NULL, 'Graduated', GETDATE(), NULL, NULL),
('S016', 'Isabella Hernandez', 'Female', '3435 Walnut Street, Austin', 'Grade 3', 'A', NULL, 'Pending', GETDATE(), NULL, NULL),
('S017', 'Aiden Lopez', 'Male', '3637 Ash Street, Jacksonville', 'Grade 4', 'B', NULL, 'Pending', GETDATE(), NULL, NULL),
('S018', 'Mia Gonzalez', 'Female', '3839 Oak Avenue, Fort Worth', 'Grade 4', 'C', NULL, 'Pending', GETDATE(), NULL, NULL),
('S019', 'Lucas Perez', 'Male', '4041 Pine Street, Columbus', 'Grade 5', 'D', NULL, 'Pending', GETDATE(), NULL, NULL),
('S020', 'Zoe Rivera', 'Female', '4243 Elm Street, Charlotte', 'Grade 5', 'E', NULL, 'Graduated', GETDATE(), NULL, NULL),
('S021', 'Jackson Lee', 'Male', '4445 Cedar Street, Indianapolis', 'Grade 6', 'A', NULL, 'Pending', GETDATE(), NULL, NULL),
('S022', 'Charlotte Walker', 'Female', '4647 Birch Street, San Francisco', 'Grade 6', 'B', NULL, 'Pending', GETDATE(), NULL, NULL),
('S023', 'Gabriel Hall', 'Male', '4849 Spruce Street, Seattle', 'Grade 1', 'C', NULL, 'Pending', GETDATE(), NULL, NULL),
('S024', 'Lily Young', 'Female', '5051 Walnut Street, Denver', 'Grade 1', 'D', NULL, 'Pending', GETDATE(), NULL, NULL),
('S025', 'Logan White', 'Male', '5253 Ash Street, Washington', 'Grade 2', 'E', NULL, 'Graduated', GETDATE(), NULL, NULL);


CREATE TABLE teachers
(
	id int PRIMARY KEY IDENTITY(1,1),
	teacher_id VARCHAR(MAX) NULL,
	teacher_name VARCHAR(MAX) NULL,
	teacher_gender VARCHAR(MAX) NULL,
	teacher_address VARCHAR(MAX) NULL,
	teacher_image VARCHAR(MAX) NULL,
	teacher_status VARCHAR(MAX) NULL,
	date_insert DATE NULL,
	date_update DATE NULL,
	date_delete DATE NULL
)

SELECT * FROM teachers


INSERT INTO teachers (teacher_id, teacher_name, teacher_gender, teacher_address, teacher_image, teacher_status, date_insert, date_update, date_delete)
VALUES
('T001', 'Mary Johnson', 'Female', '123 Oak Street, New York', NULL, 'Active', GETDATE(), NULL, NULL),
('T002', 'James Smith', 'Male', '456 Maple Street, Los Angeles', NULL, 'Active', GETDATE(), NULL, NULL),
('T003', 'Patricia Williams', 'Female', '789 Pine Avenue, Chicago', NULL, 'Active', GETDATE(), NULL, NULL),
('T004', 'John Brown', 'Male', '1011 Elm Street, Houston', NULL, 'Active', GETDATE(), NULL, NULL),
('T005', 'Jennifer Jones', 'Female', '1213 Cedar Street, Miami', NULL, 'Active', GETDATE(), NULL, NULL),
('T006', 'Michael Davis', 'Male', '1415 Birch Street, Atlanta', NULL, 'Active', GETDATE(), NULL, NULL),
('T007', 'Linda Wilson', 'Female', '1617 Spruce Street, Dallas', NULL, 'Active', GETDATE(), NULL, NULL),
('T008', 'William Moore', 'Male', '1819 Walnut Street, Seattle', NULL, 'Active', GETDATE(), NULL, NULL),
('T009', 'Elizabeth Taylor', 'Female', '2021 Ash Street, San Francisco', NULL, 'Active', GETDATE(), NULL, NULL),
('T010', 'David Anderson', 'Male', '2223 Oak Avenue, Boston', NULL, 'Active', GETDATE(), NULL, NULL);
