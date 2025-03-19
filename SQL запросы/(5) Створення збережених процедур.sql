USE registryDB
GO



/*----------Offices----------*/
DROP PROCEDURE IF EXISTS Add_Office
GO
CREATE PROCEDURE Add_Office
	@id_office VARCHAR(10),
	@office VARCHAR(255)
AS
IF (@id_office IS NOT NULL) AND ((SELECT ID_Office FROM Offices WHERE ID_Office = @id_office) IS NULL)
	INSERT INTO Offices (ID_Office, Office)
	VALUES (@id_office, @office)
ELSE
	PRINT 'Exception: значення @id_office є пустим або існує в стовпці ID_Office таблиці Offices'
GO


DROP PROCEDURE IF EXISTS Update_Office
GO
CREATE PROCEDURE Update_Office
	@old_id_office VARCHAR(10),
	@new_id_office VARCHAR(10),
	@office VARCHAR(255)
AS
IF (@old_id_office IS NOT NULL) AND (@new_id_office IS NOT NULL)
BEGIN
	IF (@old_id_office <> @new_id_office)
		IF ((SELECT ID_Office FROM Offices WHERE ID_Office = @new_id_office) IS NULL)
			UPDATE Offices
			SET ID_Office = @new_id_office
			WHERE ID_Office = @old_id_office		
		ELSE
			SET @new_id_office = @old_id_office
	UPDATE Offices
	SET Office = @office
	WHERE ID_Office = @new_id_office
END
ELSE
	PRINT 'Exception: значення @old_id_office або @new_id_office (або обох) є пустим, або значення @new_id_office вже існує в ствопці ID_Office таблиці Offices'
GO


DROP PROCEDURE IF EXISTS Delete_Office
GO
CREATE PROCEDURE Delete_Office
	@id_office VARCHAR(10)
AS
IF (@id_office IS NOT NULL) AND ((SELECT ID_Office FROM Offices WHERE ID_Office = @id_office) IS NOT NULL) AND (@id_office <> 'Default')
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Doctors
	SET ID_Office = 'Default'
	WHERE ID_Office = @id_office
	/*Видалення значень*/
	DELETE Offices
	WHERE ID_Office = @id_office
END
ELSE
	PRINT 'Exception: значення @id_office є пустим або не існує в стовпці ID_Office таблиці Offices, або @id_office має значення Default'
GO



/*----------Qualifications----------*/
DROP PROCEDURE IF EXISTS Add_Qualification
GO
CREATE PROCEDURE Add_Qualification
	@id_qualification VARCHAR(10),
	@qualification VARCHAR(32)
AS
IF (@id_qualification IS NOT NULL) AND ((SELECT ID_Qualification FROM Qualifications WHERE ID_Qualification = @id_qualification) IS NULL)
BEGIN
	IF (@qualification IS NULL) SET @qualification = ''
	INSERT INTO Qualifications (ID_Qualification, Qualification)
	VALUES (@id_qualification, @qualification)	
END
ELSE
	PRINT 'Exception: значення @id_qualification є пустим або існує в стовпці ID_Qualification таблиці Qualifications'
GO


DROP PROCEDURE IF EXISTS Update_Qualification
GO
CREATE PROCEDURE Update_Qualification
	@old_id_qualification VARCHAR(10),
	@new_id_qualification VARCHAR(10),
	@qualification VARCHAR(32)
AS
IF (@old_id_qualification IS NOT NULL) AND (@new_id_qualification IS NOT NULL)
BEGIN
	IF (@qualification IS NULL) SET @qualification = ''
	IF (@old_id_qualification <> @new_id_qualification)
		IF ((SELECT ID_Qualification FROM Qualifications WHERE ID_Qualification = @new_id_qualification) IS NULL)
			UPDATE Qualifications
			SET ID_Qualification = @new_id_qualification
			WHERE ID_Qualification = @old_id_qualification
		ELSE
			SET @new_id_qualification = @old_id_qualification
	UPDATE Qualifications
	SET Qualification = @qualification
	WHERE ID_Qualification = @new_id_qualification
END
ELSE
	PRINT 'Exception: значення @old_id_qualification або @new_id_qualification (або обох) є пустим, або значення @new_id_qualification вже існує в ствопці ID_Qualification таблиці Qualifications'
GO


DROP PROCEDURE IF EXISTS Delete_Qualification
GO
CREATE PROCEDURE Delete_Qualification
	@id_qualification VARCHAR(10)
AS
IF (@id_qualification IS NOT NULL) AND ((SELECT ID_Qualification FROM Qualifications WHERE ID_Qualification = @id_qualification) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Doctors
	SET ID_Qualification = 'Default'
	WHERE ID_Qualification = @id_qualification
	/*Видалення значень*/
	DELETE Qualifications
	WHERE ID_Qualification = @id_qualification
END
ELSE
	PRINT 'Exception: значення @id_qualification є пустим або не існує в стовпці ID_Qualification таблиці Qualifications'
GO



/*----------Statuses----------*/
DROP PROCEDURE IF EXISTS Add_Status
GO
CREATE PROCEDURE Add_Status
	@id_status VARCHAR(10),
	@status VARCHAR(32)
AS
IF (@id_status IS NOT NULL) AND ((SELECT ID_Status FROM Statuses WHERE ID_Status = @id_status) IS NULL)
BEGIN
	IF (@status IS NULL) SET @status = ''	
	INSERT INTO Statuses (ID_Status, Status)
	VALUES (@id_status, @status)
END
ELSE
	PRINT 'Exception: значення @id_status є пустим або існує в стовпці ID_Status таблиці Statuses'
GO


DROP PROCEDURE IF EXISTS Update_Status
GO
CREATE PROCEDURE Update_Status
	@old_id_status VARCHAR(10),
	@new_id_status VARCHAR(10),
	@status VARCHAR(32)
AS
IF (@old_id_status IS NOT NULL) AND (@new_id_status IS NOT NULL)
BEGIN
	IF (@status IS NULL) SET @status = ''
	IF (@old_id_status <> @new_id_status)
		IF ((SELECT ID_Status FROM Statuses WHERE ID_Status = @new_id_status) IS NULL)
			UPDATE Statuses
			SET ID_Status = @new_id_status
			WHERE ID_Status = @old_id_status
		ELSE
			SET @new_id_status = @old_id_status
	UPDATE Statuses
	SET Status = @status
	WHERE ID_Status = @new_id_status
END
ELSE
	PRINT 'Exception: значення @old_id_status або @new_id_status (або обох) є пустим, або значення @new_id_status вже існує в ствопці ID_Status таблиці Statuses'
GO


DROP PROCEDURE IF EXISTS Delete_Status
GO
CREATE PROCEDURE Delete_Status
	@id_status VARCHAR(10)
AS
IF (@id_status IS NOT NULL) AND ((SELECT ID_Status FROM Statuses WHERE ID_Status = @id_status) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Doctors
	SET ID_Status = 'Default'
	WHERE ID_Status = @id_status
	/*Видалення значень*/
	DELETE Statuses
	WHERE ID_Status = @id_status
END
ELSE
	PRINT 'Exception: значення @id_status є пустим або не існує в стовпці ID_Status таблиці Statuses'
GO



/*----------Specializations----------*/
DROP PROCEDURE IF EXISTS Add_Specialization
GO
CREATE PROCEDURE Add_Specialization
	@id_specialization VARCHAR(10),
	@specialization VARCHAR(64)
AS
IF (@id_specialization IS NOT NULL) AND ((SELECT ID_Specialization FROM Specializations WHERE ID_Specialization = @id_specialization) IS NULL)
BEGIN
	IF (@specialization IS NULL) SET @specialization = ''
	INSERT INTO Specializations (ID_Specialization, Specialization)
	VALUES (@id_specialization, @specialization)
END
ELSE
	PRINT 'Exception: значення @id_specialization є пустим або існує в стовпці ID_Specialization таблиці Specializations'
GO


DROP PROCEDURE IF EXISTS Update_Specialization
GO
CREATE PROCEDURE Update_Specialization
	@old_id_specialization VARCHAR(10),
	@new_id_specialization VARCHAR(10),
	@specialization VARCHAR(64)
AS
IF (@old_id_specialization IS NOT NULL) AND (@new_id_specialization IS NOT NULL)
BEGIN
	IF (@specialization IS NULL) SET @specialization = ''
	IF (@old_id_specialization <> @new_id_specialization)
		IF ((SELECT ID_Specialization FROM Specializations WHERE ID_Specialization = @new_id_specialization) IS NULL)
			UPDATE Specializations
			SET ID_Specialization = @new_id_specialization
			WHERE ID_Specialization = @old_id_specialization
		ELSE
			SET @new_id_specialization = @old_id_specialization
	UPDATE Specializations
	SET Specialization = @specialization
	WHERE ID_Specialization = @new_id_specialization
END
ELSE
	PRINT 'Exception: значення @old_id_specialization або @new_id_specialization (або обох) є пустим, або значення @new_id_specialization вже існує в ствопці ID_Specialization таблиці Specializations'
GO


DROP PROCEDURE IF EXISTS Delete_Specialization
GO
CREATE PROCEDURE Delete_Specialization
	@id_specialization VARCHAR(10)
AS
IF (@id_specialization IS NOT NULL) AND ((SELECT ID_Specialization FROM Specializations WHERE ID_Specialization = @id_specialization) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Doctors
	SET ID_Specialization = 'Default'
	WHERE ID_Specialization = @id_specialization
	/*Видалення значень*/
	DELETE Specializations
	WHERE ID_Specialization = @id_specialization
END
ELSE
	PRINT 'Exception: значення @id_specialization є пустим або не існує в стовпці ID_Specialization таблиці Specializations'
GO



/*----------Doctors_Schedules----------*/
DROP PROCEDURE IF EXISTS Add_Doctors_Schedule
GO
CREATE PROCEDURE Add_Doctors_Schedule
	@id_schedule VARCHAR(10),
	@begin_of_the_work_day TIME,
	@begin_of_the_lunch_break TIME,
	@end_of_the_lunch_break TIME,
	@end_of_the_work_day TIME
AS
IF (@id_schedule IS NOT NULL) AND ((SELECT ID_Schedule FROM Doctors_Schedules WHERE ID_Schedule = @id_schedule) IS NULL)
BEGIN
	IF ((@begin_of_the_work_day IS NULL) OR (@begin_of_the_work_day = '')) SET @begin_of_the_work_day = '00:00'
	IF ((@end_of_the_work_day IS NULL) OR (@end_of_the_work_day = '')) SET @end_of_the_work_day = '23:59'
	INSERT INTO Doctors_Schedules (ID_Schedule, Begin_of_the_Work_Day, Begin_of_the_Lunch_Break, End_of_the_Lunch_Break, End_of_the_Work_Day)
	VALUES (@id_schedule, @begin_of_the_work_day, @begin_of_the_lunch_break, @end_of_the_lunch_break, @end_of_the_work_day)
END
ELSE
	PRINT 'Exception: значення @id_schedule є пустим або існує в стовпці ID_Schedule таблиці Doctors_Schedules'
GO


DROP PROCEDURE IF EXISTS Update_Doctors_Schedule
GO
CREATE PROCEDURE Update_Doctors_Schedule
	@old_id_schedule VARCHAR(10),
	@new_id_schedule VARCHAR(10),
	@begin_of_the_work_day TIME,
	@begin_of_the_lunch_break TIME,
	@end_of_the_lunch_break TIME,
	@end_of_the_work_day TIME
AS
IF (@old_id_schedule IS NOT NULL) AND (@new_id_schedule IS NOT NULL)
BEGIN
	IF ((@begin_of_the_work_day IS NULL) OR (@begin_of_the_work_day = '')) SET @begin_of_the_work_day = '00:00'
	IF ((@end_of_the_work_day IS NULL) OR (@end_of_the_work_day = '')) SET @end_of_the_work_day = '23:59'
	IF (@old_id_schedule <> @new_id_schedule)
		IF ((SELECT ID_Schedule FROM Doctors_Schedules WHERE ID_Schedule = @new_id_schedule) IS NULL)
			UPDATE Doctors_Schedules
			SET ID_Schedule = @new_id_schedule
			WHERE ID_Schedule = @old_id_schedule
		ELSE
			SET @new_id_schedule = @old_id_schedule
	UPDATE Doctors_Schedules
	SET Begin_of_the_Work_Day = @begin_of_the_work_day, Begin_of_the_Lunch_Break = @begin_of_the_lunch_break,
	End_of_the_Lunch_Break = @end_of_the_lunch_break, End_of_the_Work_Day = @end_of_the_work_day
	WHERE ID_Schedule = @new_id_schedule
END
ELSE
	PRINT 'Exception: значення @old_id_schedule або @new_id_schedule (або обох) є пустим, або значення @new_id_schedule вже існує в ствопці ID_Schedule таблиці Schedules'
GO


DROP PROCEDURE IF EXISTS Delete_Doctors_Schedule
GO
CREATE PROCEDURE Delete_Doctors_Schedule
	@id_schedule VARCHAR(10)
AS
IF (@id_schedule IS NOT NULL) AND ((SELECT ID_Schedule FROM Doctors_Schedules WHERE ID_Schedule = @id_schedule) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Doctors
	SET ID_Schedule = 'Default'
	WHERE ID_Schedule = @id_schedule
	/*Видалення значень*/
	DELETE Doctors_Schedules
	WHERE ID_Schedule = @id_schedule
END
ELSE
	PRINT 'Exception: значення @id_schedule є пустим або не існує в стовпці ID_Schedule таблиці Doctors_Schedules'
GO



/*----------Doctors----------*/
DROP PROCEDURE IF EXISTS Add_Doctor
GO
CREATE PROCEDURE Add_Doctor
	@name VARCHAR(255),
	@phone VARCHAR(16),
	@id_specialization VARCHAR(10),
	@id_qualification VARCHAR(10),
	@id_status VARCHAR(10),
	@id_office VARCHAR(10),
	@id_schedule VARCHAR(10)
AS
BEGIN
	IF (@name IS NULL) SET @name = ''
	IF (@id_specialization IS NULL) OR ((SELECT ID_Specialization FROM Specializations WHERE ID_Specialization = @id_specialization) IS NULL) SET @id_specialization = 'Default'
	IF (@id_qualification IS NULL) OR ((SELECT ID_Qualification FROM Qualifications WHERE ID_Qualification = @id_qualification) IS NULL) SET @id_qualification = 'Default'
	IF (@id_status IS NULL) OR ((SELECT ID_Status FROM Statuses WHERE ID_Status = @id_status) IS NULL) SET @id_status = 'Default'
	IF (@id_office IS NULL) OR ((SELECT ID_Office FROM Offices WHERE ID_Office = @id_office) IS NULL) SET @id_office = 'Default'
	IF (@id_schedule IS NULL) OR ((SELECT ID_Schedule FROM Doctors_Schedules WHERE ID_Schedule = @id_schedule) IS NULL) SET @id_schedule = 'Default'
	INSERT INTO Doctors (Name, Phone, ID_Specialization, ID_Qualification, ID_Status, ID_Office, ID_Schedule)
	VALUES (@name, @phone, @id_specialization, @id_qualification, @id_status, @id_office, @id_schedule)
END
GO


DROP PROCEDURE IF EXISTS Update_Doctor
GO
CREATE PROCEDURE Update_Doctor
	/*Оскільки стовпець ID_Doctor має властивість IDENTITY, змінити його неможливо*/
	@id_doctor INT,
	@name VARCHAR(255),
	@phone VARCHAR(16),
	@id_specialization VARCHAR(10),
	@id_qualification VARCHAR(10),
	@id_status VARCHAR(10),
	@id_office VARCHAR(10),
	@id_schedule VARCHAR(10)
AS
IF (@id_doctor IS NOT NULL)
BEGIN
	IF (@name IS NULL) SET @name = ''
	IF (@id_specialization IS NULL) OR ((SELECT ID_Specialization FROM Specializations WHERE ID_Specialization = @id_specialization) IS NULL) SET @id_specialization = 'Default'
	IF (@id_qualification IS NULL) OR ((SELECT ID_Qualification FROM Qualifications WHERE ID_Qualification = @id_qualification) IS NULL) SET @id_qualification = 'Default'
	IF (@id_status IS NULL) OR ((SELECT ID_Status FROM Statuses WHERE ID_Status = @id_status) IS NULL) SET @id_status = 'Default'
	IF (@id_office IS NULL) OR ((SELECT ID_Office FROM Offices WHERE ID_Office = @id_office) IS NULL) SET @id_office = 'Default'
	IF (@id_schedule IS NULL) OR ((SELECT ID_Schedule FROM Doctors_Schedules WHERE ID_Schedule = @id_schedule) IS NULL) SET @id_schedule = 'Default'
	/*Оскільки стовпець ID_Doctor має властивість IDENTITY, змінити його неможливо*/
	UPDATE Doctors
	SET Name = @name, Phone = @phone, ID_Specialization = @id_specialization, ID_Qualification = @id_qualification,
	ID_Status = @id_status, ID_Office = @id_office, ID_Schedule = @id_schedule
	WHERE ID_Doctor = @id_doctor
END
ELSE
	PRINT 'Exception: значення @id_doctor є пустим'
GO


DROP PROCEDURE IF EXISTS Delete_Doctor
GO
CREATE PROCEDURE Delete_Doctor
	@id_doctor INT
AS
IF (@id_doctor IS NOT NULL) AND ((SELECT ID_Doctor FROM Doctors WHERE ID_Doctor = @id_doctor) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Medical_Services
	SET ID_Doctor = '1'
	WHERE ID_Doctor = @id_doctor
	/*Видалення значень*/
	DELETE Doctors
	WHERE ID_Doctor = @id_doctor
END
ELSE
	PRINT 'Exception: значення @id_doctor є пустим або не існує в стовпці ID_Doctor таблиці Doctors'
GO



/*----------Medical_Services----------*/
DROP PROCEDURE IF EXISTS Add_Medical_Service
GO
CREATE PROCEDURE Add_Medical_Service
	@id_service VARCHAR(10),
	@name VARCHAR(255),
	@id_doctor INT,
	@price SMALLMONEY,
	@additional_information VARCHAR(1024)
AS
IF (@id_service IS NOT NULL) AND ((SELECT ID_Service FROM Medical_Services WHERE ID_Service = @id_service) IS NULL)
BEGIN
	IF (@name IS NULL) SET @name = ''
	IF (@id_doctor IS NULL) OR ((SELECT ID_Doctor FROM Doctors WHERE ID_Doctor = @id_doctor) IS NULL) SET @id_doctor = 1	/*ID_Doctor = 1 => значення Default*/
	IF (@price < 0) SET @price = 0
	INSERT INTO Medical_Services (ID_Service, Name, ID_Doctor, Price, Additional_Information)
	VALUES (@id_service, @name, @id_doctor, @price, @additional_information)
END
ELSE
	PRINT 'Exception: значення @id_service є пустим або існує в стовпці ID_Service таблиці Medical_Services'
GO


DROP PROCEDURE IF EXISTS Update_Medical_Service
GO
CREATE PROCEDURE Update_Medical_Service
	@old_id_service VARCHAR(10),
	@new_id_service VARCHAR(10),
	@name VARCHAR(255),
	@id_doctor INT,
	@price SMALLMONEY,
	@additional_information VARCHAR(1024)
AS
IF (@old_id_service IS NOT NULL) AND (@new_id_service IS NOT NULL)
BEGIN
	IF (@name IS NULL) SET @name = ''
	IF (@id_doctor IS NULL) OR ((SELECT ID_Doctor FROM Doctors WHERE ID_Doctor = @id_doctor) IS NULL) SET @id_doctor = 1	/*ID_Doctor = 1 => значення Default*/
	IF (@price < 0) SET @price = 0
	IF (@old_id_service <> @new_id_service)
		IF ((SELECT ID_Service FROM Medical_Services WHERE ID_Service = @new_id_service) IS NULL)
			UPDATE Medical_Services
			SET ID_Service = @new_id_service
			WHERE ID_Service = @old_id_service
		ELSE
			SET @new_id_service = @old_id_service
	UPDATE Medical_Services
	SET Name = @name, ID_Doctor = @id_doctor, Price = @price, Additional_Information = @additional_information
	WHERE ID_Service = @new_id_service
END
ELSE
	PRINT 'Exception: значення @old_id_service або @new_id_service (або обох) є пустим, або значення @new_id_service вже існує в ствопці ID_Service таблиці Medical_Services'
GO


DROP PROCEDURE IF EXISTS Delete_Medical_Service
GO
CREATE PROCEDURE Delete_Medical_Service
	@id_service VARCHAR(10)
AS
IF (@id_service IS NOT NULL) AND ((SELECT ID_Service FROM Medical_Services WHERE ID_Service = @id_service) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Appointments
	SET ID_Service = 'Default'
	WHERE ID_Service = @id_service
	/*Видалення значень*/
	DELETE Medical_Services
	WHERE ID_Service = @id_service
END
ELSE
	PRINT 'Exception: значення @id_service є пустим або не існує в стовпці ID_Service таблиці Medical_Services'
GO



/*----------Genders----------*/
DROP PROCEDURE IF EXISTS Add_Gender
GO
CREATE PROCEDURE Add_Gender
	@id_gender VARCHAR(10),
	@gender VARCHAR(128)
AS
IF (@id_gender IS NOT NULL) AND ((SELECT ID_Gender FROM Genders WHERE ID_Gender = @id_gender) IS NULL)
BEGIN
	IF (@gender IS NULL) SET @gender = ''
	INSERT INTO Genders (ID_Gender, Gender)
	VALUES (@id_gender, @gender)
END
ELSE
	PRINT 'Exception: значення @id_gender є пустим або існує в стовпці ID_Gender таблиці Genders'
GO


DROP PROCEDURE IF EXISTS Update_Gender
GO
CREATE PROCEDURE Update_Gender
	@old_id_gender VARCHAR(10),
	@new_id_gender VARCHAR(10),
	@gender VARCHAR(128)
AS
IF (@old_id_gender IS NOT NULL) AND (@new_id_gender IS NOT NULL)
BEGIN
	IF (@gender IS NULL) SET @gender = ''
	IF (@old_id_gender <> @new_id_gender)
		IF ((SELECT ID_Gender FROM Genders WHERE ID_Gender = @new_id_gender) IS NULL)
			UPDATE Genders
			SET ID_Gender = @new_id_gender
			WHERE ID_Gender = @old_id_gender
		ELSE
			SET @new_id_gender = @old_id_gender
	UPDATE Genders
	SET Gender = @gender
	WHERE ID_Gender = @new_id_gender
END
ELSE
	PRINT 'Exception: значення @old_id_gender або @new_id_gender (або обох) є пустим, або значення @new_id_gender вже існує в ствопці ID_Gender таблиці Genders'
GO


DROP PROCEDURE IF EXISTS Delete_Gender
GO
CREATE PROCEDURE Delete_Gender
	@id_gender VARCHAR(10)
AS
IF (@id_gender IS NOT NULL) AND ((SELECT ID_Gender FROM Genders WHERE ID_Gender = @id_gender) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Patients
	SET ID_Gender = 'Default'
	WHERE ID_Gender = @id_gender
	/*Видалення значень*/
	DELETE Genders
	WHERE ID_Gender = @id_gender
END
ELSE
	PRINT 'Exception: значення @id_gender є пустим або не існує в стовпці ID_Gender таблиці Genders'
GO



/*----------Dispensary_Groups----------*/
DROP PROCEDURE IF EXISTS Add_Dispensary_Group
GO
CREATE PROCEDURE Add_Dispensary_Group
	@id_dispensary_group VARCHAR(10),
	@dispensary_group VARCHAR(8)
AS
IF (@id_dispensary_group IS NOT NULL) AND ((SELECT ID_Dispensary_Group FROM Dispensary_Groups WHERE ID_Dispensary_Group = @id_dispensary_group) IS NULL)
BEGIN
	IF (@dispensary_group IS NULL) SET @dispensary_group = ''
	INSERT INTO Dispensary_Groups (ID_Dispensary_Group, Dispensary_Group)
	VALUES (@id_dispensary_group, @dispensary_group)
END
ELSE
	PRINT 'Exception: значення @id_dispensary_group є пустим або існує в стовпці ID_Dispensary_Group таблиці Dispensary_Groups'
GO


DROP PROCEDURE IF EXISTS Update_Dispensary_Group
GO
CREATE PROCEDURE Update_Dispensary_Group
	@old_id_dispensary_group VARCHAR(10),
	@new_id_dispensary_group VARCHAR(10),
	@dispensary_group VARCHAR(8)
AS
IF (@old_id_dispensary_group IS NOT NULL) AND (@new_id_dispensary_group IS NOT NULL)
BEGIN
	IF (@dispensary_group IS NULL) SET @dispensary_group = ''
	IF (@old_id_dispensary_group <> @new_id_dispensary_group)
		IF ((SELECT ID_Dispensary_Group FROM Dispensary_Groups WHERE ID_Dispensary_Group = @new_id_dispensary_group) IS NULL)
			UPDATE Dispensary_Groups
			SET ID_Dispensary_Group = @new_id_dispensary_group
			WHERE ID_Dispensary_Group = @old_id_dispensary_group
		ELSE
			SET @new_id_dispensary_group = @old_id_dispensary_group
	UPDATE Dispensary_Groups
	SET Dispensary_Group = @dispensary_group
	WHERE ID_Dispensary_Group = @new_id_dispensary_group
END
ELSE
	PRINT 'Exception: значення @old_id_dispensary_group або @new_id_dispensary_group (або обох) є пустим, або значення @new_id_dispensary_group вже існує в ствопці ID_Dispensary_Group таблиці Dispensary_Groups'
GO


DROP PROCEDURE IF EXISTS Delete_Dispensary_Group
GO
CREATE PROCEDURE Delete_Dispensary_Group
	@id_dispensary_group VARCHAR(10)
AS
IF (@id_dispensary_group IS NOT NULL) AND ((SELECT ID_Dispensary_Group FROM Dispensary_Groups WHERE ID_Dispensary_Group = @id_dispensary_group) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Medical_Cards
	SET ID_Dispensary_Group = 'Default'
	WHERE ID_Dispensary_Group = @id_dispensary_group
	/*Видалення значень*/
	DELETE Dispensary_Groups
	WHERE ID_Dispensary_Group = @id_dispensary_group
END
ELSE
	PRINT 'Exception: значення @id_dispensary_group є пустим або не існує в стовпці ID_Dispensary_Group таблиці Dispensary_Groups'
GO



/*----------Contingents----------*/
DROP PROCEDURE IF EXISTS Add_Contingent
GO
CREATE PROCEDURE Add_Contingent
	@id_contingent VARCHAR(10),
	@contingent VARCHAR(512)
AS
IF (@id_contingent IS NOT NULL) AND ((SELECT ID_Contingent FROM Contingents WHERE ID_Contingent = @id_contingent) IS NULL)
BEGIN
	IF (@contingent IS NULL) SET @contingent = ''
	INSERT INTO Contingents (ID_Contingent, Contingent)
	VALUES (@id_contingent, @contingent)
END
ELSE
	PRINT 'Exception: значення @id_contingent є пустим або існує в стовпці ID_Contingent таблиці Contingents'
GO


DROP PROCEDURE IF EXISTS Update_Contingent
GO
CREATE PROCEDURE Update_Contingent
	@old_id_contingent VARCHAR(10),
	@new_id_contingent VARCHAR(10),
	@contingent VARCHAR(512)
AS
IF (@old_id_contingent IS NOT NULL) AND (@new_id_contingent IS NOT NULL)
BEGIN
	IF (@contingent IS NULL) SET @contingent = ''
	IF (@old_id_contingent <> @new_id_contingent)
		IF ((SELECT ID_Contingent FROM Contingents WHERE ID_Contingent = @new_id_contingent) IS NULL)
			UPDATE Contingents
			SET ID_Contingent = @new_id_contingent
			WHERE ID_Contingent = @old_id_contingent
		ELSE
			SET @new_id_contingent = @old_id_contingent
	UPDATE Contingents
	SET Contingent = @contingent
	WHERE ID_Contingent = @new_id_contingent
END
ELSE
	PRINT 'Exception: значення @old_id_contingent або @new_id_contingent (або обох) є пустим, або значення @new_id_contingent вже існує в ствопці ID_Contingent таблиці Contingents'
GO


DROP PROCEDURE IF EXISTS Delete_Contingent
GO
CREATE PROCEDURE Delete_Contingent
	@id_contingent VARCHAR(10)
AS
IF (@id_contingent IS NOT NULL) AND ((SELECT ID_Contingent FROM Contingents WHERE ID_Contingent = @id_contingent) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Medical_Cards
	SET ID_Contingent = 'Default'
	WHERE ID_Contingent = @id_contingent
	/*Видалення значень*/
	DELETE Contingents
	WHERE ID_Contingent = @id_contingent
END
ELSE
	PRINT 'Exception: значення @id_contingent є пустим або не існує в стовпці ID_Contingent таблиці Contingents'
GO



/*----------Medical_Cards-----------*/
DROP PROCEDURE IF EXISTS Add_Medical_Card
GO
CREATE PROCEDURE Add_Medical_Card
	@id_card INT,
	@id_EDRPOU VARCHAR(8),
	@id_dispensary_group VARCHAR(10),
	@id_contingent VARCHAR(10),
	@preferential_license_number VARCHAR(6),
	@medical_card_registration_date DATETIME
AS
/*ID медичної карти пацієнта має співпадати з ID пацієнта*/
IF (@id_card IS NOT NULL) AND ((SELECT ID_Card FROM Medical_Cards WHERE ID_Card = @id_card) IS NULL)
BEGIN
	IF (@id_dispensary_group IS NULL) OR ((SELECT ID_Dispensary_Group FROM Dispensary_Groups WHERE ID_Dispensary_Group = @id_dispensary_group) IS NULL) SET @id_dispensary_group = 'Default'
	IF (@id_contingent IS NULL) OR ((SELECT ID_Contingent FROM Contingents WHERE ID_Contingent = @id_contingent) IS NULL) SET @id_contingent = 'Default'
	SET @medical_card_registration_date = GETDATE()
	INSERT INTO Medical_Cards (ID_Card, ID_EDRPOU, ID_Dispensary_Group, ID_Contingent, Preferential_License_Number, Medical_Card_Registration_Date)
	VALUES (@id_card, @id_EDRPOU, @id_dispensary_group, @id_contingent, @preferential_license_number, @medical_card_registration_date)
END
ELSE
	PRINT 'Exception: значення @id_card є пустим або існує в стовпці ID_Card таблиці Medical_Cards'
GO


DROP PROCEDURE IF EXISTS Update_Medical_Card
GO
CREATE PROCEDURE Update_Medical_Card
	@old_id_card INT,
	@new_id_card INT,
	@id_EDRPOU VARCHAR(8),
	@id_dispensary_group VARCHAR(10),
	@id_contingent VARCHAR(10),
	@preferential_license_number VARCHAR(6),
	@medical_card_registration_date DATETIME
AS
/*ID медичної карти пацієнта має співпадати з ID пацієнта*/
IF (@old_id_card IS NOT NULL) AND (@new_id_card IS NOT NULL)
BEGIN
	IF (@id_dispensary_group IS NULL) OR ((SELECT ID_Dispensary_Group FROM Dispensary_Groups WHERE ID_Dispensary_Group = @id_dispensary_group) IS NULL) SET @id_dispensary_group = 'Default'
	IF (@id_contingent IS NULL) OR ((SELECT ID_Contingent FROM Contingents WHERE ID_Contingent = @id_contingent) IS NULL) SET @id_contingent = 'Default'
	IF (@old_id_card <> @new_id_card)
		IF ((SELECT ID_Card FROM Medical_Cards WHERE ID_Card = @new_id_card) IS NULL)
			UPDATE Medical_Cards
			SET ID_Card = @new_id_card
			WHERE ID_Card = @old_id_card
		ELSE
			SET @new_id_card = @old_id_card
	UPDATE Medical_Cards
	SET ID_EDRPOU = @id_EDRPOU, ID_Dispensary_Group = @id_dispensary_group, ID_Contingent = @id_contingent,
		Preferential_License_Number = @preferential_license_number, Medical_Card_Registration_Date = @medical_card_registration_date
	WHERE ID_Card = @new_id_card
END
ELSE
	PRINT 'Exception: значення @old_id_card або @new_id_card (або обох) є пустим, або значення @new_id_card вже існує в ствопці ID_Card таблиці Medical_Cards'
GO


DROP PROCEDURE IF EXISTS Delete_Medical_Card
GO
CREATE PROCEDURE Delete_Medical_Card
	@id_card INT
AS
IF (@id_card IS NOT NULL) AND ((SELECT ID_Card FROM Medical_Cards WHERE ID_Card = @id_card) IS NOT NULL)
BEGIN
	/*Значення, що будуть видалені змінюються на Default у зв'язаній таблиці*/
	UPDATE Patients
	SET ID_Card = NULL
	WHERE ID_Card = @id_card
	/*Видалення значень*/
	DELETE Medical_Cards
	WHERE ID_Card = @id_card
END
ELSE
	PRINT 'Exception: значення @id_card є пустим або не існує в стовпці ID_Card таблиці Medical_Cards'
GO



/*----------Patients----------*/
DROP PROCEDURE IF EXISTS Add_Patient
GO
CREATE PROCEDURE Add_Patient
	@name VARCHAR(255),
	@id_gender VARCHAR(10),
	@date_of_birth DATETIME,
	@phone VARCHAR(13),
	@location VARCHAR(255),
	@id_card INT
AS
BEGIN
	IF (@name IS NULL) SET @name = ''
	IF (@id_gender IS NULL) OR ((SELECT ID_Gender FROM Genders WHERE ID_Gender = @id_gender) IS NULL) SET @id_gender = 'Default'
	INSERT INTO Patients (Name, ID_Gender, Date_of_Birth, Phone, Location, ID_Card)
	VALUES (@name, @id_gender, @date_of_birth, @phone, @location, @id_card)
END
GO


DROP PROCEDURE IF EXISTS Update_Patient
GO
CREATE PROCEDURE Update_Patient
	/*Оскільки стовпець ID_Patient має властивість IDENTITY, змінити його неможливо*/
	@id_patient INT,
	@name VARCHAR(255),
	@id_gender VARCHAR(10),
	@date_of_birth DATETIME,
	@phone VARCHAR(13),
	@location VARCHAR(255),
	@id_card INT
AS
BEGIN
	IF (@name IS NULL) SET @name = ''
	IF (@id_gender IS NULL) OR ((SELECT ID_Gender FROM Genders WHERE ID_Gender = @id_gender) IS NULL) SET @id_gender = 'Default'
	/*Оскільки стовпець ID_Patient має властивість IDENTITY, змінити його неможливо*/
	UPDATE Patients
	SET Name = @name, ID_Gender = @id_gender, Date_of_Birth = @date_of_birth, Phone = @phone, Location = @location, ID_Card = @id_card
	WHERE ID_Patient = @id_patient
END
GO


DROP PROCEDURE IF EXISTS Delete_Patient
GO
CREATE PROCEDURE Delete_Patient
	@id_patient INT
AS
DELETE Patients
WHERE ID_Patient = @id_patient
GO



/*----------Appointments----------*/
DROP PROCEDURE IF EXISTS Add_Appointment
GO
CREATE PROCEDURE Add_Appointment
	@appointment_registration_time DATETIME,
	@id_patient INT,
	@id_service VARCHAR(10)
AS
IF (@id_patient IS NOT NULL) AND ((SELECT ID_Patient FROM Patients WHERE ID_Patient = @id_patient) IS NOT NULL)
BEGIN
	IF (@id_service IS NULL) OR ((SELECT ID_Service FROM Medical_Services WHERE ID_Service = @id_service) IS NULL) SET @id_service = 'Default'
	INSERT INTO Appointments (Appointment_Registration_Time, ID_Patient, ID_Service)
	VALUES (@appointment_registration_time, @id_patient, @id_service)
END
ELSE
	PRINT 'Exception: значення @id_patient є пустим або існує в стовпці ID_Patient таблиці Patients'
GO


DROP PROCEDURE IF EXISTS Update_Appointment
GO
CREATE PROCEDURE Update_Appointment
	@id_appointment UNIQUEIDENTIFIER,
	@appointment_registration_time DATETIME,
	@id_patient INT,
	@id_service VARCHAR(10)
AS
IF (@id_patient IS NOT NULL)
BEGIN
	IF ((@id_service IS NULL) OR ((SELECT ID_Service FROM Medical_Services WHERE ID_Service = @id_service) IS NULL)) SET @id_service = 'Default'
	UPDATE Appointments
	SET Appointment_Registration_Time = @appointment_registration_time, ID_Patient = @id_patient, ID_Service = @id_service
	WHERE ID_Appointment = @id_appointment
END
ELSE
	PRINT 'Exception: значення @id_patient є пустим або не існує в стовпці ID_Patient таблиці Patients'
GO


DROP PROCEDURE IF EXISTS Delete_Appointment
GO
CREATE PROCEDURE Delete_Appointment
	@id_appointment UNIQUEIDENTIFIER
AS
IF (@id_appointment IS NOT NULL) AND ((SELECT ID_Appointment FROM Appointments WHERE ID_Appointment = @id_appointment) IS NOT NULL)
	DELETE Appointments
	WHERE ID_Appointment = @id_appointment
ELSE
	PRINT 'Exception: значення @id_appointment є пустим або не існує в стовпці ID_Appointment таблиці Appointments'
GO



/*----------Users----------*/
DROP PROCEDURE IF EXISTS Add_User
GO
CREATE PROCEDURE Add_User
	@name VARCHAR(255),
	@password VARCHAR(255),
	@offices VARCHAR(10),
	@specializations VARCHAR(10),
	@qualifications VARCHAR(10),
	@statuses VARCHAR(10),
	@medical_services VARCHAR(10),
	@doctors VARCHAR(10),
	@doctors_schedules VARCHAR(10),
	@appointments VARCHAR(10),
	@patients VARCHAR(10),
	@genders VARCHAR(10),
	@medical_cards VARCHAR(10),
	@dispensary_groups VARCHAR(10),
	@contingents VARCHAR(10),
	@users VARCHAR(10)
AS
IF (@name IS NOT NULL) AND ((SELECT Name FROM Users WHERE Name = @name) IS NULL)
BEGIN
	IF (@password IS NULL) SET @password = 'password'
	IF (@offices IS NULL) OR (@offices <> 'Так' AND @offices <> 'Ні') SET @offices = 'Ні'
	IF (@specializations IS NULL) OR (@specializations <> 'Так' AND @specializations <> 'Ні') SET @specializations = 'Ні'
	IF (@qualifications IS NULL) OR (@qualifications <> 'Так' AND @qualifications <> 'Ні') SET @qualifications = 'Ні'
	IF (@statuses IS NULL) OR (@statuses <> 'Так' AND @statuses <> 'Ні') SET @statuses = 'Ні'
	IF (@medical_services IS NULL) OR (@medical_services <> 'Так' AND @medical_services <> 'Ні') SET @medical_services = 'Ні'
	IF (@doctors IS NULL) OR (@doctors <> 'Так' AND @doctors <> 'Ні') SET @doctors = 'Ні'
	IF (@doctors_schedules IS NULL) OR (@doctors_schedules <> 'Так' AND @doctors_schedules <> 'Ні') SET @doctors_schedules = 'Ні'
	IF (@appointments IS NULL) OR (@appointments <> 'Так' AND @appointments <> 'Ні') SET @appointments = 'Ні'
	IF (@patients IS NULL) OR (@patients <> 'Так' AND @patients <> 'Ні') SET @patients = 'Ні'
	IF (@genders IS NULL) OR (@genders <> 'Так' AND @genders <> 'Ні') SET @genders = 'Ні'
	IF (@medical_cards IS NULL) OR (@medical_cards <> 'Так' AND @medical_cards <> 'Ні') SET @medical_cards = 'Ні'
	IF (@dispensary_groups IS NULL) OR (@dispensary_groups <> 'Так' AND @dispensary_groups <> 'Ні') SET @dispensary_groups = 'Ні'
	IF (@contingents IS NULL) OR (@contingents <> 'Так' AND @contingents <> 'Ні') SET @contingents = 'Ні'
	IF (@users IS NULL) OR (@users <> 'Так' AND @users <> 'Ні') SET @users = 'Ні'
	INSERT INTO Users (Name, Password, Offices, Specializations, Qualifications, Statuses, Medical_Services, Doctors, Doctors_Schedules, Appointments, Patients, Genders, Medical_Cards, Dispensary_Groups, Contingents, Users)
	VALUES (@name, @password, @offices, @specializations, @qualifications, @statuses, @medical_services, @doctors, @doctors_schedules, @appointments, @patients, @genders, @medical_cards, @dispensary_groups, @contingents, @users)
END
ELSE
	PRINT 'Exception: значення @name є пустим або існує в стовпці Name таблиці Users'
GO


DROP PROCEDURE IF EXISTS Update_User
GO
CREATE PROCEDURE Update_User
	@old_name VARCHAR(255),
	@new_name VARCHAR(255),
	@password VARCHAR(255),
	@offices VARCHAR(10),
	@specializations VARCHAR(10),
	@qualifications VARCHAR(10),
	@statuses VARCHAR(10),
	@medical_services VARCHAR(10),
	@doctors VARCHAR(10),
	@doctors_schedules VARCHAR(10),
	@appointments VARCHAR(10),
	@patients VARCHAR(10),
	@genders VARCHAR(10),
	@medical_cards VARCHAR(10),
	@dispensary_groups VARCHAR(10),
	@contingents VARCHAR(10),
	@users VARCHAR(10)
AS
IF (@old_name IS NOT NULL) AND (@new_name IS NOT NULL)
BEGIN
	IF (@password IS NULL) SET @password = 'password'
	IF (@offices IS NULL) OR (@offices <> 'Так' AND @offices <> 'Ні') SET @offices = 'Ні'
	IF (@specializations IS NULL) OR (@specializations <> 'Так' AND @specializations <> 'Ні') SET @specializations = 'Ні'
	IF (@qualifications IS NULL) OR (@qualifications <> 'Так' AND @qualifications <> 'Ні') SET @qualifications = 'Ні'
	IF (@statuses IS NULL) OR (@statuses <> 'Так' AND @statuses <> 'Ні') SET @statuses = 'Ні'
	IF (@medical_services IS NULL) OR (@medical_services <> 'Так' AND @medical_services <> 'Ні') SET @medical_services = 'Ні'
	IF (@doctors IS NULL) OR (@doctors <> 'Так' AND @doctors <> 'Ні') SET @doctors = 'Ні'
	IF (@doctors_schedules IS NULL) OR (@doctors_schedules <> 'Так' AND @doctors_schedules <> 'Ні') SET @doctors_schedules = 'Ні'
	IF (@appointments IS NULL) OR (@appointments <> 'Так' AND @appointments <> 'Ні') SET @appointments = 'Ні'
	IF (@patients IS NULL) OR (@patients <> 'Так' AND @patients <> 'Ні') SET @patients = 'Ні'
	IF (@genders IS NULL) OR (@genders <> 'Так' AND @genders <> 'Ні') SET @genders = 'Ні'
	IF (@medical_cards IS NULL) OR (@medical_cards <> 'Так' AND @medical_cards <> 'Ні') SET @medical_cards = 'Ні'
	IF (@dispensary_groups IS NULL) OR (@dispensary_groups <> 'Так' AND @dispensary_groups <> 'Ні') SET @dispensary_groups = 'Ні'
	IF (@contingents IS NULL) OR (@contingents <> 'Так' AND @contingents <> 'Ні') SET @contingents = 'Ні'
	IF (@users IS NULL) OR (@users <> 'Так' AND @users <> 'Ні') SET @users = 'Ні'
	IF (@old_name <> @new_name)
		IF ((SELECT Name FROM Users WHERE Name = @new_name) IS NULL)
			UPDATE Users
			SET Name = @new_name
			WHERE Name = @old_name
		ELSE
			SET @new_name = @old_name
	UPDATE Users
	SET Password = @password, Offices = @offices, Specializations = @specializations, Qualifications = @qualifications, Statuses = @statuses,
	Medical_Services = @medical_services, Doctors = @doctors, Doctors_Schedules = @doctors_schedules, Appointments = @appointments, Patients = @patients, Genders = @genders,
	Medical_Cards = @medical_cards, Dispensary_Groups = @dispensary_groups, Contingents = @contingents, Users = @users
	WHERE Name = @new_name
END
ELSE
	PRINT 'Exception: значення @old_name або @new_name (або обох) є пустим, або значення @new_name вже існує в ствопці Name таблиці Users'
GO


DROP PROCEDURE IF EXISTS Delete_User
GO
CREATE PROCEDURE Delete_User
	@name VARCHAR(255)
AS
IF (@name IS NOT NULL) AND ((SELECT Name FROM Users WHERE Name = @name) IS NOT NULL)
	DELETE Users
	WHERE Name = @name
ELSE
	PRINT 'Exception: значення @name є пустим або не існує в стовпці Name таблиці Users'
GO