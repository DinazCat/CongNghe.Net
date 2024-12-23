USE [master]
GO
/****** Object:  Database [SalesManagementDB]    Script Date: 04/11/2024 10:02:12 CH ******/
CREATE DATABASE [SalesManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalesManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SalesManagementDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SalesManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SalesManagementDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SalesManagementDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalesManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalesManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalesManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalesManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalesManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalesManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalesManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalesManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalesManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalesManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalesManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalesManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalesManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalesManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalesManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalesManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalesManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalesManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalesManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalesManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalesManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalesManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalesManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalesManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SalesManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [SalesManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalesManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalesManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalesManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SalesManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SalesManagementDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SalesManagementDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [SalesManagementDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SalesManagementDB]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 04/11/2024 10:02:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 04/11/2024 10:02:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImages]    Script Date: 04/11/2024 10:02:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImages](
	[ImageId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[ImageUrl] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 04/11/2024 10:02:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Brand] [nvarchar](100) NULL,
	[Manufacturer] [nvarchar](100) NULL,
	[Material] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryId] [int] NULL,
	[MainImg] [nvarchar](100) NULL,
	[Price] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductVariants]    Script Date: 04/11/2024 10:02:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductVariants](
	[VariantId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Size] [nvarchar](50) NULL,
	[Color] [nvarchar](50) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Stock] [int] NOT NULL,
	[ImageUrl] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[VariantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 04/11/2024 10:02:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PhoneNumber] [nvarchar](15) NULL,
	[Address] [nvarchar](255) NULL,
	[Password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [Name], [Description]) VALUES (1, N'Men', N'Men`s clothing and accessories')
INSERT [dbo].[Categories] ([CategoryId], [Name], [Description]) VALUES (2, N'Women', N'Women`s clothing and accessories')
INSERT [dbo].[Categories] ([CategoryId], [Name], [Description]) VALUES (3, N'Kids', N'Kids` clothing and accessories')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductImages] ON 

INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (1, 1, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (2, 1, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (3, 1, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (4, 2, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (5, 2, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (6, 2, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (7, 3, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (8, 3, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (9, 3, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (10, 4, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (11, 4, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (12, 4, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (13, 5, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (14, 5, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (15, 5, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (16, 6, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (17, 6, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (18, 6, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (19, 7, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (20, 7, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (21, 7, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (22, 8, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (23, 8, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (24, 8, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (25, 9, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (26, 9, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (27, 9, N'single_3.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (28, 10, N'single_1.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (29, 10, N'single_2.jpg')
INSERT [dbo].[ProductImages] ([ImageId], [ProductId], [ImageUrl]) VALUES (30, 10, N'single_3.jpg')
SET IDENTITY_INSERT [dbo].[ProductImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (1, N'Slim Fit Black Shirt', N'UrbanWear', N'TailorMade Inc.', N'Cotton', N'A stylish black slim fit shirt for men.', 1, N'product_1.png', CAST(119.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (2, N'Casual Blue Jeans', N'DenimWorks', N'BlueDenim Ltd.', N'Denim', N'Classic blue jeans perfect for everyday wear.', 1, N'product_2.png', CAST(39.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (3, N'Leather Jacket', N'RiderGear', N'MotoCraft', N'Leather', N'A premium leather jacket for men.', 1, N'product_3.png', CAST(59.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (4, N'Summer Floral Dress', N'BloomStyle', N'SilkFabrics Co.', N'Silk', N'A light floral summer dress for women.', 2, N'product_4.png', CAST(49.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (5, N'Classic Black Heels', N'Eleganza', N'Shoemaker Ltd.', N'Leather', N'Elegant black heels for formal occasions.', 2, N'product_5.png', CAST(39.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (6, N'Knitted Sweater', N'CozyWear', N'WinterCrafts', N'Wool', N'A warm knitted sweater for women.', 2, N'product_6.png', CAST(29.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (7, N'Boys Graphic T-Shirt', N'PlayTime', N'FunFactory', N'Cotton', N'A playful graphic t-shirt for boys.', 3, N'product_7.png', CAST(29.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (8, N'Girls Denim Skirt', N'KidStyle', N'TinyThreads', N'Denim', N'A cute denim skirt for girls.', 3, N'product_8.png', CAST(39.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (9, N'Sports Shoes', N'ActiveFeet', N'RunFast Ltd.', N'Synthetic', N'Durable sports shoes for kids.', 3, N'product_9.png', CAST(59.99 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([ProductId], [Name], [Brand], [Manufacturer], [Material], [Description], [CategoryId], [MainImg], [Price]) VALUES (10, N'Kids Rain Jacket', N'RainyDays', N'WeatherProof Inc.', N'Polyester', N'A waterproof rain jacket for kids.', 3, N'product_10.png', CAST(19.99 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FullName], [Email], [PhoneNumber], [Address], [Password]) VALUES (1, N'John Wick', N'abc@gmail.com', NULL, NULL, N'123')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Accounts__C9F28456D169A614]    Script Date: 04/11/2024 10:02:13 CH ******/
ALTER TABLE [dbo].[Accounts] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__A9D1053432DD8E27]    Script Date: 04/11/2024 10:02:13 CH ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[ProductImages]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[ProductVariants]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
USE [master]
GO
ALTER DATABASE [SalesManagementDB] SET  READ_WRITE 
GO
