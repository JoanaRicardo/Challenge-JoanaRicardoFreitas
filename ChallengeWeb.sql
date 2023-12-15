create table Teams(
  TeamId INT NOT NULL AUTO_INCREMENT,
  Name VARCHAR(255),
  PRIMARY KEY(TeamId)
);

create table Users(
  UserId INT NOT NULL AUTO_INCREMENT,
  TeamId INT,
  LastName VARCHAR(255),
  FirstName VARCHAR(255),
  Address VARCHAR(255),
  City VARCHAR(255),
  PRIMARY KEY(UserId),
  FOREIGN KEY (TeamId) REFERENCES Teams(TeamId)
);