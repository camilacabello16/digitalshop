USE [master]
GO
/****** Object:  Database [DigitalShop]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE DATABASE [DigitalShop]

ALTER DATABASE [DigitalShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DigitalShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DigitalShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DigitalShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DigitalShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [DigitalShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DigitalShop] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DigitalShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DigitalShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DigitalShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DigitalShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DigitalShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DigitalShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DigitalShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DigitalShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DigitalShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DigitalShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DigitalShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DigitalShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DigitalShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DigitalShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DigitalShop] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DigitalShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DigitalShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DigitalShop] SET  MULTI_USER 
GO
ALTER DATABASE [DigitalShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DigitalShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DigitalShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DigitalShop] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DigitalShop]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 26/12/2018 12:47:29 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Admin]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[PassWord] [nvarchar](max) NULL,
	[Type] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[PassWord] [nvarchar](max) NULL,
	[DisplayName] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Address] [ntext] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ImagesDetail]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImagesDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[ImageDetail] [nvarchar](max) NULL,
 CONSTRAINT [PK_ImagesDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Import]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[CreateBy] [int] NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[Detail] [ntext] NULL,
 CONSTRAINT [PK_Import] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ImportDetail]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImportId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ImportDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[ShipName] [nvarchar](max) NULL,
	[ShipMobile] [nvarchar](max) NULL,
	[ShipAddress] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 26/12/2018 12:47:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[PriceIn] [float] NOT NULL,
	[PriceOut] [float] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ManufacturerId] [int] NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[CreateBy] [int] NOT NULL,
	[ViewCount] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181108152922_First', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181117032354_upate_Manufacturer', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181118163018_Update_Product', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181210150132_Update_Customer', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181210150937_Update_Order', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181210154812_add_orderCode', N'2.1.4-rtm-31024')
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([Id], [UserName], [PassWord], [Type], [Status]) VALUES (1, N'maituyen', N'123', N'Root', 1)
INSERT [dbo].[Admin] ([Id], [UserName], [PassWord], [Type], [Status]) VALUES (2, N'admin1', N'12345', N'Root', 0)
INSERT [dbo].[Admin] ([Id], [UserName], [PassWord], [Type], [Status]) VALUES (3, N'admin2', N'12345', N'Staff', 1)
INSERT [dbo].[Admin] ([Id], [UserName], [PassWord], [Type], [Status]) VALUES (8, N'admin01', N'123', N'Root', 1)
INSERT [dbo].[Admin] ([Id], [UserName], [PassWord], [Type], [Status]) VALUES (9, N'admin', N'123', N'Root', 1)
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (1, N'Smart Phone', 1)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (3, N'Laptop', 0)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (5, N'Tivi', 1)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (28, N'Smart Watch', 1)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (30, N'Head Phone', 1)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (31, N'Audio', 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [UserName], [PassWord], [DisplayName], [Phone], [Address], [Status]) VALUES (1, N'tuyen@gmail.com', N'123456', N'Mai Tuyen', N'0344237615', N'Nam Đinh', 1)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Import] ON 

INSERT [dbo].[Import] ([Id], [Code], [CreateBy], [CreateAt], [Detail]) VALUES (1, N'DH01', 1, CAST(0x07A45D4B93691D3F0B AS DateTime2), N'Import 24/12/2018')
INSERT [dbo].[Import] ([Id], [Code], [CreateBy], [CreateAt], [Detail]) VALUES (2, N'DH02', 1, CAST(0x07214AAFB1691D3F0B AS DateTime2), N'import China product')
INSERT [dbo].[Import] ([Id], [Code], [CreateBy], [CreateAt], [Detail]) VALUES (3, N'DH03', 1, CAST(0x07BF0A31CD691D3F0B AS DateTime2), N'import December')
SET IDENTITY_INSERT [dbo].[Import] OFF
SET IDENTITY_INSERT [dbo].[ImportDetail] ON 

INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (1, 1, 19, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (2, 1, 24, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (3, 1, 20, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (4, 1, 21, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (5, 1, 18, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (6, 2, 17, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (7, 2, 3, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (8, 2, 9, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (9, 2, 22, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (10, 2, 14, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (11, 3, 13, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (12, 3, 12, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (13, 3, 15, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (14, 3, 16, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (15, 3, 11, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (16, 3, 23, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (17, 3, 26, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (18, 3, 27, 100)
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity]) VALUES (19, 3, 25, 100)
SET IDENTITY_INSERT [dbo].[ImportDetail] OFF
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 

INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (1, N'Apple', 1)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (2, N'Samsung', 1)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (3, N'Xiaomi', 0)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (9, N'LG', 0)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (10, N'Nokia', 0)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (13, N'Sony', 1)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (14, N'Panasonic', 1)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (15, N'AKG', 0)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (16, N'Dell', 1)
INSERT [dbo].[Manufacturer] ([Id], [Name], [Status]) VALUES (17, N'JBL', 1)
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [CustomerId], [CreateAt], [ShipName], [ShipMobile], [ShipAddress], [Status], [Code]) VALUES (1, 1, CAST(0x07D90DBB1E6A1D3F0B AS DateTime2), N'Tuyen', N'0123456', N'Nam Dinh', N'Approved', N'OD26122018123938')
INSERT [dbo].[Order] ([Id], [CustomerId], [CreateAt], [ShipName], [ShipMobile], [ShipAddress], [Status], [Code]) VALUES (2, 1, CAST(0x07B4EE98366A1D3F0B AS DateTime2), N'Tuyen', N'116543215', N'Ha Noi', N'Approved', N'OD26122018124018')
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (1, 1, 3, 1)
INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (2, 1, 12, 1)
INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (3, 1, 17, 2)
INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (4, 2, 27, 1)
INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Quantity]) VALUES (5, 2, 26, 1)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (3, N'Iphone X', N'
Manufacturer:	Apple
3G:	HSPA 42.2 / 5.76 Mbps, EV-DO Rev.A 3.1 Mbps
4G:	LTE-A (3CA) Cat12 600/150 Mbps
Size:	143.6 x 70.9 x 7.7 mm (5.65 x 2.79 x 0.30 in)
Weight:	174 g (6.14 oz)
SIM type:	Nano-SIM
Screen type:	OLED capacitive touch, 16 million colors
Screen size:	5.8 inches
Screen resolution:	1125 x 2436 pixels
Operating system:	iOS', N'/images/26122018121439_0.jpg|/images/SmartPhone/iphonex_1.jpg|/images/SmartPhone/iphonex_2.png|/images/SmartPhone/iphonex_3.png', 800, 900, 1, 1, CAST(0x070000000000F73E0B AS DateTime2), 1, 0, 103, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (9, N'Iphone XS Max', N'
Manufacturer:	Apple
3G:	HSPA 42.2 / 5.76 Mbps, EV-DO Rev.A 3.1 Mbps
4G:	LTE-A (3CA) Cat12 600/150 Mbps
Size:	143.6 x 70.9 x 7.7 mm (5.65 x 2.79 x 0.30 in)
Weight:	174 g (6.14 oz)
SIM type:	Nano-SIM
Screen type:	OLED capacitive touch, 16 million colors
Screen size:	5.8 inches
Screen resolution:	1125 x 2436 pixels
Operating system:	iOS', N'/images/SmartPhone/iphonexsmax.png|/images/26122018115120_1.png|/images/26122018115120_2.jpg|/images/SmartPhone/iphonexsmax.png', 1100, 1300, 1, 1, CAST(0x070000000000F73E0B AS DateTime2), 1, 0, 105, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (11, N'Samsung Galaxy S9', N'Manufacturer:	Samsung
3G:	HSPA 42.2 / 5.76 Mbps
4G:	LTE-A (6CA) Cat18 1200/200 Mbps
Size:	158.1 x 73.8 x 8.5 mm (6.22 x 2.91 x 0.33 in)
Weight:	189 g (6.67 oz)
SIM type:	2 SIM (Nano-SIM)
Screen type:	Super AMOLED capacitive touch, 16 million colors
Screen size:	6.2 inches
Screen resolution:	1440 x 2960 pixels
Operating system:	Android', N'/images/SmartPhone/galaxys9.jpg|/images/26122018115242_1.jpg|/images/SmartPhone/galaxys9_2.jpg|/images/SmartPhone/galaxys9_3.jpg', 900, 1000, 1, 2, CAST(0x070000000000F63E0B AS DateTime2), 1, 0, 106, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (12, N'Samsung Galaxy Note 8', N'Manufacturer:	Samsung
3G:	HSPA 42.2 / 5.76 Mbps
4G:	LTE-A (6CA) Cat18 1200/200 Mbps
Size:	158.1 x 73.8 x 8.5 mm (6.22 x 2.91 x 0.33 in)
Weight:	189 g (6.67 oz)
SIM type:	2 SIM (Nano-SIM)
Screen type:	Super AMOLED capacitive touch, 16 million colors
Screen size:	6.2 inches
Screen resolution:	1440 x 2960 pixels
Operating system:	Android', N'/images/26122018115518_0.jpg|/images/26122018115518_1.jpg|/images/26122018115518_2.jpg|/images/26122018115518_3.jpg', 850, 950, 1, 2, CAST(0x07802131A6631D3F0B AS DateTime2), 1, 0, 99, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (13, N'Samsung galaxy A8', N'Manufacturer:	Samsung
3G:	HSPA 42.2 / 5.76 Mbps
4G:	LTE-A (6CA) Cat18 1200/200 Mbps
Size:	158.1 x 73.8 x 8.5 mm (6.22 x 2.91 x 0.33 in)
Weight:	189 g (6.67 oz)
SIM type:	2 SIM (Nano-SIM)
Screen type:	Super AMOLED capacitive touch, 16 million colors
Screen size:	6.2 inches
Screen resolution:	1440 x 2960 pixels
Operating system:	Android', N'/images/26122018115650_0.jpg|/images/26122018115650_1.jpg|/images/26122018115650_2.jpg|/images/26122018115651_3.jpg', 700, 800, 1, 2, CAST(0x07808EADF3631D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (14, N'Samsung galaxy A6', N'Manufacturer:	Samsung
3G:	HSPA 42.2 / 5.76 Mbps
4G:	LTE-A (6CA) Cat18 1200/200 Mbps
Size:	158.1 x 73.8 x 8.5 mm (6.22 x 2.91 x 0.33 in)
Weight:	189 g (6.67 oz)
SIM type:	2 SIM (Nano-SIM)
Screen type:	Super AMOLED capacitive touch, 16 million colors
Screen size:	6.2 inches
Screen resolution:	1440 x 2960 pixels
Operating system:	Android', N'/images/26122018115811_0.png|/images/26122018115811_1.png|/images/26122018115811_2.png|/images/26122018115811_3.png', 500, 600, 1, 2, CAST(0x07801DF026641D3F0B AS DateTime2), 1, 0, 0, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (15, N'Samsung galaxy Note 9', N'Manufacturer:	Samsung
3G:	HSPA 42.2 / 5.76 Mbps
4G:	LTE-A (6CA) Cat18 1200/200 Mbps
Size:	158.1 x 73.8 x 8.5 mm (6.22 x 2.91 x 0.33 in)
Weight:	189 g (6.67 oz)
SIM type:	2 SIM (Nano-SIM)
Screen type:	Super AMOLED capacitive touch, 16 million colors
Screen size:	6.2 inches
Screen resolution:	1440 x 2960 pixels
Operating system:	Android', N'/images/26122018115925_0.jpg|/images/26122018115925_1.jpg|/images/26122018115925_2.jpg|/images/26122018115925_3.jpg', 1000, 1100, 1, 2, CAST(0x07807F0159641D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (16, N'Samsung Galaxy S7', N'Manufacturer:	Samsung
3G:	HSPA 42.2 / 5.76 Mbps
4G:	LTE-A (6CA) Cat18 1200/200 Mbps
Size:	158.1 x 73.8 x 8.5 mm (6.22 x 2.91 x 0.33 in)
Weight:	189 g (6.67 oz)
SIM type:	2 SIM (Nano-SIM)
Screen type:	Super AMOLED capacitive touch, 16 million colors
Screen size:	6.2 inches
Screen resolution:	1440 x 2960 pixels
Operating system:	Android', N'/images/26122018120032_0.png|/images/26122018120032_1.png|/images/26122018120032_2.png|/images/26122018120032_3.png', 300, 350, 1, 2, CAST(0x07802D4E86641D3F0B AS DateTime2), 1, 1, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (17, N'Iphone 8', N'
Manufacturer:	Apple
3G:	HSPA 42.2 / 5.76 Mbps, EV-DO Rev.A 3.1 Mbps
4G:	LTE-A (3CA) Cat12 600/150 Mbps
Size:	143.6 x 70.9 x 7.7 mm (5.65 x 2.79 x 0.30 in)
Weight:	174 g (6.14 oz)
SIM type:	Nano-SIM
Screen type:	OLED capacitive touch, 16 million colors
Screen size:	5.8 inches
Screen resolution:	1125 x 2436 pixels
Operating system:	iOS', N'/images/26122018120229_0.png|/images/26122018120229_1.png|/images/26122018120229_2.png|/images/26122018120229_3.png', 800, 850, 1, 1, CAST(0x0700DABCBD641D3F0B AS DateTime2), 1, 1, 98, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (18, N'Iphone 7', N'
Manufacturer:	Apple
3G:	HSPA 42.2 / 5.76 Mbps, EV-DO Rev.A 3.1 Mbps
4G:	LTE-A (3CA) Cat12 600/150 Mbps
Size:	143.6 x 70.9 x 7.7 mm (5.65 x 2.79 x 0.30 in)
Weight:	174 g (6.14 oz)
SIM type:	Nano-SIM
Screen type:	OLED capacitive touch, 16 million colors
Screen size:	5.8 inches
Screen resolution:	1125 x 2436 pixels
Operating system:	iOS', N'/images/26122018120408_0.png|/images/26122018120352_1.png|/images/26122018120352_2.png|/images/26122018120352_3.png', 350, 400, 1, 1, CAST(0x0780FF97F1641D3F0B AS DateTime2), 1, 0, 0, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (19, N'Apple MacBook Pro', N'
Manufacturer:	Apple
Size:	30.41 x 21.24 x 1.49 cm (11.97 x 8.36 x 0.59 in)
Weight:	1.37 kg (3.02 lb)
Screen type:	LED-backlit IPS LCD, 16 million colors
Screen size:	13.3 inches
Screen resolution:	2560 x 1600 pixels
Operating system:	MacOS
Operating system version:	OS X Sierra
CPU:	Intel Core i5 Dual-core 2.3 GHz, Turbo Boost up to 3.6 GHz, 64MB eDRAM
WLAN:	Wi-Fi 802.11 b / g / n / ac', N'/images/26122018120637_0.jpg|/images/26122018120637_1.jpg|/images/26122018120637_2.jpg|/images/26122018120637_3.jpg', 2000, 2200, 3, 1, CAST(0x0700C2DC5F651D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (20, N'Dell Inspiron 15 5570', N'
Manufacturer:	Dell
Size:	38 x 25.8 x 2.27 cm (14.96 x 10.16 x 0.89 in)
Weight:	2.33 kg (5.14 lb)
Screen type:	Anti-glare LED-Backlit
Screen size:	15.6 inches
Screen resolution:	1920 x 1080 pixels
Operating system:	Windows
Operating system version:	10 Home
CPU:	Intel Core i3-6006U 2 cores 2 GHz, 3 MB cache
WLAN:	Wi-Fi 802.11ac', N'/images/26122018121055_0.jpg|/images/26122018121036_1.jpg|/images/26122018121036_2.png|/images/26122018121037_3.png', 700, 800, 3, 16, CAST(0x0700130B9F651D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (21, N'Dell XPS 13 9360', N'
Manufacturer:	Dell
Size:	30.41 x 20.02 x 0.89 - 1.53 cm (11.97 x 7.88 x 0.35 - 0.60 in)
Weight:	1.22 kg (2.69 lb)
Screen type:	IPS InfinityEdge is anti-glare
Screen size:	13.3 inches
Screen resolution:	1920 x 1080 pixels
Operating system:	Windows
Operating system version:	10 Home
CPU:	Intel Core i5-8250U 4 cores 1.6 GHz, Turbo Boost up to 3.4 GHz, 6 MB cache
WLAN:	Wi-Fi 802.11ac', N'/images/26122018121305_0.png|/images/26122018121305_1.jpg|/images/26122018121305_2.png|/images/26122018121305_3.jpg', 3000, 3200, 3, 16, CAST(0x0780F94C4B661D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (22, N'JBL 110A8', N'
Size:	12.4 x 5.5 x 18.6 mm
Weight:	6.5g headset, 67g charger box
Waterproof:	IP56
Bluetooth:	Bluetooth 5.0
The battery:	Up to 15 hours of music listening', N'/images/26122018121835_0.jpg|/images/26122018121835_1.jpg|/images/26122018121835_2.jpg|/images/26122018121835_3.jpg', 200, 230, 30, 17, CAST(0x07805AD9E9661D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (23, N'Sony SRS-XB10 ', N'
Size:	75 x 91 mm
Weight:	260 g
Waterproof:	IPX5
Battery core	Li-Po', N'/images/26122018122241_0.jpg|/images/26122018122241_1.jpg|/images/26122018122241_2.jpg|/images/26122018122241_3.jpg', 300, 350, 31, 13, CAST(0x0700C8AE99671D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (24, N'Apple Watch 4', N'
Size:	75 x 91 mm
Weight:	260 g
Waterproof:	IPX5
Battery core	Li-Po', N'/images/26122018122358_0.jpg|/images/26122018122358_1.jpg|/images/26122018122358_2.jpg|/images/26122018122358_3.jpg', 400, 450, 28, 1, CAST(0x07000BB6D1671D3F0B AS DateTime2), 1, 0, 100, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (25, N'TV LG 43UK6340PTF', N'Television type: Smart TV
Screen size    : 55 inches
Resolution     :4K Ultra HD (3840 x 2160px)
Made in        :Indonesia
Year of launch :2018
', N'/images/26122018122711_0.jpg|/images/26122018122711_1.jpg|/images/26122018122711_2.jpg|/images/26122018122711_3.jpg', 1200, 1400, 5, 9, CAST(0x070094802D681D3F0B AS DateTime2), 1, 0, 0, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (26, N'Tivi Samsung 55NU7100', N'Television type: Smart TV
Screen size    : 55 inches
Resolution     :4K Ultra HD (3840 x 2160px)
Made in        :Indonesia
Year of launch :2018
', N'/images/26122018123118_0.png|/images/26122018123118_1.png|/images/26122018123118_2.jpg|/images/26122018123118_3.jpg', 1000, 1300, 5, 2, CAST(0x07800412C9681D3F0B AS DateTime2), 1, 0, 99, 1)
INSERT [dbo].[Product] ([Id], [Name], [Description], [Image], [PriceIn], [PriceOut], [CategoryId], [ManufacturerId], [CreateAt], [CreateBy], [ViewCount], [Quantity], [Status]) VALUES (27, N'Tivi Sony  50W660F', N'Television type: Smart TV
Screen size    : 55 inches
Resolution     :4K Ultra HD (3840 x 2160px)
Made in        :Indonesia
Year of launch :2018
', N'/images/26122018123319_0.png|/images/26122018123319_1.jpg|/images/26122018123319_2.jpg|/images/26122018123319_3.jpg', 13, 1499, 5, 13, CAST(0x0700AEC414691D3F0B AS DateTime2), 1, 0, 99, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
/****** Object:  Index [IX_ImagesDetail_ProductId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_ImagesDetail_ProductId] ON [dbo].[ImagesDetail]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Import_CreateBy]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_Import_CreateBy] ON [dbo].[Import]
(
	[CreateBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ImportDetail_ImportId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_ImportDetail_ImportId] ON [dbo].[ImportDetail]
(
	[ImportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ImportDetail_ProductId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_ImportDetail_ProductId] ON [dbo].[ImportDetail]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_CustomerId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_Order_CustomerId] ON [dbo].[Order]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_OrderId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_OrderId] ON [dbo].[OrderDetail]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_ProductId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_ProductId] ON [dbo].[OrderDetail]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_CategoryId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_Product_CategoryId] ON [dbo].[Product]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_CreateBy]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_Product_CreateBy] ON [dbo].[Product]
(
	[CreateBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_ManufacturerId]    Script Date: 26/12/2018 12:47:29 CH ******/
CREATE NONCLUSTERED INDEX [IX_Product_ManufacturerId] ON [dbo].[Product]
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ImagesDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImagesDetail_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ImagesDetail] CHECK CONSTRAINT [FK_ImagesDetail_Product_ProductId]
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [FK_Import_Admin_CreateBy] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[Admin] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [FK_Import_Admin_CreateBy]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Import_ImportId] FOREIGN KEY([ImportId])
REFERENCES [dbo].[Import] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Import_ImportId]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Product_ProductId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer_CustomerId]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product_ProductId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Admin_CreateBy] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[Admin] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Admin_CreateBy]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category_CategoryId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Manufacturer_ManufacturerId] FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[Manufacturer] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Manufacturer_ManufacturerId]
GO
USE [master]
GO
ALTER DATABASE [DigitalShop] SET  READ_WRITE 
GO
