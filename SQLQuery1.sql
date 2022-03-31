/*CREATE DATABASE BeautySaloon*/

/*UPDATE Client
SET [ФИО] = N'Федотова Ирина Викторовна'
WHERE [Номер телефона] = 89646300121
*/

SELECT * FROM LogOfRecords

/*"SELECT L.N AS [Номер записи], L.[Дата и время записи] AS[Дата и время записи], "+
"L.[Телефон клиента] AS [Телефон клиента], C.ФИО AS [ФИО клиента] "+
"FROM LogOfRecords AS L "+ 
"LEFT JOIN Client AS C ON L.[Телефон клиента] = C.[Номер телефона] "*/

/*DROP TABLE LogOfRecords*/
/*
CREATE TABLE Client(
[ФИО] NCHAR(50),
[Номер телефона] NCHAR(12) NOT NULL UNIQUE
)
*/

/*
DROP TABLE Treatment
*/
/*
CREATE TABLE Treatment(
[Название процедуры] NCHAR(50) NOT NULL UNIQUE,
[Стоимость процедуры] INT,
[Длительность] REAL, 
[Имя мастера] NCHAR(50)
)

CREATE TABLE LogOfRecords(
[N] INT UNIQUE NOT NULL,
[Телефон клиента] NCHAR(12),
[Дата и время записи] DATETIME,
[Название процедуры] NCHAR(50)
)
*/
/*"SELECT L.N AS [Номер записи], L.[Дата и время записи] AS[Дата и время записи], "+
"L.[Телефон клиента] AS [Телефон клиента], C.[ФИО] AS [ФИО клиента], "+
"L.[Название процедуры] AS [Название процедуры], T.[Стоимость процедуры] AS [Стоимость процедуры], T.[Длительность] AS [Длительность], T.[Имя мастера] AS [Имя мастера] "+
"FROM LogOfRecords AS L "+ 
"LEFT JOIN Treatment AS T ON L.[Название процедуры] = T.[Название процедуры] "+
"LEFT JOIN Client AS C ON L.[Телефон клиента] = C.[Номер телефона] "

*/

/*select * from LogOfRecords*/


/*INSERT INTO Treatment VALUES (
N'Маникюр',
2000,
2.0,
N'Татьяна'
)*/

/*INSERT INTO Client VALUES (
'Иванов Иван Иванович',
'8903248420'
)*/
/*SELECT MAX(N) FROM LogOfRecords*/