--CREATE PROCEDURE proPeople_ins
--	@FirstName text,
--	@LastName text,
--	@EmailAddress text,
--	@PhoneNumber text,
--	@Id int = 0 out
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO dbo.People (FirstName, LastName, EmailAddress, PhoneNumber)
--	VALUES (@FirstName, @LastName, @EmailAddress, @PhoneNumber);

--	SELECT @Id = SCOPE_IDENTITY();

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proPrizes_ins
--	@PlaceNumber int,
--	@PlaceName text,
--	@PrizeAmount int,
--	@PrizePercentage float,
--	@Id int = 0 out
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
--	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

--	SELECT @Id = SCOPE_IDENTITY();

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proTeams_ins
--	@TeamName text,
--	@Id int = 0 out
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO dbo.Teams (TeamName)
--	VALUES (@TeamName);

--	SELECT @Id = SCOPE_IDENTITY();

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proMatchups_upd
--	@Id int,
--	@WinnerId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	UPDATE dbo.Matchups
--	SET WinnerId = @WinnerId 
--	WHERE ID = @Id;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proMatchupEntries_upd
--	@Id int,
--	@TeamCompetingId int,
--	@Score int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	UPDATE dbo.MatchupEntries
--	SET TeamCompetingId = @TeamCompetingId, Score = @Score
--	WHERE ID = @Id;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proTournaments_com
--	@Id int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	UPDATE dbo.Tournaments
--	SET Active = 0
--	WHERE ID = @Id;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proPeople_getAll
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.People;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proTeams_getAll
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.Teams;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proTournaments_getAll
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.Tournaments;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proPrizes_getByTournament
--	@TournamentId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.Prizes 
--	INNER JOIN dbo.TournamentPrizes ON
--	dbo.Prizes.ID = dbo.TournamentPrizes.PrizeID
--	WHERE TournamentID = @TournamentId;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proTeams_getByTournament
--	@TournamentId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.Teams 
--	INNER JOIN dbo.TournamentEntries ON
--	dbo.Teams.ID = dbo.TournamentEntries.TeamID
--	WHERE TournamentID = @TournamentId;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proPeople_getByTeam
--	@TeamId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.People 
--	INNER JOIN dbo.TeamMembers ON
--	dbo.People.ID = dbo.TeamMembers.PersonID
--	WHERE TeamID = @TeamId;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proMatchups_getByTournament
--	@MatchupId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.Matchups WHERE ID = @MatchupId;

--END
--GO
--------------------------------------------------------
--CREATE PROCEDURE proMatchupEntries_getByTournament
--	@MatchupId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT * FROM dbo.MatchupEntries WHERE ID = @MatchupId;

--END
--GO





























