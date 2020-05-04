USE [FuntodoDB]
GO

/****** Object: Table [dbo].[UserMaster] Script Date: 4/30/2020 10:23:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
BEGIN TRAN T1;  

CREATE TABLE [UserMaster] (
	id integer	Identity(100,1),
	username varchar(255) NOT NULL unique,
	created_at datetime,
	password varchar(255) NOT NULL,
	type integer NOT NULL DEFAULT '1',
  CONSTRAINT [PK_USERMASTER] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [dbo].[UserType] (
    [id]   INT           NOT NULL IDENTITY,
    [type] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_USERTYPE] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO
CREATE TABLE [TodoList] (
	id int  NOT NULL IDENTITY,
	username varchar(255),
	created_at datetime NOT NULL,
	last_modified datetime NOT NULL,
	list_data xml,
  CONSTRAINT [PK_TODOLIST] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [UserDetails] (
	id integer NOT NULL identity(1,1),
	username varchar(255) NOT NULL UNIQUE,
	address varchar(500),
	first_name varchar(255),
	last_name varchar(255),
	phone_no varchar(255),
  CONSTRAINT [PK_USERDETAILS] PRIMARY KEY CLUSTERED
  (
  [username] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [UserMaster] WITH CHECK ADD CONSTRAINT [UserMaster_fk0] FOREIGN KEY ([type]) REFERENCES [UserType]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [UserMaster] CHECK CONSTRAINT [UserMaster_fk0]
GO


ALTER TABLE [TodoList] WITH CHECK ADD CONSTRAINT [TodoList_fk0] FOREIGN KEY ([username]) REFERENCES [UserMaster]([username])
ON UPDATE CASCADE
GO
ALTER TABLE [TodoList] CHECK CONSTRAINT [TodoList_fk0]
GO

ALTER TABLE [UserDetails] WITH CHECK ADD CONSTRAINT [UserDetails_fk0] FOREIGN KEY ([username]) REFERENCES [UserMaster]([username])
ON UPDATE CASCADE
GO
ALTER TABLE [UserDetails] CHECK CONSTRAINT [UserDetails_fk0]
GO
COMMIT TRAN T1;  
