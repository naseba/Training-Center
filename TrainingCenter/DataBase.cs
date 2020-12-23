using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrainingCenter
{
    class DataBase
    {
		const string DBC = "Data Source=DESKTOP-NC87HB1;Initial Catalog=TrainingCenter;Integrated Security=True";
		public void CreateTables()
        {
			// Create All Tables
			const string Query = @"
							IF Not Exists (Select * from sys.tables where name like 'Trainer' )
							CREATE TABLE Trainer(
							TrainerID int NOT NULL identity(1,1) PRIMARY KEY ,
							TrainerFirstName varchar(50) NOT NULL,
							TrainerLastName varchar(50) NOT NULL,
							TrainerTitle varchar(255) NOT NULL,
							TrainerGender char(2) NOT NULL,
							TrainerBirth_date Date ,
							TrainerPhone varchar(20) NOT NULL  CHECK(TrainerPhone >=11),
							TrainerAddress varchar(255) NOT NULL,
							TrainerSalary int,
							TrainerEmail varchar(255) NOT NULL,
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Trainee' )
							CREATE TABLE Trainee(
							TraineeID int NOT NULL identity(1,1)  PRIMARY KEY,
							TraineeFirstName varchar(50) NOT NULL,
							TraineeLastName varchar(50) ,
							TraineeGender char(2) ,
							TraineePhone varchar(20) NOT NULL CHECK(TraineePhone >=11),
							TraineeEmail varchar(255) ,
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Staff' )
							CREATE TABLE Staff(
							StaffID int NOT NULL identity(1,1)  PRIMARY KEY ,
							StaffFirstName varchar(50) NOT NULL,
							StaffLastName varchar(50) NOT NULL,
							StaffPosition varchar(255) NOT NULL ,
							StaffGender char(2) NOT NULL,
							StaffBirth_date Date ,
							StaffPhone varchar(20) NOT NULL CHECK(StaffPhone>=11),
							StaffAddress varchar(255) NOT NULL,
							StaffSalary int,
							StaffEmail varchar(255) NOT NULL,
							TheRole varchar(50) NOT NULL,
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Halls' )
							CREATE TABLE Halls(
							HallID int NOT NULL identity(1,1) PRIMARY KEY ,
							HallName varchar(255) NOT NULL,
							HallCapacity varchar(255),
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Device' )
							CREATE TABLE Device(
							DeviceID int NOT NULL identity(1,1) PRIMARY KEY ,
							DeviceType varchar(255) NOT NULL,
							DeviceManufacturer varchar(255) NOT NULL,
							DeviceCondition varchar(255) NOT NULL,
							HallID int FOREIGN KEY REFERENCES Halls(HallID),
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Certification' )
							CREATE TABLE Certification(
							CertificationID int NOT NULL identity(1,1) PRIMARY KEY ,
							CertificationName varchar(255) NOT NULL,
							CertificationDescription varchar(255),
							CertificationProvider varchar(255) NOT NULL,
							CertificationDuration varchar(255),
							CertificationPrice varchar(255),
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Discount' )
							CREATE TABLE Discount(
							DiscountID int NOT NULL identity(1,1) PRIMARY KEY ,
							DisoubtAmount  varchar(50) NOT NULL,
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Course' )
							CREATE TABLE Course(
							CourseID int NOT NULL identity(1,1) PRIMARY KEY ,
							CourseName varchar(50) NOT NULL,
							CourseCategory varchar(255),
							CoursePrice int NOT NULL,
							CourseDuration varchar(100)NOT NULL,
							CourseStartDate date NOT NULL,
							CourseEndtDate date,
							CourseDeliveryMethod varchar(255) NOT NULL,
							TrainerID int FOREIGN KEY REFERENCES Trainer(TrainerID) ,
							HallID int FOREIGN KEY REFERENCES Halls(HallID),
							DiscountID int FOREIGN KEY REFERENCES Discount(DiscountID),
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Enrollments' )
							CREATE TABLE Enrollments(
							TrainerID int FOREIGN KEY REFERENCES Trainer(TrainerID) ,
							CourseID int FOREIGN KEY REFERENCES Course(CourseID) ,
							);
							
							IF Not Exists (Select * from sys.tables where name like 'Certification_Course' )
							CREATE TABLE Certification_Course(
							CertificationID int FOREIGN KEY REFERENCES Certification(CertificationID) ,
							CourseID int FOREIGN KEY REFERENCES Course(CourseID) ,
							);
							
							IF Not Exists (Select * from sys.tables where name like 'LoginData' )
							CREATE TABLE LoginData (
							ID int NOT NULL PRIMARY KEY ,
							StaffID int FOREIGN KEY REFERENCES Staff(StaffID),
							Username varchar(50) NOT NULL,
							ThePassword varchar(50) NOT NULL,
							TheRole varchar(50) NOT NULL
							);
							
							";


			SqlConnection conn = new SqlConnection(DBC);
			SqlCommand cmd = new SqlCommand(Query, conn);

			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}
    }
}
