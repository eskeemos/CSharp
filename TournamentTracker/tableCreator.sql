CREATE TABLE Tournaments(ID int IDENTITY(1,1)		PRIMARY KEY,TournamentName varchar(50), EntryFee int);
CREATE TABLE TournamentEntries(ID int IDENTITY(1,1) PRIMARY KEY,TournamentID int, TeamID int);
CREATE TABLE TournamentPrizes(ID int IDENTITY(1,1)  PRIMARY KEY,TournamentID int, PrizeID int);
CREATE TABLE Prizes(ID int IDENTITY(1,1)		    PRIMARY KEY,PlaceNumber int,PlaceName varchar(50),PrizeAmount int,PrizePercentage float);
CREATE TABLE Teams(ID int IDENTITY(1,1)				PRIMARY KEY,TeamName varchar(50));
CREATE TABLE Matchups(ID int IDENTITY(1,1)			PRIMARY KEY,WinnerID int, MatchupRound int);
CREATE TABLE TeamMembers(ID int IDENTITY(1,1)		PRIMARY KEY,TeamID int, PersonID int);
CREATE TABLE People(ID int IDENTITY(1,1)			PRIMARY KEY,FirstName varchar(50), LastName varchar(50),EmailAddress varchar(50),PhoneNumber varchar(20));
CREATE TABLE MatchupEntries(ID int IDENTITY(1,1)	PRIMARY KEY,MatchupID int, ParentMatchupID int,TeamCompetingID int,Score int);
