USE registryDB;


/*Уявлення: Зведення по лікарях*/
SELECT Doctors.Name, Phone, Specialization, Qualification, Status, Offices.Office, Begin_of_the_Work_Day, Begin_of_the_Lunch_Break, End_of_the_Lunch_Break, End_of_the_Work_Day
FROM Doctors
		INNER JOIN Specializations ON Doctors.ID_Specialization = Specializations.ID_Specialization
		INNER JOIN Qualifications ON Doctors.ID_Qualification = Qualifications.ID_Qualification
		INNER JOIN Statuses ON Doctors.ID_Status = Statuses.ID_Status
		INNER JOIN Offices ON Doctors.ID_Office = Offices.ID_Office
		INNER JOIN Doctors_Schedules ON Doctors.ID_Schedule = Doctors_Schedules.ID_Schedule
ORDER BY ID_Doctor


/*Уявлення: Зведення по медичним послугам*/
SELECT ID_Service, Medical_Services.Name, Doctors.Name, Price, Additional_Information
FROM Medical_Services
		INNER JOIN Doctors ON Medical_Services.ID_Doctor = Doctors.ID_Doctor
ORDER BY ID_Service


/*Уявлення: Зведення по записам до лікарів*/
SELECT Appointment_Registration_Time, Patients.Name, Medical_Services.Name, Price, Doctors.Name
FROM
Appointments,
Patients
	INNER JOIN Genders ON Patients.ID_Gender = Genders.ID_Gender,
Medical_Services
	INNER JOIN Doctors ON Medical_Services.ID_Doctor = Doctors.ID_Doctor
ORDER BY Appointment_Registration_Time


/*Уявлення: Зведення по пацієнтам*/
SELECT Name, Gender, Date_of_Birth, Phone, Location, ID_EDRPOU,	Dispensary_Group, Contingent, Preferential_License_Number
FROM Patients
		INNER JOIN Genders ON Patients.ID_Gender = Genders.ID_Gender
		INNER JOIN (Medical_Cards
						INNER JOIN Dispensary_Groups ON Medical_Cards.ID_Dispensary_Group = Dispensary_Groups.ID_Dispensary_Group
						INNER JOIN Contingents ON Medical_Cards.ID_Contingent = Contingents.ID_Contingent
				   ) ON Patients.ID_Card = Medical_Cards.ID_Card
ORDER BY ID_Patient