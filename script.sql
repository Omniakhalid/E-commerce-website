USE [master]
GO
/****** Object:  Database [OnlineShopping]    Script Date: 3/19/2022 12:51:01 PM ******/
CREATE DATABASE [OnlineShopping]
GO
ALTER DATABASE [OnlineShopping] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineShopping].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineShopping] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineShopping] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineShopping] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineShopping] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineShopping] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineShopping] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineShopping] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineShopping] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineShopping] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineShopping] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineShopping] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineShopping] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineShopping] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineShopping] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlineShopping] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineShopping] SET RECOVERY FULL 
GO
ALTER DATABASE [OnlineShopping] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineShopping] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineShopping] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineShopping] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineShopping] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlineShopping] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OnlineShopping', N'ON'
GO
ALTER DATABASE [OnlineShopping] SET QUERY_STORE = OFF
GO
USE [OnlineShopping]
GO
/****** Object:  Table [dbo].[OptionGroups]    Script Date: 3/19/2022 12:51:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OptionGroups](
	[OptionGroupID] [int] NOT NULL,
	[OptionGroupName] [varchar](50) NULL,
 CONSTRAINT [PK_OptionGroups] PRIMARY KEY CLUSTERED 
(
	[OptionGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Options]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Options](
	[OptionID] [int] NOT NULL,
	[OptionName] [varchar](50) NOT NULL,
	[OptionGroupID] [int] NOT NULL,
 CONSTRAINT [PK_Options] PRIMARY KEY CLUSTERED 
(
	[OptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[DetailID] [int] NOT NULL,
	[DetailOrderID] [int] NOT NULL,
	[DetailProductID] [int] NOT NULL,
	[DetailName] [varchar](50) NOT NULL,
	[Quanity] [int] NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetails_1] PRIMARY KEY CLUSTERED 
(
	[DetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[OrderAmount] [int] NOT NULL,
	[ShippingAddress] [nchar](10) NOT NULL,
	[OrderAddress] [nchar](10) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[OrderStatus] [bit] NULL,
	[orderTrakingNumber] [int] NULL,
	[OrderShiped] [tinyint] NOT NULL,
	[OrderCountry] [nchar](10) NOT NULL,
	[OrderCity] [nchar](10) NOT NULL,
	[CustomerPhone] [varchar](50) NOT NULL,
	[OrderPhone] [varchar](50) NULL,
	[OrderEmail] [varchar](50) NULL,
 CONSTRAINT [PK_Orders_1] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductOptions]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductOptions](
	[ProductOptionID] [int] NOT NULL,
	[OptionID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
 CONSTRAINT [PK_ProductOptions] PRIMARY KEY CLUSTERED 
(
	[ProductOptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[ProductWeight] [float] NULL,
	[ProductShortDes] [varchar](250) NOT NULL,
	[ProductLongDes] [varchar](3000) NULL,
	[ProductImage] [varchar](200) NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
	[ProductUpdateDate] [timestamp] NULL,
	[ProductStock] [int] NOT NULL,
	[VendorID] [int] NULL,
 CONSTRAINT [PK_Products_1] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[UserEmail] [nchar](10) NOT NULL,
	[UserPassword] [varchar](50) NOT NULL,
	[UserFirstName] [varchar](50) NOT NULL,
	[UserLastName] [varchar](50) NOT NULL,
	[UserCity] [nchar](10) NOT NULL,
	[UserEmailVerfied] [tinyint] NOT NULL,
	[UserRegisterDate] [timestamp] NOT NULL,
	[UserVerficationCode] [varchar](50) NOT NULL,
	[UserIP] [int] NOT NULL,
	[UserPhone] [varchar](50) NOT NULL,
	[UserCountry] [varchar](50) NOT NULL,
	[UserAddress] [varchar](100) NOT NULL,
	[UserAddress2] [varchar](100) NULL,
 CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 3/19/2022 12:51:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[VendorID] [int] NOT NULL,
	[VendorName] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Email] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Options]  WITH CHECK ADD  CONSTRAINT [FK_Options_OptionGroups] FOREIGN KEY([OptionGroupID])
REFERENCES [dbo].[OptionGroups] ([OptionGroupID])
GO
ALTER TABLE [dbo].[Options] CHECK CONSTRAINT [FK_Options_OptionGroups]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([DetailOrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([DetailProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[ProductOptions]  WITH CHECK ADD  CONSTRAINT [FK_ProductOptions_Options] FOREIGN KEY([OptionID])
REFERENCES [dbo].[Options] ([OptionID])
GO
ALTER TABLE [dbo].[ProductOptions] CHECK CONSTRAINT [FK_ProductOptions_Options]
GO
ALTER TABLE [dbo].[ProductOptions]  WITH CHECK ADD  CONSTRAINT [FK_ProductOptions_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[ProductOptions] CHECK CONSTRAINT [FK_ProductOptions_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductCategories] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductCategories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Vendor] FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendor] ([VendorID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Vendor]
GO
USE [master]
GO
ALTER DATABASE [OnlineShopping] SET  READ_WRITE 
GO
