CREATE TABLE RolUsers
(
	idUserRol int primary key identity(1,1),
	rolName varchar(50) not null,
	dateCreating datetime default Getdate()
);


CREATE TABLE Userlogin
(
	idUser int primary key identity(1,1),
	userName varchar(70) not null,
	userPass varchar(70) not null,
	idUserRol int not null,
	dateCreating datetime default Getdate()
);

ALTER TABLE Userlogin ADD Constraint FK_Userlogin_Roluser
FOREIGN KEY (idUserRol) REFERENCES  RolUsers (idUserRol)
Go

INSERT INTO RolUsers (rolName)
VALUES 
('Admin'),
('Supervisor'),
('User')


INSERT INTO Userlogin (userName,userPass,idUserRol)
VALUES ('202010233@gmail.com','admin',1)

SELECT COUNT(*)
FROM Userlogin
WHERE userName = '202010233@gmail.com'


SELECT *
FROM Userlogin
WHERE userName = @useName and userPass = @userPass



SELECT * 
FROM RolUsers

SELECT * FROM Userlogin
