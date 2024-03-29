USE [DafAirplanes]
GO
/****** Object:  Table [dbo].[Flights]    Script Date: 24-2-2024 14:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flights](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Airport] [nvarchar](255) NOT NULL,
	[City] [nvarchar](255) NOT NULL,
	[Flightnumber] [nvarchar](255) NOT NULL,
	[Arrival] [datetime] NOT NULL,
	[Departure] [datetime] NOT NULL
) ON [PRIMARY]
GO
