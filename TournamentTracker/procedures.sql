CREATE PROCEDURE dbo.People_insert
	@FirstName text,
	@LastName text,
	@EmailAddress text,
	@PhoneNumber text,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.People (FirstName, LastName, EmailAddress, PhoneNumber)
	VALUES (@FirstName, @LastName, @EmailAddress, @PhoneNumber);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
CREATE PROCEDURE dbo.Prizes_insert
	@PlaceNumber int,
	@PlaceName text,
	@PrizeAmount int,
	@PrizePercentage float,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
CREATE PROCEDURE dbo.Teams_insert
	@TeamName text,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Teams (TeamName)
	VALUES (@TeamName);

	SELECT @Id = SCOPE_IDENTITY();

END
GO
CREATE PROCEDURE dbo.TeamMembers_insert
	@TeamId int,
	@PersonId int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TeamMembers (TeamId, PersonId)
	VALUES (@TeamId, @PersonId);

END
GO
CREATE PROCEDURE dbo.Matchups_update
	@Id int,
	@WinnerId int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Matchups
	SET WinnerId = @WinnerId 
	WHERE Id = @Id;

END
GO
CREATE PROCEDURE dbo.MatchupEntries_update
	@Id int,
	@TeamCompetingId int,
	@Score int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.MatchupEntries
	SET TeamCompetingId = @TeamCompetingId, Score = @Score
	WHERE Id = @Id;

END
GO
CREATE PROCEDURE dbo.Tournaments_complete
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Tournaments
	SET Active = 0
	WHERE Id = @Id;

END
GO
CREATE PROCEDURE dbo.People_getAll
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.People;

END
GO
CREATE PROCEDURE dbo.Teams_getAll
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Teams;

END
GO
CREATE PROCEDURE dbo.TeamMembers_getByTeam
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.People
	INNER JOIN TeamMembers ON
	dbo.People.Id = TeamMembers.PersonId
	WHERE TeamId = @TeamId;

END
GO
CREATE PROCEDURE dbo.Tournaments_getAll
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Tournaments;

END
GO
CREATE PROCEDURE dbo.Prizes_getByTournament
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Prizes 
	INNER JOIN dbo.TournamentPrizes ON
	dbo.Prizes.Id = dbo.TournamentPrizes.PrizeId
	WHERE TournamentId = @TournamentId;

END
GO
CREATE PROCEDURE dbo.Teams_getByTournament
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Teams 
	INNER JOIN dbo.TournamentEntries ON
	dbo.Teams.Id = dbo.TournamentEntries.TeamId
	WHERE TournamentId = @TournamentId;

END
GO
CREATE PROCEDURE dbo.People_getByTeam
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.People 
	INNER JOIN dbo.TeamMembers ON
	dbo.People.ID = dbo.TeamMembers.PersonID
	WHERE TeamID = @TeamId;

END
GO
CREATE PROCEDURE dbo.Matchups_getByTournament
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Matchups WHERE ID = @MatchupId;

END
GO
CREATE PROCEDURE dbo.MatchupEntries_getByTournament
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.MatchupEntries WHERE ID = @MatchupId;

END
GO
CREATE PROCEDURE dbo.Matchups_insert
	@TournamentId int,
	@MatchupRound int,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Matchups (TournamentId,MatchupRound)
	VALUES (@TournamentId, @MatchupRound)

	SELECT @Id = SCOPE_IDENTITY();

END
GO
CREATE PROCEDURE dbo.MatchupEntries_insert
	@MatchupId int,
	@ParentMatchupId int,
	@TeamCompetingId int,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.MatchupEntries(MatchupId, ParentMatchupId, TeamCompetingId)
	VALUES (@MatchupId, @ParentMatchupId, @TeamCompetingId)

	SELECT @Id = SCOPE_IDENTITY();

END
GO
CREATE PROCEDURE dbo.Tournaments_insert
	@TournamentName text,
	@EntryFee int,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Tournaments (TournamentName, EntryFee, Active)
	VALUES (@TournamentName, @EntryFee, 1)

	SELECT @Id = SCOPE_IDENTITY();

END
CREATE PROCEDURE dbo.TournamentPrizes_insert
	@TournamentId int,
	@PrizeId int,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TournamentPrizes (TournamentId, PrizeId)
	VALUES (@TournamentId, @PrizeId)

	SELECT @Id = SCOPE_IDENTITY();

END
GO
CREATE PROCEDURE dbo.TournamentEntries_insert
	@TournamentId int,
	@TeamId int,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TournamentEntries (TournamentId, TeamId)
	VALUES (@TournamentId, @TeamId)

	SELECT @Id = SCOPE_IDENTITY();

END
GO