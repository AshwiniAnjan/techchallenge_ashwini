USE [Crownbet]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 08/05/2018 02:35:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomer_Bet]    Script Date: 08/05/2018 02:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer_Bet](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RaceId] [bigint] NOT NULL,
	[HorseId] [bigint] NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tblCustomer_Bet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHorse]    Script Date: 08/05/2018 02:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHorse](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tblHorse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRace]    Script Date: 08/05/2018 02:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRace](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[StatusId] [bigint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tblRace] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRace_Horse]    Script Date: 08/05/2018 02:35:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRace_Horse](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RaceId] [bigint] NOT NULL,
	[HorseId] [bigint] NOT NULL,
	[Odds] [decimal](7, 2) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tblRace_Horse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRaceStatus]    Script Date: 08/05/2018 02:35:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRaceStatus](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tblRaceStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCustomer] ON 
GO
INSERT [dbo].[tblCustomer] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (1, N'Ashwini', CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblCustomer] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (2, N'Anjan', CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblCustomer] OFF
GO
SET IDENTITY_INSERT [dbo].[tblCustomer_Bet] ON 
GO
INSERT [dbo].[tblCustomer_Bet] ([Id], [RaceId], [HorseId], [CustomerId], [Amount], [CreatedDate], [ModifiedDate]) VALUES (1, 1, 1, 1, CAST(200.00 AS Decimal(18, 2)), CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblCustomer_Bet] ([Id], [RaceId], [HorseId], [CustomerId], [Amount], [CreatedDate], [ModifiedDate]) VALUES (2, 1, 4, 1, CAST(100.00 AS Decimal(18, 2)), CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblCustomer_Bet] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHorse] ON 
GO
INSERT [dbo].[tblHorse] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (1, N'Winx', CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblHorse] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (2, N'Big Brown', CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblHorse] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (3, N'Trigger', CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblHorse] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (4, N'Omaha', CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblHorse] OFF
GO
SET IDENTITY_INSERT [dbo].[tblRace] ON 
GO
INSERT [dbo].[tblRace] ([Id], [Name], [StatusId], [CreatedDate], [ModifiedDate]) VALUES (1, N'Flemington', 1, CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblRace] ([Id], [Name], [StatusId], [CreatedDate], [ModifiedDate]) VALUES (3, N'Melbourne Cup', 1, CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblRace] OFF
GO
SET IDENTITY_INSERT [dbo].[tblRace_Horse] ON 
GO
INSERT [dbo].[tblRace_Horse] ([Id], [RaceId], [HorseId], [Odds], [CreatedDate], [ModifiedDate]) VALUES (1, 1, 1, CAST(2.00 AS Decimal(7, 2)), CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblRace_Horse] ([Id], [RaceId], [HorseId], [Odds], [CreatedDate], [ModifiedDate]) VALUES (2, 1, 2, CAST(3.00 AS Decimal(7, 2)), CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblRace_Horse] ([Id], [RaceId], [HorseId], [Odds], [CreatedDate], [ModifiedDate]) VALUES (5, 1, 4, CAST(18.00 AS Decimal(7, 2)), CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblRace_Horse] ([Id], [RaceId], [HorseId], [Odds], [CreatedDate], [ModifiedDate]) VALUES (7, 3, 3, CAST(5.00 AS Decimal(7, 2)), CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblRace_Horse] ([Id], [RaceId], [HorseId], [Odds], [CreatedDate], [ModifiedDate]) VALUES (8, 3, 2, CAST(2.00 AS Decimal(7, 2)), CAST(N'2018-08-04T00:00:00.000' AS DateTime), CAST(N'2018-08-04T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblRace_Horse] OFF
GO
SET IDENTITY_INSERT [dbo].[tblRaceStatus] ON 
GO
INSERT [dbo].[tblRaceStatus] ([Id], [Status]) VALUES (1, N'Pending')
GO
INSERT [dbo].[tblRaceStatus] ([Id], [Status]) VALUES (2, N'In-Progress')
GO
INSERT [dbo].[tblRaceStatus] ([Id], [Status]) VALUES (3, N'Completed')
GO
SET IDENTITY_INSERT [dbo].[tblRaceStatus] OFF
GO
ALTER TABLE [dbo].[tblCustomer_Bet]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomer_Bet_tblCustomer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[tblCustomer] ([Id])
GO
ALTER TABLE [dbo].[tblCustomer_Bet] CHECK CONSTRAINT [FK_tblCustomer_Bet_tblCustomer]
GO
ALTER TABLE [dbo].[tblCustomer_Bet]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomer_Bet_tblHorse] FOREIGN KEY([HorseId])
REFERENCES [dbo].[tblHorse] ([Id])
GO
ALTER TABLE [dbo].[tblCustomer_Bet] CHECK CONSTRAINT [FK_tblCustomer_Bet_tblHorse]
GO
ALTER TABLE [dbo].[tblCustomer_Bet]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomer_Bet_tblRace] FOREIGN KEY([RaceId])
REFERENCES [dbo].[tblRace] ([Id])
GO
ALTER TABLE [dbo].[tblCustomer_Bet] CHECK CONSTRAINT [FK_tblCustomer_Bet_tblRace]
GO
ALTER TABLE [dbo].[tblRace]  WITH CHECK ADD  CONSTRAINT [FK_tblRace_tblRaceStatus] FOREIGN KEY([StatusId])
REFERENCES [dbo].[tblRaceStatus] ([Id])
GO
ALTER TABLE [dbo].[tblRace] CHECK CONSTRAINT [FK_tblRace_tblRaceStatus]
GO
ALTER TABLE [dbo].[tblRace_Horse]  WITH CHECK ADD  CONSTRAINT [FK_tblRace_Horse_tblHorse] FOREIGN KEY([HorseId])
REFERENCES [dbo].[tblHorse] ([Id])
GO
ALTER TABLE [dbo].[tblRace_Horse] CHECK CONSTRAINT [FK_tblRace_Horse_tblHorse]
GO
ALTER TABLE [dbo].[tblRace_Horse]  WITH CHECK ADD  CONSTRAINT [FK_tblRace_Horse_tblRace] FOREIGN KEY([RaceId])
REFERENCES [dbo].[tblRace] ([Id])
GO
ALTER TABLE [dbo].[tblRace_Horse] CHECK CONSTRAINT [FK_tblRace_Horse_tblRace]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCustomerDetails]    Script Date: 08/05/2018 02:35:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetCustomerDetails]
AS
BEGIN

	
DECLARE @Temp TABLE
(
	CustomerId BIGINT
	,BetCount BIGINT
	,BetAmount DECIMAL(18,2)
)

INSERT INTO @Temp	
	SELECT CB.CustomerId,
		   COUNT(CB.CustomerId) AS BetCount,
		   SUM(CB.Amount) AS BetAmount
	FROM  tblCustomer_Bet CB with (nolock)
	GROUP BY CB.CustomerId

SELECT  C.Id,
		C.Name,
		T.BetCount,
		T.BetAmount,
		CASE 
		WHEN T.BetAmount >= 200
		THEN 1
		ELSE 0
		END AS RiskIndicator
FROM tblCustomer C with (nolock) LEFT OUTER JOIN @Temp T
ON C.Id = T.CustomerId
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetHorseDetails]    Script Date: 08/05/2018 02:35:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetHorseDetails]
(
	@RaceID BIGINT
)
AS
BEGIN
	
		DECLARE @Temp TABLE
		(
			HorseID BIGINT
			,NumberOfBets BIGINT
			,Amount DECIMAL(18,2)
		)

		INSERT INTO @Temp
		SELECT		 CB.HorseId
					,COUNT(CB.HorseId) 
					,SUM(CB.Amount)
		FROM		tblCustomer_Bet CB
		WHERE		CB.RaceId = @RaceId
		GROUP BY CB.HorseId

		SELECT  H.Id,
				H.Name,
				ISNULL(T.NumberOfBets, 0) AS NumberOfBets,
				ISNULL(RH.Odds * T.Amount,0) AS Column1
		FROM tblRace_Horse RH  with (nolock) INNER JOIN tblHorse H
		ON RH.HorseId = H.Id
		LEFT OUTER JOIN @Temp T ON RH.HorseId = T.HorseID
		WHERE RH.RaceId = @RaceId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRaceDetails]    Script Date: 08/05/2018 02:35:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetRaceDetails]  
AS  
BEGIN  
  DECLARE @Temp TABLE  
  (  
   RaceID Bigint,  
   TotalAmount DECIMAL(18,2)  
  )  
  
  INSERT INTO @Temp  
  SELECT CB.RaceId,  
      SUM(CB.Amount)   
  FROM tblCustomer_Bet CB  
  GROUP BY CB.RaceId  
  
  SELECT  R.Id,  
    R.Name,  
    RS.Status,  
    ISNULL(T.TotalAmount ,0) AS TotalAmount 
  FROM tblRace R with (nolock) INNER JOIN tblRaceStatus RS  
  ON r.StatusId = RS.Id LEFT OUTER  JOIN @Temp T  
  ON T.RaceID = R.Id  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetTotalBets]    Script Date: 08/05/2018 02:35:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetTotalBets]
AS
BEGIN
	SELECT SUM(CB.Amount) AS TotalBets
	FROM tblCustomer_Bet CB
END
GO
