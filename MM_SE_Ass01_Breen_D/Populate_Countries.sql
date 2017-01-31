
DROP TABLE Country;

 CREATE TABLE Country
 (Country char(40),
 CONSTRAINT pk_Country PRIMARY KEY(Country));


INSERT INTO Country VALUES('Argentina');
INSERT INTO Country VALUES('Brazil');
INSERT INTO Country VALUES('Germany');
INSERT INTO Country VALUES('England');
INSERT INTO Country VALUES('Spain');
INSERT INTO Country VALUES('France');
INSERT INTO Country VALUES('Australia');
INSERT INTO Country VALUES('New Zeland');
INSERT INTO Country VALUES('Canada');
INSERT INTO Country VALUES('United States of America');


commit;