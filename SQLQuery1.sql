/*CREATE DATABASE BeautySaloon*/

/*UPDATE Client
SET [���] = N'�������� ����� ����������'
WHERE [����� ��������] = 89646300121
*/

SELECT * FROM LogOfRecords

/*"SELECT L.N AS [����� ������], L.[���� � ����� ������] AS[���� � ����� ������], "+
"L.[������� �������] AS [������� �������], C.��� AS [��� �������] "+
"FROM LogOfRecords AS L "+ 
"LEFT JOIN Client AS C ON L.[������� �������] = C.[����� ��������] "*/

/*DROP TABLE LogOfRecords*/
/*
CREATE TABLE Client(
[���] NCHAR(50),
[����� ��������] NCHAR(12) NOT NULL UNIQUE
)
*/

/*
DROP TABLE Treatment
*/
/*
CREATE TABLE Treatment(
[�������� ���������] NCHAR(50) NOT NULL UNIQUE,
[��������� ���������] INT,
[������������] REAL, 
[��� �������] NCHAR(50)
)

CREATE TABLE LogOfRecords(
[N] INT UNIQUE NOT NULL,
[������� �������] NCHAR(12),
[���� � ����� ������] DATETIME,
[�������� ���������] NCHAR(50)
)
*/
/*"SELECT L.N AS [����� ������], L.[���� � ����� ������] AS[���� � ����� ������], "+
"L.[������� �������] AS [������� �������], C.[���] AS [��� �������], "+
"L.[�������� ���������] AS [�������� ���������], T.[��������� ���������] AS [��������� ���������], T.[������������] AS [������������], T.[��� �������] AS [��� �������] "+
"FROM LogOfRecords AS L "+ 
"LEFT JOIN Treatment AS T ON L.[�������� ���������] = T.[�������� ���������] "+
"LEFT JOIN Client AS C ON L.[������� �������] = C.[����� ��������] "

*/

/*select * from LogOfRecords*/


/*INSERT INTO Treatment VALUES (
N'�������',
2000,
2.0,
N'�������'
)*/

/*INSERT INTO Client VALUES (
'������ ���� ��������',
'8903248420'
)*/
/*SELECT MAX(N) FROM LogOfRecords*/