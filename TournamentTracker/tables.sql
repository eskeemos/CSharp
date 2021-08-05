CREATE TABLE Tournaments      (Id int IDENTITY(1,1) PRIMARY KEY, TournamentName varchar(50), EntryFee int, Active bit);
CREATE TABLE TournamentEntries(Id int IDENTITY(1,1) PRIMARY KEY, TournamentId int, TeamId int);
CREATE TABLE TournamentPrizes (Id int IDENTITY(1,1) PRIMARY KEY, TournamentId int, PrizeId int);
CREATE TABLE Prizes           (Id int IDENTITY(1,1) PRIMARY KEY, PlaceNumber int, PlaceName varchar(50), PrizeAmount int, PrizePercentage int);
CREATE TABLE Teams            (Id int IDENTITY(1,1)	PRIMARY KEY, TeamName varchar(50));
CREATE TABLE Matchups         (Id int IDENTITY(1,1)	PRIMARY KEY, TournamentId int, WinnerId int, MatchupRound int);
CREATE TABLE TeamMembers      (Id int IDENTITY(1,1)	PRIMARY KEY, TeamId int, PersonId int);
CREATE TABLE People           (Id int IDENTITY(1,1)	PRIMARY KEY, FirstName varchar(50), LastName varchar(50), EmailAddress varchar(50), PhoneNumber varchar(20));
CREATE TABLE MatchupEntries   (Id int IDENTITY(1,1)	PRIMARY KEY, MatchupId int, ParentMatchupId int, TeamCompetingId int, Score int);