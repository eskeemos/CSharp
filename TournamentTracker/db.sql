USE [master]
GO
/****** Object:  Database [TournamentTracker]    Script Date: 08.08.2021 18:28:52 ******/
CREATE DATABASE [TournamentTracker]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TournamentTracker', FILENAME = N'X:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TournamentTracker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TournamentTracker_log', FILENAME = N'X:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TournamentTracker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TournamentTracker] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TournamentTracker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TournamentTracker] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TournamentTracker] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TournamentTracker] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TournamentTracker] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TournamentTracker] SET ARITHABORT OFF 
GO
ALTER DATABASE [TournamentTracker] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TournamentTracker] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TournamentTracker] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TournamentTracker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TournamentTracker] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TournamentTracker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TournamentTracker] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TournamentTracker] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TournamentTracker] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TournamentTracker] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TournamentTracker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TournamentTracker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TournamentTracker] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TournamentTracker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TournamentTracker] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TournamentTracker] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TournamentTracker] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TournamentTracker] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TournamentTracker] SET  MULTI_USER 
GO
ALTER DATABASE [TournamentTracker] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TournamentTracker] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TournamentTracker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TournamentTracker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TournamentTracker] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TournamentTracker] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TournamentTracker] SET QUERY_STORE = OFF
GO
USE [TournamentTracker]
GO
/****** Object:  Table [dbo].[MatchupEntries]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchupEntries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MatchupId] [int] NULL,
	[ParentMatchupId] [int] NULL,
	[TeamCompetingId] [int] NULL,
	[Score] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matchups]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matchups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NULL,
	[WinnerId] [int] NULL,
	[MatchupRound] [int] NULL,
 CONSTRAINT [PK__Matchups__3214EC0739714595] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[EmailAddress] [varchar](50) NULL,
	[PhoneNumber] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prizes]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceNumber] [int] NULL,
	[PlaceName] [varchar](50) NULL,
	[PrizeAmount] [int] NULL,
	[PrizePercentage] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamMembers]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamMembers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NULL,
	[PersonId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentEntries]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentEntries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NULL,
	[TeamId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentPrizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NULL,
	[PrizeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tournaments]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tournaments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentName] [varchar](50) NULL,
	[EntryFee] [int] NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD  CONSTRAINT [FK__MatchupEn__Match__3C69FB99] FOREIGN KEY([MatchupId])
REFERENCES [dbo].[Matchups] ([Id])
GO
ALTER TABLE [dbo].[MatchupEntries] CHECK CONSTRAINT [FK__MatchupEn__Match__3C69FB99]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD  CONSTRAINT [FK__MatchupEn__Paren__3B75D760] FOREIGN KEY([ParentMatchupId])
REFERENCES [dbo].[Matchups] ([Id])
GO
ALTER TABLE [dbo].[MatchupEntries] CHECK CONSTRAINT [FK__MatchupEn__Paren__3B75D760]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD FOREIGN KEY([TeamCompetingId])
REFERENCES [dbo].[Teams] ([Id])
GO
ALTER TABLE [dbo].[Matchups]  WITH CHECK ADD FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournaments] ([Id])
GO
ALTER TABLE [dbo].[Matchups]  WITH CHECK ADD  CONSTRAINT [FK__Matchups__Winner__398D8EEE] FOREIGN KEY([WinnerId])
REFERENCES [dbo].[Teams] ([Id])
GO
ALTER TABLE [dbo].[Matchups] CHECK CONSTRAINT [FK__Matchups__Winner__398D8EEE]
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD FOREIGN KEY([PersonId])
REFERENCES [dbo].[People] ([Id])
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([Id])
GO
ALTER TABLE [dbo].[TournamentEntries]  WITH CHECK ADD FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([Id])
GO
ALTER TABLE [dbo].[TournamentEntries]  WITH CHECK ADD FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournaments] ([Id])
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD FOREIGN KEY([PrizeId])
REFERENCES [dbo].[Prizes] ([Id])
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournaments] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[MatchupEntries_getByTournament]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MatchupEntries_getByTournament]
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.MatchupEntries WHERE MatchupId = @MatchupId;

END
GO
/****** Object:  StoredProcedure [dbo].[MatchupEntries_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MatchupEntries_insert]
	@MatchupId int,
	@ParentMatchupId int,
	@TeamCompetingId int,
	@Id int = 0 out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.MatchupEntries(MatchupId, ParentMatchupId, TeamCompetingId, Score)
	VALUES (@MatchupId, @ParentMatchupId, @TeamCompetingId, 0)

	SELECT @Id = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[MatchupEntries_update]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MatchupEntries_update]
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
/****** Object:  StoredProcedure [dbo].[Matchups_getByTournament]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Matchups_getByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Matchups WHERE TournamentId = @TournamentId;

END
GO
/****** Object:  StoredProcedure [dbo].[Matchups_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Matchups_insert]
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
/****** Object:  StoredProcedure [dbo].[Matchups_update]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Matchups_update]
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
/****** Object:  StoredProcedure [dbo].[People_getAll]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[People_getAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.People;

END
GO
/****** Object:  StoredProcedure [dbo].[People_getByTeam]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[People_getByTeam]
	@EntryId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.TeamMembers tm
	INNER JOIN dbo.TournamentEntries te ON
	tm.TeamId = te.TeamId
	INNER JOIN dbo.People p ON
	p.Id = tm.PersonId
	WHERE te.Id = @EntryId;

END
GO
/****** Object:  StoredProcedure [dbo].[People_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[People_insert]
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
/****** Object:  StoredProcedure [dbo].[Prizes_getByTournament]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Prizes_getByTournament]
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
/****** Object:  StoredProcedure [dbo].[Prizes_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Prizes_insert]
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
/****** Object:  StoredProcedure [dbo].[TeamMembers_getByTeam]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TeamMembers_getByTeam]
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
/****** Object:  StoredProcedure [dbo].[TeamMembers_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TeamMembers_insert]
	@TeamId int,
	@PersonId int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TeamMembers (TeamId, PersonId)
	VALUES (@TeamId, @PersonId);

END
GO
/****** Object:  StoredProcedure [dbo].[Teams_getAll]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Teams_getAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Teams;

END
GO
/****** Object:  StoredProcedure [dbo].[Teams_getByTournament]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Teams_getByTournament]
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
/****** Object:  StoredProcedure [dbo].[Teams_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Teams_insert]
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
/****** Object:  StoredProcedure [dbo].[TournamentEntries_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TournamentEntries_insert]
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
/****** Object:  StoredProcedure [dbo].[TournamentPrizes_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TournamentPrizes_insert]
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
/****** Object:  StoredProcedure [dbo].[Tournaments_complete]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Tournaments_complete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Tournaments
	SET Active = 0
	WHERE Id = @Id;

END
GO
/****** Object:  StoredProcedure [dbo].[Tournaments_getAll]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Tournaments_getAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Tournaments WHERE Active = 1;

END
GO
/****** Object:  StoredProcedure [dbo].[Tournaments_insert]    Script Date: 08.08.2021 18:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Tournaments_insert]
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
GO
USE [master]
GO
ALTER DATABASE [TournamentTracker] SET  READ_WRITE 
GO
