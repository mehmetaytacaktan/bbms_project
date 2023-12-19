Project SQL TABLES Code (Bus Booking Management System)

TASLAK/Template:

Kullanıcılar (Users) Tablosu:

Kullanıcı Kimlik Numarası (User ID)
Ad (First Name)
Soyad (Last Name)
Kullanıcı Adı (Username)
Şifre (Password)
E-posta (Email)
Cep Telefonu (Phone Number)
vb.

Otobüsler (Buses) Tablosu:

Otobüs Kimlik Numarası (Bus ID)
Plaka Numarası (License Plate)
Otobüs Modeli (Bus Model)
Koltuk Kapasitesi (Seating Capacity)
vb.

Seferler (Trips) Tablosu:

Sefer Kimlik Numarası (Trip ID)
Kalkış Yeri (Departure Location)
Varış Yeri (Arrival Location)
Kalkış Zamanı (Departure Time)
Varış Zamanı (Arrival Time)
Kalkış tarihi (Departure Date)
Varış Tarihi (Arrival Date)
Otobüs Kimlik Numarası (Bus ID, otobüsü ilişkilendirmek için)
vb.

Rezervasyonlar (Reservations) Tablosu:

Rezervasyon Kimlik Numarası (Reservation ID)
Kullanıcı Kimlik Numarası (User ID, rezervasyonu yapan kullanıcıyı ilişkilendirmek için)
Sefer Kimlik Numarası (Trip ID, yapılan rezervasyonu belirli bir sefere bağlamak için)
Koltuk Numarası (Seat Number)
Rezervasyon Tarihi (Reservation Date)
vb.

Ödeme (Payments) Tablosu:

Ödeme Kimlik Numarası (Payment ID)
Rezervasyon Kimlik Numarası (Reservation ID, ödemeyi ilgili rezervasyona bağlamak için)
Toplam Tutar (Total Amount)
Ödeme Tarihi (Payment Date)
Ödeme Yöntemi (Payment Method)
vb.



--------------------------------------------------------------------------------------------

CREATE DATABASE BUS_BOOK_MAN_SYS

CREATE TABLE [dbo].[Users](

Pass_Id VARCHAR(11) NOT NULL PRIMARY KEY,
First_Name VARCHAR(30) NOT NULL,
Last_Name VARCHAR(30) NOT NULL,
Us_Name VARCHAR(50) NOT NULL,
Pass_Word VARCHAR(16) NOT NULL,
E_mail VARCHAR(50) NOT NULL,
Phone_Num VARCHAR(20) NOT NULL,
)


CREATE TABLE [dbo].[Buses](

Bus_Id VARCHAR(10) NOT NULL PRIMARY KEY,
Lic_Plate VARCHAR(10) NOT NULL,
Bus_Mod VARCHAR(50) NOT NULL,
Seat_Cap INT NOT NULL,
)

CREATE TABLE [dbo].[Trips](

Trip_Id VARCHAR(20) NOT NULL PRIMARY KEY,
Dep_Loc VARCHAR(50) NOT NULL,
Arr_Loc VARCHAR(50) NOT NULL,
Dep_Time TIME NOT NULL,
Arr_Time TIME NOT NULL,
Dep_Date DATE NOT NULL,
Arr_Date DATE NOT NULL,
Bus_FId VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES Buses(Bus_Id)
)

CREATE TABLE [dbo].[Reservations](

Res_Id VARCHAR(20) NOT NULL PRIMARY KEY,
User_FId VARCHAR(11) NOT NULL FOREIGN KEY REFERENCES Users(Pass_Id),
Trip_FId VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Trips(Trip_Id),
Seat_Num INT NOT NULL,
Res_Date DATE NOT NULL,
)

CREATE TABLE [dbo].[Payments](

Payment_Id VARCHAR(30) NOT NULL PRIMARY KEY,
Res_FId VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Reservations(Res_Id),
Tot_Am INT NOT NULL,
Pay_Date DATE NOT NULL,
Pay_Meth VARCHAR(40) NOT NULL,
)


	
