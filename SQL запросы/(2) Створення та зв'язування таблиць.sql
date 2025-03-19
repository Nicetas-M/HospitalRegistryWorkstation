USE registryDB
GO


/*----------------------------------------*/
		   /*ÑÒÂÎÐÅÍÍß ÒÀÁËÈÖÜ*/

DROP TABLE IF EXISTS Appointments
GO
CREATE TABLE Appointments
(
	ID_Appointment UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	Appointment_Registration_Time DATETIME,
	ID_Patient INT NOT NULL,
	ID_Service VARCHAR(10) NOT NULL
)
GO

DROP TABLE IF EXISTS Patients
GO
CREATE TABLE Patients
(
	ID_Patient INT PRIMARY KEY IDENTITY,
	Name VARCHAR(255) NOT NULL,
	ID_Gender VARCHAR(10) NOT NULL,
	Date_of_Birth DATETIME,
	Phone VARCHAR(13),
	Location VARCHAR(255),
	ID_Card INT
)
GO

DROP TABLE IF EXISTS Genders
GO
CREATE TABLE Genders
(
	ID_Gender VARCHAR(10) PRIMARY KEY,
	Gender VARCHAR(128) NOT NULL
)
GO

DROP TABLE IF EXISTS Medical_Cards
GO
CREATE TABLE Medical_Cards
(
	ID_Card INT PRIMARY KEY,
	ID_EDRPOU VARCHAR(8),
	ID_Dispensary_Group VARCHAR(10) NOT NULL,
	ID_Contingent VARCHAR(10) NOT NULL,
	Preferential_License_Number VARCHAR(6),
	Medical_Card_Registration_Date DATETIME NOT NULL
)
GO

DROP TABLE IF EXISTS Dispensary_Groups
GO
CREATE TABLE Dispensary_Groups
(
	ID_Dispensary_Group VARCHAR(10) PRIMARY KEY,
	Dispensary_Group VARCHAR(8) NOT NULL
)
GO

DROP TABLE IF EXISTS Contingents
GO
CREATE TABLE Contingents
(
	ID_Contingent VARCHAR(10) PRIMARY KEY,
	Contingent VARCHAR(512) NOT NULL
)
GO

DROP TABLE IF EXISTS Medical_Services
GO
CREATE TABLE Medical_Services
(
	ID_Service VARCHAR(10) PRIMARY KEY,
	Name VARCHAR(255) NOT NULL,
	ID_Doctor INT,
	Price SMALLMONEY CHECK(Price >= 0),
	Additional_Information VARCHAR(1024)
)
GO

DROP TABLE IF EXISTS Doctors
GO
CREATE TABLE Doctors
(
	ID_Doctor INT PRIMARY KEY IDENTITY,
	Name VARCHAR(255) NOT NULL,
	Phone VARCHAR(16),
	ID_Specialization VARCHAR(10) NOT NULL,
	ID_Qualification VARCHAR(10) NOT NULL,
	ID_Status VARCHAR(10) NOT NULL,
	ID_Office VARCHAR(10) NOT NULL,
	ID_Schedule VARCHAR(10) NOT NULL
)
GO

DROP TABLE IF EXISTS Specializations
GO
CREATE TABLE Specializations
(
	ID_Specialization VARCHAR(10) PRIMARY KEY,
	Specialization VARCHAR(64) NOT NULL
)
GO

DROP TABLE IF EXISTS Qualifications
GO
CREATE TABLE Qualifications
(
	ID_Qualification VARCHAR(10) PRIMARY KEY,
	Qualification VARCHAR(32) NOT NULL
)
GO

DROP TABLE IF EXISTS Statuses
GO
CREATE TABLE Statuses
(
	ID_Status VARCHAR(10) PRIMARY KEY,
	Status VARCHAR(32) NOT NULL
)
GO

DROP TABLE IF EXISTS Doctors_Schedules
GO
CREATE TABLE Doctors_Schedules
(
	ID_Schedule VARCHAR(10) PRIMARY KEY,
	Begin_of_the_Work_Day TIME NOT NULL,
	Begin_of_the_Lunch_Break TIME,
	End_of_the_Lunch_Break TIME,
	End_of_the_Work_Day TIME NOT NULL,
)
GO

DROP TABLE IF EXISTS Offices
GO
CREATE TABLE Offices
(
	ID_Office VARCHAR(10) PRIMARY KEY,
	Office VARCHAR(255)
)
GO

/*Òÿáëèöÿ äëÿ íàäàííÿ äîñòóïó äî ÁÄ ïðîãðàìíî â Visual Studio*/
DROP TABLE IF EXISTS Users
GO
CREATE TABLE Users
(
	Name VARCHAR(255),
	Password VARCHAR(255),
	Offices VARCHAR(10),
	Specializations VARCHAR(10),
	Qualifications VARCHAR(10),
	Statuses VARCHAR(10),
	Medical_Services VARCHAR(10),
	Doctors VARCHAR(10),
	Doctors_Schedules VARCHAR(10),
	Appointments VARCHAR(10),
	Patients VARCHAR(10),
	Genders VARCHAR(10),
	Medical_Cards VARCHAR(10),
	Dispensary_Groups VARCHAR(10),
	Contingents VARCHAR(10),
	Users VARCHAR(10)
)
GO


/*----------------------------------------*/
		  /*ÇÂ'ßÇÓÂÀÍÍß ÒÀÁËÈÖÜ*/

ALTER TABLE Appointments
	ADD CONSTRAINT FK_Appointments_Patients FOREIGN KEY (ID_Patient)
	REFERENCES Patients (ID_Patient)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Appointments
	ADD CONSTRAINT FK_Appointments_Medical_Services FOREIGN KEY (ID_Service)
	REFERENCES Medical_Services (ID_Service)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Medical_Services
	ADD CONSTRAINT FK_Medical_Services_Doctors FOREIGN KEY (ID_Doctor)
	REFERENCES Doctors (ID_Doctor)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Patients
	ADD CONSTRAINT FK_Patients_Genders FOREIGN KEY (ID_Gender)
	REFERENCES Genders (ID_Gender)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Patients
	ADD CONSTRAINT FK_Patients_Medical_Cards FOREIGN KEY (ID_Card)
	REFERENCES Medical_Cards (ID_Card)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Medical_Cards
	ADD CONSTRAINT FK_Medical_Cards_Dispensary_Groups FOREIGN KEY (ID_Dispensary_Group)
	REFERENCES Dispensary_Groups (ID_Dispensary_Group)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Medical_Cards
	ADD CONSTRAINT FK_Medical_Cards_Contingents FOREIGN KEY (ID_Contingent)
	REFERENCES Contingents (ID_Contingent)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Doctors
	ADD CONSTRAINT FK_Doctors_Specializations FOREIGN KEY (ID_Specialization)
	REFERENCES Specializations (ID_Specialization)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Doctors
	ADD CONSTRAINT FK_Doctors_Qualifications FOREIGN KEY (ID_Qualification)
	REFERENCES Qualifications (ID_Qualification)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Doctors
	ADD CONSTRAINT FK_Doctors_Statuses FOREIGN KEY (ID_Status)
	REFERENCES Statuses (ID_Status)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Doctors
	ADD CONSTRAINT FK_Doctors_Doctors_Schedules FOREIGN KEY (ID_Schedule)
	REFERENCES Doctors_Schedules (ID_Schedule)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO

ALTER TABLE Doctors
	ADD CONSTRAINT FK_Doctors_Offices FOREIGN KEY (ID_Office)
	REFERENCES Offices (ID_Office)
	ON UPDATE CASCADE
	ON DELETE CASCADE
GO
