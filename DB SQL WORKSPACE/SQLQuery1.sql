CREATE TABLE  USR_MAIN(
   USR_login_Id varchar(20) NOT NULL,
   USR_PassWord varchar(20) NOT NULL,
   USR_Access_Lvl int NOT NULL,
  PRIMARY KEY (USR_login_Id)
)

SELECT * FROM USR_MAIN;

INSERT INTO USR_MAIN(USR_login_Id,USR_PassWord,USR_Access_Lvl) VALUES
('Vishwa','7777',0);