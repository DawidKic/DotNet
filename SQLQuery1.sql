CREATE TABLE Produkty
(
Produkty_ID int IDENTITY(1,1) PRIMARY KEY,
nazwa varchar(255),
producent varchar(255),
rok date,
ilosc int
)

CREATE TABLE Klienci
(
Produkty_ID int IDENTITY(1,1) PRIMARY KEY,
imie varchar(255),
nazwisko varchar(255),
miasto date
)

CREATE TABLE Klienci
(
Klienci_ID int IDENTITY(1,1) PRIMARY KEY,
imie varchar(255),
nazwisko varchar(255),
miasto date
)

CREATE TABLE Zamowienia
(
Zamowienia_ID int IDENTITY(1,1) PRIMARY KEY,
Klienci_ID int FOREIGN KEY REFERENCES Klienci(Klienci_ID),
Produkty_ID int FOREIGN KEY REFERENCES Produkty(Produkty_ID)
)

