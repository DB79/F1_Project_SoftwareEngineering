DROP TABLE Registrations;
DROP TABLE Drivers;
DROP TABLE Teams;
DROP TABLE Races;


CREATE TABLE Teams
(Team_ID numeric(3),
 Team_Name char(40),
 Owner_Name char(40),
 Country char(40),
 Status char(1) DEFAULT 'A',
 CONSTRAINT pk_Teams PRIMARY KEY(Team_ID),
 CONSTRAINT fk_Team_Country FOREIGN KEY(Country) REFERENCES Country);
 

CREATE TABLE Drivers
(Driver_ID numeric(3),
 Driver_Name char(40),
 Country char(40),
 Team_ID numeric(3) NOT NULL,
 Status char(1) DEFAULT 'A',
 CONSTRAINT pk_Drivers PRIMARY KEY(Driver_ID),
 CONSTRAINT fk_Drivers_Country FOREIGN KEY(Country) REFERENCES Country,
 CONSTRAINT fk_Teams FOREIGN KEY(Team_ID) REFERENCES Teams);
 
CREATE TABLE Races
(Race_ID numeric (3),
Race_Location char(40) NOT NULL,
Start_Date date NOT NULL,
CONSTRAINT pk_Races PRIMARY KEY(Race_ID));

CREATE TABLE Registrations
(Driver_ID numeric(3),
 Race_ID numeric(3),
 Race_Time numeric(8),
 Points numeric(3) DEFAULT 0,
 CONSTRAINT pk_Reg PRIMARY KEY(Driver_ID,Race_ID),
 CONSTRAINT fk_Driver FOREIGN KEY (Driver_ID) REFERENCES Drivers,
 CONSTRAINT fk_Team FOREIGN KEY(Race_ID) REFERENCES Races);
 
commit;


 
 

