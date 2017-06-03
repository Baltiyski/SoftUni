Problem 1. Create Database
 CREATE DATABASE minions; 

Problem 2. Create Tables
 CREATE TABLE minions(
 	id INT NOT NULL,
     name VARCHAR(50),
     age INT,
     PRIMARY KEY (id)
 );
 
 CREATE TABLE towns(
 	id INT NOT NULL,
     name VARCHAR(50),
     PRIMARY KEY (id)

Problem 3. Alter Minions Table
 ALTER TABLE minions ADD COLUMN town_id INT;
 ALTER TABLE minions ADD CONSTRAINT fk_minions_towns 
 FOREIGN KEY(town_id)
 REFERENCES towns(id);

Problem 4. Insert Records in Both Tables
 INSERT INTO towns(id, name)
 VALUES (1, 'Sofia'),
 (2, 'Plovdiv'),
 (3, 'Varna');
 
 INSERT INTO minions(id, name, age, town_id)
 VALUES (1, 'Kevin', 22, 1),
 (2, 'Bob', 15, 3),
 (3, 'Steward', NULL, 2);

Problem 5. Truncate Table Minions
 TRUNCATE TABLE minions;

Problem 6. Drop All Tables
 DROP TABLE minions;
 DROP TABLE towns;

Problem 7. Create Table People
 CREATE TABLE people(
 	id INT UNIQUE AUTO_INCREMENT,
     name VARCHAR(200) NOT NULL,
     picture BLOB,
     height FLOAT(2),
     weight FLOAT(2),
     gender ENUM('m', 'f') NOT NULL,
     birthdate DATE NOT NULL,
     biography TEXT(65536),
     CONSTRAINT pk_people PRIMARY KEY (id)
 );
 
 INSERT INTO people(name, height, weight, gender, birthdate, biography)
 VALUES ('Gosho', 1.90, 80, 'm', '1990-10-30', 'Game changer awf23f23ff, "asvr"'),
 ('Pesho', 1.80, 100, 'm', '1990-10-30', 'Game changer awf23f23ff, "asvr"'),
 ('Mitaka', 1.75, 60, 'm', '1990-10-30', 'Game changer awf23f23ff, "asvr"'),
 ('Mitaka', 1.75, 60, 'm', '1990-10-30', 'Game changer awf23f23ff, "asvr"'),
 ('Mitaka', 1.75, 60, 'm', '1990-10-30', 'Game changer awf23f23ff, "asvr"');

Problem 8. Create Table Users
 CREATE TABLE users(
 	id BIGINT UNIQUE AUTO_INCREMENT,
     username VARCHAR(30) NOT NULL,
     password VARCHAR(26) NOT NULL,
     profile_picture LONGBLOB,
     last_login_time DATE,
     is_deleted TINYINT,
     CONSTRAINT pk_users PRIMARY KEY (id)
 );
 
 INSERT INTO users(username, password, last_login_time, is_deleted)
 VALUES('Bobi', '1234', '2017-02-01', True),
 ('Vanq', '8752', '2017-11-02', False),
 ('Sami', 'gonqkuchi', '2017-12-01', False),
 ('Momi', 'vsichko12Ne davam', '2016-10-01', False),
 ('Asencho', '1234', '2015-04-01', True);

Problem 9. Change Primary Key
 ALTER TABLE users
 DROP PRIMARY KEY,
 ADD CONSTRAINT pk_users PRIMARY KEY(id, username);

Problem 10. Set Default Value of a Field
 ALTER TABLE users
 MODIFY COLUMN last_login_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP;

Problem 11. Set Unique Field
 ALTER TABLE users
 DROP PRIMARY KEY,
 ADD CONSTRAINT pk_users PRIMARY KEY(id),
 ADD CONSTRAINT uq_username UNIQUE(username);

Problem 12. Movies Database
 INSERT INTO movies (title, director_id, genre_id, category_id, rating)
 VALUES ('The Circle', 1, 1, 3, 6.7), ('The Fate of the Furious', 3, 3, 3, 9.7), ('Alien: Convenant', 4, 4, 4, 7.9), 
 ('Boss Baby', 2, 2, 2, 5.4), ('Three Little Wolves', 5, 2, 1, 4.8);

Problem 13. Car Rental Database
 CREATE DATABASE car_rental;
 
 USE car_rental;
 
 CREATE TABLE categories (
     id INT NOT NULL AUTO_INCREMENT,
     category VARCHAR(30) NOT NULL,
     daily_rate FLOAT,
     weekly_rate FLOAT,
     monthly_rate FLOAT,
     weekend_rate FLOAT,
     CONSTRAINT pk_categories PRIMARY KEY (id)
 );
 
 CREATE TABLE cars (
     id INT NOT NULL AUTO_INCREMENT,
     plate_number VARCHAR(10) NOT NULL,
     make VARCHAR(20),
     model VARCHAR(20),
     car_year DATE,
     category_id INT,
     doors INT(1),
     picture BLOB,
     car_condition TEXT,
     available TINYINT,
     CONSTRAINT pk_cars PRIMARY KEY (id)
 );
 
 CREATE TABLE employees (
     id INT NOT NULL AUTO_INCREMENT,
     first_name VARCHAR(20) NOT NULL,
     last_name VARCHAR(20) NOT NULL,
     title VARCHAR(50),
     notes TEXT,
     CONSTRAINT pk_employees PRIMARY KEY (id)
 );
 
 CREATE TABLE customers (
     id INT NOT NULL AUTO_INCREMENT,
     driver_licence_number BIGINT,
     full_name VARCHAR(50) NOT NULL,
     address VARCHAR(255),
     city VARCHAR(20),
     zip_code INT,
     notes TEXT,
     CONSTRAINT pk_customers PRIMARY KEY (id)
 );
 
 CREATE TABLE rental_orders (
     id INT NOT NULL AUTO_INCREMENT,
     employee_id INT,
     customer_id INT,
     car_id INT,
     car_condition TEXT,
     tank_level DOUBLE,
     kilometrage_start DOUBLE,
     kilometrage_end DOUBLE,
     total_kilometrage DOUBLE,
     start_date DATE,
     end_date DATE,
     total_days INT,
     rate_applied FLOAT(2),
     tax_rate FLOAT(2),
     order_status TINYINT,
     notes TEXT,
     CONSTRAINT pk_rental_orders PRIMARY KEY (id)
 );
 
 INSERT INTO categories (category, daily_rate, monthly_rate)
 VALUES ('Manual', 15.9, 477), ('Automatic', 7.8, 234.8), ('Cargo Van', 19.1, 553.4);
 
 INSERT INTO cars (plate_number, make, model, category_id, doors, car_condition, available)
 VALUES ('CA2233EM', 'Ford', 'Fiesta', 2, 5, 'The car is rented with full tank and the fuel consumption is on renter’s expenses.', TRUE),
 ('EH9928KL', 'Ford', 'Transit', 3, 5, 'There is an option to prepay a full tank of fuel at the beginning of the rental at the price at the gas stations.', FALSE),
 ('OB6281DK', 'Ford', 'Mondeo', 1, 5, 'The car is rented with full tank and the fuel consumption is on renter’s expenses. If you return the car with less fuel, the missing fuel will be charged € 3.50 per liter.', TRUE);
 
 INSERT INTO employees (first_name, last_name)
 VALUES ('Plamen', 'Petrov'), ('Mihail', 'Mihailov'), ('Petar', 'Petrov');
 
 INSERT INTO customers (full_name, city)
 VALUES ('Ivanov', 'Sofia'), ('Kisiov', 'Pleven'), ('Belev', 'Lovech');
 
 INSERT INTO rental_orders (employee_id, customer_id, car_id, order_status)
 VALUES (1, 2, 3, TRUE), (3, 1, 1, TRUE), (2, 3, 2, FALSE);

Problem 14. Hotel Database
 CREATE DATABASE hotel;
 
 USE hotel;
 
 CREATE TABLE employees (
     id INT NOT NULL AUTO_INCREMENT,
     first_name VARCHAR(50) NOT NULL,
     last_name VARCHAR(50) NOT NULL,
     title VARCHAR(30),
     notes TEXT,
     CONSTRAINT pk_employees PRIMARY KEY (id)
 );
 
 CREATE TABLE customers (
     account_number VARCHAR(20) NOT NULL,
     first_name VARCHAR(30) NOT NULL,
     last_name VARCHAR(30) NOT NULL,
     phone_number VARCHAR(15),
     emergency_name VARCHAR(30),
     emergency_number INT,
     notes TEXT,
     CONSTRAINT pk_customers PRIMARY KEY (account_number)
 );
 
 CREATE TABLE room_status (
     room_status VARCHAR(10) NOT NULL,
     notes TEXT,
     CONSTRAINT pk_room_status PRIMARY KEY (room_status)
 );
 
 CREATE TABLE room_types (
     room_type VARCHAR(20) NOT NULL,
     notes TEXT,
     CONSTRAINT pk_room_types PRIMARY KEY (room_type)
 );
 
 CREATE TABLE bed_types (
     bed_type VARCHAR(10) NOT NULL,
     notes TEXT,
     CONSTRAINT pk_bed_types PRIMARY KEY (bed_type)
 );
 
 CREATE TABLE rooms (
     room_number INT(4) NOT NULL AUTO_INCREMENT,
     room_type VARCHAR(20),
     bed_type VARCHAR(10),
     rate DECIMAL,
     room_status VARCHAR(10),
     notes TEXT,
     CONSTRAINT pk_rooms PRIMARY KEY (room_number)
 );
 
 CREATE TABLE payments (
     id INT NOT NULL AUTO_INCREMENT,
     employee_id INT,
     payment_date DATE,
     account_number VARCHAR(20),
     first_date_occupied DATE,
     last_date_occupied DATE,
     total_days INT,
     amount_charged DECIMAL,
     tax_rate FLOAT,
     tax_amount FLOAT,
     payment_total DECIMAL(8, 2),
     notes TEXT,
     CONSTRAINT pk_payments PRIMARY KEY (id)
 );
 
 CREATE TABLE occupancies (
     id INT NOT NULL AUTO_INCREMENT,
     employee_id INT,
     date_occupied DATE,
     account_number VARCHAR(20),
     room_number INT(4),
     rate_applied FLOAT,
     phone_charge FLOAT,
     notes TEXT,
     CONSTRAINT pk_occupancies PRIMARY KEY (id)
 );
 
 INSERT INTO employees (first_name, last_name)
 VALUES ('Maria', 'Ivanova'), ('Svetla', 'Petrova'), ('Galya', 'Mihova');
 
 INSERT INTO customers (account_number, first_name, last_name, phone_number)
 VALUES ('3728FHCJ738291', 'Ivan', 'Petrov', '0888332289'), ('5848PVQM329048', 'Iva', 'Georgieva', '0883987654'),
 ('4589DKSL654789', 'Hristo', 'Stoyanov', '0878654124');
 
 INSERT INTO room_status (room_status)
 VALUES ('occupied'), ('free'), ('reserved');
 
 INSERT INTO room_types (room_type)
 VALUES ('Single room'), ('Double room'), ('Family studio');
 
 INSERT INTO bed_types (bed_type)
 VALUES ('Single'), ('Double'), ('Mixed');
 
 INSERT INTO rooms (room_type, bed_type, room_status)
 VALUES ('Single room', 'Double', 'free'), ('Family studio', 'Mixed', 'occupied'), ('Double room', 'Single', 'reserved');
 
 INSERT INTO payments (employee_id, account_number, first_date_occupied, last_date_occupied, total_days, payment_total)
 VALUES (1, '3728FHCJ738291', '2017-05-01', '2017-05-05', 4, 636.62),
 (3, '5848PVQM329048', '2017-03-09', '2017-03-10', 1, 55.70),
 (2, '4589DKSL654789', '2016-12-10', '2016-12-20', 10, 1024.89);
 
 INSERT INTO occupancies (employee_id, room_number)
 VALUES (1, 3), (2, 1), (3, 2);

Problem 15. Create SoftUni Database
 CREATE DATABASE softuni;
 
 USE softuni;
 
 CREATE TABLE towns (
     id INT NOT NULL AUTO_INCREMENT,
     name VARCHAR(20),
     CONSTRAINT pk_towns PRIMARY KEY (id)
 );
 
 CREATE TABLE addresses (
     id INT NOT NULL AUTO_INCREMENT,
     address_text TEXT,
     town_id INT,
     CONSTRAINT pk_addresses PRIMARY KEY (id),
     CONSTRAINT fk_addresses_towns FOREIGN KEY (town_id)
         REFERENCES towns (id)
 );
 
 CREATE TABLE departments (
     id INT NOT NULL AUTO_INCREMENT,
     name VARCHAR(50),
     CONSTRAINT pk_departments PRIMARY KEY (id)
 );
 
 CREATE TABLE employees (
     id INT NOT NULL AUTO_INCREMENT,
     first_name VARCHAR(20) NOT NULL,
     middle_name VARCHAR(20),
     last_name VARCHAR(20) NOT NULL,
     job_title VARCHAR(50),
     department_id INT,
     hire_date DATE,
     salary DECIMAL(10,2),
     address_id INT,
     CONSTRAINT pk_employees PRIMARY KEY (id),
     CONSTRAINT fk_employees_departments FOREIGN KEY (department_id)
         REFERENCES departments (id),
     CONSTRAINT fk_employees_addresses FOREIGN KEY (address_id)
         REFERENCES addresses (id)
 );

Problem 17. Basic Insert
 INSERT INTO towns (name)
 VALUES ('Sofia'), ('Plovdiv'), ('Varna'), ('Burgas');
 
 INSERT INTO departments (name)
 VALUES ('Engineering'), ('Sales'), ('Marketing'), ('Software Development'), ('Quality Assurance');
 
 INSERT INTO employees (first_name, middle_name, last_name, job_title, department_id, hire_date, salary)
 VALUES ('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00), ('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00),
 ('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25), ('Georgi', 'Terziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00),
 ('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88 );

Problem 18. Basic Select All Fields
 SELECT * 
 FROM towns;
 
 SELECT *
 FROM departments;
 
 SELECT * 
 FROM employees;

Problem 19. Basic Select All Fields and Order Them
 SELECT * 
 FROM towns
 ORDER BY name ASC;
 
 SELECT *
 FROM departments
 ORDER BY name ASC;
 
 SELECT * 
 FROM employees
 ORDER BY salary DESC;

Problem 20. Basic Select Some Fields
 SELECT t.name 
 FROM towns AS t
 ORDER BY t.name ASC;
 
 SELECT d.name
 FROM departments AS d
 ORDER BY d.name ASC;
 
 SELECT e.first_name, e.last_name, e.job_title, e.salary 
 FROM employees AS e
 ORDER BY salary DESC;

Problem 21. Increase Employees Salary
 UPDATE employees
 SET salary = salary + (salary * 0.1);
 
 SELECT salary
 FROM employees;

Problem 22. Decrease Tax Rate
 SELECT tax_rate
 FROM payments

Problem 23. Delete All Records
 TRUNCATE TABLE occupancies;

