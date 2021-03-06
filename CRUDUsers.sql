USE [master]
GO
/****** Object:  Database [CRUDUsers]    Script Date: 6/6/2021 2:39:04 PM ******/
CREATE DATABASE [CRUDUsers]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CRUDUsers', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CRUDUsers.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CRUDUsers_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CRUDUsers_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CRUDUsers] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CRUDUsers].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CRUDUsers] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CRUDUsers] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CRUDUsers] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CRUDUsers] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CRUDUsers] SET ARITHABORT OFF 
GO
ALTER DATABASE [CRUDUsers] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CRUDUsers] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CRUDUsers] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CRUDUsers] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CRUDUsers] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CRUDUsers] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CRUDUsers] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CRUDUsers] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CRUDUsers] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CRUDUsers] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CRUDUsers] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CRUDUsers] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CRUDUsers] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CRUDUsers] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CRUDUsers] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CRUDUsers] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CRUDUsers] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CRUDUsers] SET RECOVERY FULL 
GO
ALTER DATABASE [CRUDUsers] SET  MULTI_USER 
GO
ALTER DATABASE [CRUDUsers] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CRUDUsers] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CRUDUsers] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CRUDUsers] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CRUDUsers] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CRUDUsers] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CRUDUsers', N'ON'
GO
ALTER DATABASE [CRUDUsers] SET QUERY_STORE = OFF
GO
USE [CRUDUsers]
GO
/****** Object:  Table [dbo].[CRUDUsers_tbl]    Script Date: 6/6/2021 2:39:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CRUDUsers_tbl](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneNumber] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CRUDUsers_tbl]  WITH CHECK ADD  CONSTRAINT [CHK_ValidEmail] CHECK  (([Email] like '%@%.%'))
GO
ALTER TABLE [dbo].[CRUDUsers_tbl] CHECK CONSTRAINT [CHK_ValidEmail]
GO
ALTER TABLE [dbo].[CRUDUsers_tbl]  WITH CHECK ADD  CONSTRAINT [CHK_ValidFirstName] CHECK  ((len([FirstName])>=(1)))
GO
ALTER TABLE [dbo].[CRUDUsers_tbl] CHECK CONSTRAINT [CHK_ValidFirstName]
GO
ALTER TABLE [dbo].[CRUDUsers_tbl]  WITH CHECK ADD  CONSTRAINT [CHK_ValidLastName] CHECK  ((len([LastName])>=(1)))
GO
ALTER TABLE [dbo].[CRUDUsers_tbl] CHECK CONSTRAINT [CHK_ValidLastName]
GO
ALTER TABLE [dbo].[CRUDUsers_tbl]  WITH CHECK ADD  CONSTRAINT [CHK_ValidPassword] CHECK  ((len([Password])>=(5)))
GO
ALTER TABLE [dbo].[CRUDUsers_tbl] CHECK CONSTRAINT [CHK_ValidPassword]
GO
ALTER TABLE [dbo].[CRUDUsers_tbl]  WITH CHECK ADD  CONSTRAINT [CHK_ValidPhone] CHECK  ((NOT [PhoneNumber] like '%[^0-9]%'))
GO
ALTER TABLE [dbo].[CRUDUsers_tbl] CHECK CONSTRAINT [CHK_ValidPhone]
GO
ALTER TABLE [dbo].[CRUDUsers_tbl]  WITH CHECK ADD  CONSTRAINT [CHK_ValidUsername] CHECK  ((len([Username])>=(5)))
GO
ALTER TABLE [dbo].[CRUDUsers_tbl] CHECK CONSTRAINT [CHK_ValidUsername]
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 6/6/2021 2:39:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AddUser]
(@Username varchar(50),
@Password varchar(50),
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@PhoneNumber varchar(50))
AS
BEGIN
	INSERT INTO CRUDUsers_tbl (Username, Password, FirstName, LastName, Email, PhoneNumber)
	VALUES(@Username, @Password, @FirstName, @LastName, @Email, @PhoneNumber)
END 
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 6/6/2021 2:39:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[DeleteUser]
(@Username varchar(50))
AS
BEGIN
DELETE FROM CRUDUsers_tbl WHERE Username = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 6/6/2021 2:39:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetAllUsers]
AS
SELECT * FROM CRUDUsers_tbl
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 6/6/2021 2:39:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateUser]
(@Username varchar(50),
@Password varchar(50),
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@PhoneNumber varchar(50),
@EditUsername varchar(50))
AS
BEGIN
	UPDATE CRUDUsers_tbl
	SET Username = @Username, Password = @Password ,  FirstName = @FirstName , LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber 
	WHERE Username = @EditUsername
END
GO
/****** Object:  StoredProcedure [dbo].[ValidateUserCredentials]    Script Date: 6/6/2021 2:39:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[ValidateUserCredentials]
@Username varchar(50),
@Password varchar(50)
AS
BEGIN

SELECT * FROM CRUDUsers_tbl WHERE username = @Username COLLATE SQL_Latin1_General_CP1_CS_AS AND password = @Password COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO
USE [master]
GO
ALTER DATABASE [CRUDUsers] SET  READ_WRITE 
GO
