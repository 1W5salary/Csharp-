--建表
CREATE TABLE [User]
(
	UserId INT NOT NULL PRIMARY KEY,
	UserName VARCHAR(10) NULL,
	Password VARCHAR(50) NULL,
	RoleId INT NULL,
);

CREATE TABLE MAJOR
(
	Id INT,
	Major_Name VARCHAR(20), 
);

--插入
INSERT MAJOR(Id,Major_Name) VALUES('1',"web开发") 
