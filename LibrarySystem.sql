DROP TABLE Payments;
DROP TABLE Fines;
DROP TABLE LoanBooks;
DROP TABLE Loans;
DROP TABLE Books;
DROP TABLE Members;
DROP TABLE Genres;
DROP TABLE Counties;
 

-- Genres

CREATE TABLE Genres (
	Code CHAR(2),
Name VARCHAR2(25) NOT NULL,
	CONSTRAINT PK_Code_g PRIMARY KEY (Code)
);

 

 INSERT INTO Genres VALUES (
'AC', 'Action'
);

INSERT INTO Genres VALUES (
'ad', 'adventure'
);



INSERT INTO Genres VALUES (
'AA', 'Art/architecture'
);

INSERT INTO Genres VALUES (
'AH', 'Alternate history'
);

INSERT INTO Genres VALUES (
'AB', 'Autobiography'
);
INSERT INTO Genres VALUES (
'AT', 'Anthology'
);


INSERT INTO Genres VALUES (
'BI', 'Biography'
);

INSERT INTO Genres VALUES (
'CL', 'Chick lit'
);

INSERT INTO Genres VALUES (
'BE', 'Business/economics'
);

INSERT INTO Genres VALUES (
'CH', 'Children'
);

INSERT INTO Genres VALUES (
'CB', 'Crafts/hobbies'
);

INSERT INTO Genres VALUES (
'CS', 'Classic'
);

INSERT INTO Genres VALUES (
'CK', 'Cookbook'
);

INSERT INTO Genres VALUES (
'CM', 'Comic book'
);

INSERT INTO Genres VALUES (
'DI', 'Diary'
);


INSERT INTO Genres VALUES (
'DC', 'Dictionary'
);


INSERT INTO Genres VALUES (
'CR', 'Crime'
);

INSERT INTO Genres VALUES (
'EN', 'Encyclopedia'
);

INSERT INTO Genres VALUES (
'DR', 'Drama'
);

INSERT INTO Genres VALUES (
'FA' , 'Fairytale'
);

INSERT INTO Genres VALUES (
'HF', 'Health/fitness'
);
INSERT INTO Genres VALUES (
'FN', 'Fantasy'
);
INSERT INTO Genres VALUES (
'HI', 'History'
);

INSERT INTO Genres VALUES (
'NO', 'novel'
);


INSERT INTO Genres VALUES ( 
'HC', 'Historical fiction'
);

INSERT INTO Genres VALUES (
'HU', 'Humor'
);

INSERT INTO Genres VALUES (
'HO', 'Horror'
);



INSERT INTO Genres VALUES (
'MI', 'Mystery'
);

INSERT INTO Genres VALUES ( 
'RO', 'romance'
);

INSERT INTO Genres VALUES ( 
'SF', 'Science fiction'
);

INSERT INTO Genres VALUES ( 
'RE', 'Review'
);


INSERT INTO Genres VALUES ( 
'SC', 'Science'
);

INSERT INTO Genres VALUES ( 
'SU', 'Suspense'
);

INSERT INTO Genres VALUES ( 
'SH', 'Self help'
);

INSERT INTO Genres VALUES ( 
'TH', 'Thriller'
);
INSERT INTO Genres VALUES ( 
'SL', 'Sports and leisure'
);

INSERT INTO Genres VALUES ( 
'WE', 'Western'
);
INSERT INTO Genres VALUES ( 
'TR', 'Travel'
);

INSERT INTO Genres VALUES ( 
'YA', 'Young adult'
);


INSERT INTO Genres VALUES ( 
'TE', 'Technology'
);

-- end Genres

-- Counties 
CREATE TABLE counties(
Code char(2),
Name varchar2(20) NOT NULL,
CONSTRAINT pk_code PRIMARY KEY (Code)
 );


INSERT INTO counties VALUES (
'AN', 'Antrim'
);

INSERT INTO counties VALUES (
'AR', 'Armagh'
);

INSERT INTO counties VALUES (
'CA', 'Carlow'
);

INSERT INTO counties VALUES (
'CV', 'Cavan'
);

INSERT INTO counties VALUES (
'CL', 'Clare'
);


INSERT INTO counties VALUES (
'CO', 'Cork'
);


INSERT INTO counties VALUES (
'DE', 'Derry'
);



INSERT INTO counties VALUES (
'DO', 'Donegal'
);


INSERT INTO counties VALUES (
'DW', 'Down'
);


INSERT INTO counties VALUES (
'DU', 'Dublin'
);


INSERT INTO counties VALUES (
'FE', 'Fermanagh'
);


INSERT INTO counties VALUES (
'GA', 'Galway'
);


INSERT INTO counties VALUES (
'KE', 'Kerry'
);
INSERT INTO counties VALUES (
'KI', 'Kildare'
);



INSERT INTO counties VALUES (
'KL', 'Kilkenny'
);




INSERT INTO counties VALUES (
'LA', 'Laois'
);


INSERT INTO counties VALUES (
'LE', 'Leitrim'
);



INSERT INTO counties VALUES (
'LM', 'Limerick'
);




INSERT INTO counties VALUES (
'LO', 'Longford'
);


INSERT INTO counties VALUES (
'LU', 'Louth'
);


INSERT INTO counties VALUES (
'MA', 'Mayo'
);


INSERT INTO counties VALUES (
'ME', 'Meath'
);


INSERT INTO counties VALUES (
'OF', 'Offaly'
);





INSERT INTO counties VALUES (
'RO', 'Roscommon'
);


INSERT INTO counties VALUES (
'SL', 'Sligo'
);


INSERT INTO counties VALUES (
'TI', 'Tipperary'
);



INSERT INTO counties VALUES (
'TY', 'Tyrone'
);



INSERT INTO counties VALUES (
'WA', 'Waterford'
);


INSERT INTO counties VALUES (
'WE', 'Westmeath'
);


INSERT INTO counties VALUES (
'WX', 'Wexford'
);


INSERT INTO counties VALUES (
'WI', 'Wicklow'
);
 
-- end counties

CREATE TABLE Books (
	BookID NUMERIC(6) ,
	Title VARCHAR2(30) NOT NULL  ,
	Author VARCHAR2(30) NOT NULL  ,
	Publisher VARCHAR2(25) NOT NULL  ,
	Year NVARCHAR2(4) NOT NULL  ,
	Edition VARCHAR2(25) NOT NULL  ,
	Genre CHAR(2) NOT NULL  ,
	ISBN  VARCHAR2(20) NOT NULL  ,
	Status CHAR(1) NOT NULL,
	CONSTRAINT pk_BookID PRIMARY KEY (BookID),
	CONSTRAINT FK_Genre FOREIGN KEY (Genre) REFERENCES Genres(Code)
);

INSERT INTO Books VALUES(1, 'Cantares gallegos', 'Rosalia de Castro', 'Xerais', 1863, '15 Edicion literaria', 'RO', '8475075061', 'A'); 


CREATE TABLE Members (
	MemberID NUMERIC(6) ,
	Forename VARCHAR2(20) NOT NULL  ,
	Surname VARCHAR2(30) NOT NULL  ,
	Street VARCHAR2(50) NOT NULL  ,
	Town VARCHAR2(20) NOT NULL  ,
	County CHAR(2) NOT NULL  ,
	Eircode CHAR(7) NOT NULL  ,
	Phone CHAR(10) NOT NULL  ,
	Email VARCHAR2(100)   ,
	DOB Date NOT NULL  ,
	Status CHAR(1) ,
	CONSTRAINT PK_MemberID PRIMARY KEY (MemberID),
	CONSTRAINT FK_County FOREIGN KEY (County) REFERENCES Counties(Code)
);

INSERT INTO Members VALUES(1, 'Ivan', 'Segade Carou', 'Center', 'Tralee', 'KE', 'V92IF68', '0888888888', 'ivan@segade.carou', '21-OCT-1981', 'A');


CREATE TABLE Loans (
	LoanID NUMERIC(9)  ,
	MemberID NUMERIC(6) NOT NULL  ,
	LoanDate Date NOT NULL ,
	DueDate DATE,
	CONSTRAINT PK_LoanID PRIMARY KEY (LoanID),
	CONSTRAINT FK_MemberID FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
 );


CREATE TABLE LoanBooks ( 
--	LoanBookID NUMERIC(10),
	LoanID NUMERIC(9) NOT NULL,
	BookID NUMERIC(6) NOT NULL,
	BackDate DATE NOT NULL,
	Status CHAR(1) NOT NULL,
	CONSTRAINT PK_LoanBookID PRIMARY KEY (LoanID, BookID),
	CONSTRAINT FK_LoanID_LB_LB FOREIGN KEY (LoanID) REFERENCES Loans(LoanID),
	CONSTRAINT FK_BookID_LB FOREIGN KEY (BookID) REFERENCES Books(BookID)
);



CREATE TABLE Fines (
	FineID NUMERIC(6) ,
	LoanID NUMERIC(9) NOT NULL,
	BookID NUMERIC(6) NOT NULL,
	Amount NUMERIC(5,2) NOT NULL,
	FineDate date NOT NULL,
	Status CHAR(1)  NOT NULL,
	CONSTRAINT PK_FineID PRIMARY KEY (FineID),
	CONSTRAINT FK_LoanBookID_F FOREIGN KEY (LoanID, BookID) REFERENCES LoanBooks(LoanID, BookID)
);



CREATE TABLE Payments (
	TransID NUMERIC(10),
	FineID NUMERIC( 6) NOT NULL,
	Amount NUMERIC(5,2) NOT NULL,
	PayDate date NOT NULL,
	CONSTRAINT PK_TransID PRIMARY KEY (TransID),
	CONSTRAINT FK_FineID FOREIGN KEY (FineID) REFERENCES Fines(FineID)
);


COMMIT;