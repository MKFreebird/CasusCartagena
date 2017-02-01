
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/01/2017 09:26:05
-- Generated from EDMX file: C:\Users\admin\Desktop\CasusCartagena\Chat\ChatModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CartagenaDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MessageChat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MessageSet] DROP CONSTRAINT [FK_MessageChat];
GO
IF OBJECT_ID(N'[dbo].[FK_ChatUser_Chat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChatUser] DROP CONSTRAINT [FK_ChatUser_Chat];
GO
IF OBJECT_ID(N'[dbo].[FK_ChatUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChatUser] DROP CONSTRAINT [FK_ChatUser_User];
GO
IF OBJECT_ID(N'[dbo].[FK_MessageUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MessageSet] DROP CONSTRAINT [FK_MessageUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MessageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MessageSet];
GO
IF OBJECT_ID(N'[dbo].[ChatSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChatSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[FriendListSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FriendListSet];
GO
IF OBJECT_ID(N'[dbo].[ChatUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChatUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MessageSet'
CREATE TABLE [dbo].[MessageSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [TimeStamp] datetime  NOT NULL,
    [IsReceived] bit  NOT NULL,
    [Chat_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'ChatSet'
CREATE TABLE [dbo].[ChatSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ChatRoomName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FriendListSet'
CREATE TABLE [dbo].[FriendListSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountidOne] nvarchar(max)  NOT NULL,
    [AccountidTwo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ChatUser'
CREATE TABLE [dbo].[ChatUser] (
    [Chat_Id] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MessageSet'
ALTER TABLE [dbo].[MessageSet]
ADD CONSTRAINT [PK_MessageSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ChatSet'
ALTER TABLE [dbo].[ChatSet]
ADD CONSTRAINT [PK_ChatSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FriendListSet'
ALTER TABLE [dbo].[FriendListSet]
ADD CONSTRAINT [PK_FriendListSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Chat_Id], [User_Id] in table 'ChatUser'
ALTER TABLE [dbo].[ChatUser]
ADD CONSTRAINT [PK_ChatUser]
    PRIMARY KEY CLUSTERED ([Chat_Id], [User_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Chat_Id] in table 'MessageSet'
ALTER TABLE [dbo].[MessageSet]
ADD CONSTRAINT [FK_MessageChat]
    FOREIGN KEY ([Chat_Id])
    REFERENCES [dbo].[ChatSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageChat'
CREATE INDEX [IX_FK_MessageChat]
ON [dbo].[MessageSet]
    ([Chat_Id]);
GO

-- Creating foreign key on [Chat_Id] in table 'ChatUser'
ALTER TABLE [dbo].[ChatUser]
ADD CONSTRAINT [FK_ChatUser_Chat]
    FOREIGN KEY ([Chat_Id])
    REFERENCES [dbo].[ChatSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [User_Id] in table 'ChatUser'
ALTER TABLE [dbo].[ChatUser]
ADD CONSTRAINT [FK_ChatUser_User]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChatUser_User'
CREATE INDEX [IX_FK_ChatUser_User]
ON [dbo].[ChatUser]
    ([User_Id]);
GO

-- Creating foreign key on [User_Id] in table 'MessageSet'
ALTER TABLE [dbo].[MessageSet]
ADD CONSTRAINT [FK_MessageUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageUser'
CREATE INDEX [IX_FK_MessageUser]
ON [dbo].[MessageSet]
    ([User_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------