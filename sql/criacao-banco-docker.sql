USE [master]
GO

CREATE DATABASE [AecDataBase]
GO

USE [AecDataBase]
GO

/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29/10/2023 19:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogErro]    Script Date: 29/10/2023 19:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogErro](
	[Id] [uniqueidentifier] NOT NULL,
	[TipoException] [varchar](100) NOT NULL,
	[StackTrace] [varchar](1000) NOT NULL,
	[MensagemErro] [varchar](250) NOT NULL,
	[Endpoint] [varchar](100) NOT NULL,
	[DataErro] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LogErro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrevisaoTempoAeroporto]    Script Date: 29/10/2023 19:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrevisaoTempoAeroporto](
	[Id] [uniqueidentifier] NOT NULL,
	[CodigoIcao] [varchar](10) NOT NULL,
	[AtualizadoEm] [varchar](100) NOT NULL,
	[PressaoAtmosferica] [int] NOT NULL,
	[Visibilidade] [varchar](100) NOT NULL,
	[Vento] [int] NOT NULL,
	[DirecaoVento] [int] NOT NULL,
	[Umidade] [int] NOT NULL,
	[Condicao] [varchar](20) NOT NULL,
	[CondicaoDescricao] [varchar](100) NOT NULL,
	[Temperatura] [real] NOT NULL,
	[Data] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PrevisaoTempoAeroporto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrevisaoTempoCidade]    Script Date: 29/10/2023 19:54:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrevisaoTempoCidade](
	[Id] [uniqueidentifier] NOT NULL,
	[IdCidade] [int] NOT NULL,
	[NomeCidade] [varchar](200) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[DataPrevisao] [datetime2](7) NOT NULL,
	[Condicao] [varchar](50) NOT NULL,
	[TemperaturaMinima] [int] NOT NULL,
	[TemperaturaMaxima] [int] NOT NULL,
	[IndiceUV] [int] NOT NULL,
	[DescricaoCondicao] [varchar](100) NOT NULL,
	[Data] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PrevisaoTempoCidade] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
