
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)


CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
	[Complementary] [varchar](25) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)

ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Client_Address] 
FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])

GO

CREATE TABLE [dbo].[Document](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[DocumentNumber] [varchar](50) NOT NULL,
	[Type] [int] NOT NULL,
	[DateIssue] [datetime] NOT NULL,
	
	
 CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)

ALTER TABLE [dbo].[Document]  WITH CHECK ADD  CONSTRAINT [FK_Client_Document] 
FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])

