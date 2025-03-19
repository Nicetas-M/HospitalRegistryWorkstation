USE registryDB
GO


/*Створення логінів*/

DROP LOGIN Admin
GO
CREATE LOGIN Admin
	WITH PASSWORD = 'Admin'
GO

DROP LOGIN Receptionist
GO
CREATE LOGIN Receptionist
	WITH PASSWORD = 'Receptionist'
GO
	

/*Створення користувачів*/

DROP USER IF EXISTS Admin
CREATE USER Admin FOR LOGIN Admin
GO
--Видача ролей користувау Admin
ALTER ROLE db_ddladmin ADD MEMBER Admin
ALTER ROLE db_accessadmin ADD MEMBER Admin
ALTER ROLE db_securityadmin ADD MEMBER Admin
GO

DROP USER IF EXISTS Receptionist
CREATE USER Receptionist FOR LOGIN Receptionist
GO


/*Надання привілеїв користувачам*/

--Receptionist
GRANT DELETE, INSERT, SELECT, UPDATE ON Appointments TO Receptionist
GRANT DELETE, INSERT, SELECT, UPDATE ON Patients TO Receptionist
GRANT DELETE, INSERT, SELECT, UPDATE ON Medical_Cards TO Receptionist
GRANT SELECT ON Genders TO Receptionist
GRANT SELECT ON Dispensary_Groups TO Receptionist
GRANT SELECT ON Contingents TO Receptionist
GRANT SELECT ON Medical_Services TO Receptionist
GRANT SELECT ON Doctors TO Receptionist
GRANT SELECT ON Offices TO Receptionist
GRANT SELECT ON Specializations TO Receptionist
GRANT SELECT ON Qualifications TO Receptionist
GRANT SELECT ON Statuses TO Receptionist
GRANT SELECT ON Doctors_Schedules TO Receptionist
GO
GRANT EXECUTE ON Add_Appointment TO Receptionist
GRANT EXECUTE ON Update_Appointment TO Receptionist
GRANT EXECUTE ON Delete_Appointment TO Receptionist
GRANT EXECUTE ON Add_Patient TO Receptionist
GRANT EXECUTE ON Update_Patient TO Receptionist
GRANT EXECUTE ON Delete_Patient TO Receptionist
GRANT EXECUTE ON Add_Medical_Card TO Receptionist
GRANT EXECUTE ON Update_Medical_Card TO Receptionist
GRANT EXECUTE ON Delete_Medical_Card TO Receptionist
GO
