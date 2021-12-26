CREATE TABLE Aliases(
Alias_ID NUMBER(6),
Criminal_ID NUMBER(6),
Alias VARCHAR(10)
);

CREATE TABLE Criminals(
Criminal_ID NUMBER(6,0),
Last VARCHAR(15),
First VARCHAR(10),
Street VARCHAR(30),
City VARCHAR(20),
State CHAR(2),
Zip CHAR(5),
Phone CHAR(10),
V_status CHAR(1)['N'],
P_status CHAR(1)['N']
);

CREATE TABLE Crimes(
Crime_ID NUMBER(9,0),
Criminal_ID NUMBER(6,0),
Classification CHAR(1),
Data_charged DATE,
Status CHAR(2),
Hearing_date DATE,
Appeal_cut_date DATE
);

CREATE TABLE Sentences(
Sentence_ID NUMBER(6),
Criminal_ID NUMBER(6),
Type CHAR(1),
Prob_ID NUMBER(5),
Start_date DATE,
End_date DATE,
Violations NUMBER(3)
);

CREATE TABLE Prob_officers(
Prob_ID NUMBER(5),
Last VARCHAR(15),
First VARCHAR(10),
Street VARCHAR(30),
City VARCHAR(20),
State CHAR(2),
Zip CHAR(5),
Phone CHAR(10),
Email VARCHAR(30),
Status CHAR(1)['A']
);

CREATE TABLE Crime_charges(
Charge_ID NUMBER(10,0),
Crime_ID NUMBER(9,0),
Crime_code NUMBER(3,0),
Charge_status CHAR(2),
Fine_amount NUMBER(7,2),
Court_fee NUMBER(7,2),
Amount_paid NUMBER(7,2),
Pay_due_date DATE
);

CREATE TABLE Crime_officers(
Crime_ID NUMBER(9,0),
Officer_ID NUMBER(8,0),
);

CREATE TABLE Officers (
Officer_ID NUMBER(8,0),
Last VARCHAR(15),
First VARCHAR(10),
Precinct CHAR(4),
Badge VARCHAR(14),
Phone CHAR(10),
Status CHAR(1)
);

CREATE TABLE Appeals(
Appeal_ID NUMBER(5),
Crime_ID NUMBER(9,0)
);

ALTER TABLE Crimes
ALTER Classification SET DEFAULT 'U';

ALTER TABLE Crimes 
ADD Date_Recorded DATE;

ALTER TABLE Crimes
ALTER Date_Recorded SET DEFAULT GETDATE();

ALTER TABLE Crimes
ADD Pager# NUMBER(13,0);

ALTER TABLE Aliases
MODIFY Alias VARCHAR(20);





