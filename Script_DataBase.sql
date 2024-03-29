USE [master]
GO

/****** Object:  Database [BancoEmpresa]    Script Date: 23/11/2015 15:58:47 ******/
CREATE DATABASE [BancoEmpresa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BancoEmpresa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BancoEmpresa.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BancoEmpresa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BancoEmpresa_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [BancoEmpresa] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BancoEmpresa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BancoEmpresa] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BancoEmpresa] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BancoEmpresa] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BancoEmpresa] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BancoEmpresa] SET ARITHABORT OFF 
GO

ALTER DATABASE [BancoEmpresa] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BancoEmpresa] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [BancoEmpresa] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BancoEmpresa] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BancoEmpresa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BancoEmpresa] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BancoEmpresa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BancoEmpresa] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BancoEmpresa] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BancoEmpresa] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BancoEmpresa] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BancoEmpresa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BancoEmpresa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BancoEmpresa] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BancoEmpresa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BancoEmpresa] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BancoEmpresa] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BancoEmpresa] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BancoEmpresa] SET RECOVERY FULL 
GO

ALTER DATABASE [BancoEmpresa] SET  MULTI_USER 
GO

ALTER DATABASE [BancoEmpresa] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BancoEmpresa] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BancoEmpresa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BancoEmpresa] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [BancoEmpresa] SET  READ_WRITE 
GO

