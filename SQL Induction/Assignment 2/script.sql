USE [master]
GO
/****** Object:  Database [assignment1]    Script Date: 06/20/2014 14:22:14 ******/
CREATE DATABASE [assignment1] ON  PRIMARY 
( NAME = N'assignment1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\assignment1.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'assignment1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\assignment1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [assignment1] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [assignment1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [assignment1] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [assignment1] SET ANSI_NULLS OFF
GO
ALTER DATABASE [assignment1] SET ANSI_PADDING OFF
GO
ALTER DATABASE [assignment1] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [assignment1] SET ARITHABORT OFF
GO
ALTER DATABASE [assignment1] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [assignment1] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [assignment1] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [assignment1] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [assignment1] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [assignment1] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [assignment1] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [assignment1] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [assignment1] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [assignment1] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [assignment1] SET  DISABLE_BROKER
GO
ALTER DATABASE [assignment1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [assignment1] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [assignment1] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [assignment1] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [assignment1] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [assignment1] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [assignment1] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [assignment1] SET  READ_WRITE
GO
ALTER DATABASE [assignment1] SET RECOVERY SIMPLE
GO
ALTER DATABASE [assignment1] SET  MULTI_USER
GO
ALTER DATABASE [assignment1] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [assignment1] SET DB_CHAINING OFF
GO
USE [assignment1]
GO
/****** Object:  Table [dbo].[t_activity]    Script Date: 06/20/2014 14:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_activity](
	[Activity_id] [int] NOT NULL,
	[Activity_description] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Activity_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[t_activity] ([Activity_id], [Activity_description]) VALUES (1, N'Code Analysis')
INSERT [dbo].[t_activity] ([Activity_id], [Activity_description]) VALUES (2, N'Lunch')
INSERT [dbo].[t_activity] ([Activity_id], [Activity_description]) VALUES (3, N'Coding')
INSERT [dbo].[t_activity] ([Activity_id], [Activity_description]) VALUES (4, N'Knowledge Transition')
INSERT [dbo].[t_activity] ([Activity_id], [Activity_description]) VALUES (5, N'Database')
/****** Object:  Table [dbo].[t_product_master]    Script Date: 06/20/2014 14:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_product_master](
	[Product_ID] [varchar](10) NOT NULL,
	[Product_Name] [varchar](25) NULL,
	[Cost_Per_Item] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[t_product_master] ([Product_ID], [Product_Name], [Cost_Per_Item]) VALUES (N'P1', N'Pen', 10)
INSERT [dbo].[t_product_master] ([Product_ID], [Product_Name], [Cost_Per_Item]) VALUES (N'P2', N'Scale', 15)
INSERT [dbo].[t_product_master] ([Product_ID], [Product_Name], [Cost_Per_Item]) VALUES (N'P3', N'Notebook', 25)
/****** Object:  Table [dbo].[t_emp]    Script Date: 06/20/2014 14:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_emp](
	[Emp_id] [int] IDENTITY(1001,2) NOT NULL,
	[Emp_Code] [varchar](20) NULL,
	[Emp_f_name] [varchar](30) NOT NULL,
	[Emp_m_name] [varchar](30) NULL,
	[Emp_l_name] [varchar](30) NULL,
	[Emp_DOB] [date] NULL,
	[Emp_DOJ] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[t_emp] ON
INSERT [dbo].[t_emp] ([Emp_id], [Emp_Code], [Emp_f_name], [Emp_m_name], [Emp_l_name], [Emp_DOB], [Emp_DOJ]) VALUES (1005, N'OPT20110105', N'Manmohan', NULL, N'Singh', CAST(0xEE0B0B00 AS Date), CAST(0xDC320B00 AS Date))
INSERT [dbo].[t_emp] ([Emp_id], [Emp_Code], [Emp_f_name], [Emp_m_name], [Emp_l_name], [Emp_DOB], [Emp_DOJ]) VALUES (1011, N'OPT20110190', N'Harish', N'Kumar', N'Shakya', CAST(0x95130B00 AS Date), CAST(0x77250B00 AS Date))
SET IDENTITY_INSERT [dbo].[t_emp] OFF
/****** Object:  Table [dbo].[t_user_master]    Script Date: 06/20/2014 14:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_user_master](
	[User_ID] [varchar](10) NOT NULL,
	[User_Name] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[t_user_master] ([User_ID], [User_Name]) VALUES (N'U1', N'Alfred Lawrence')
INSERT [dbo].[t_user_master] ([User_ID], [User_Name]) VALUES (N'U2', N'William Paul')
INSERT [dbo].[t_user_master] ([User_ID], [User_Name]) VALUES (N'U3', N'Edward Fillip')
/****** Object:  Table [dbo].[t_transaction]    Script Date: 06/20/2014 14:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_transaction](
	[User_ID] [varchar](10) NULL,
	[Product_ID] [varchar](10) NULL,
	[Transaction_Date] [date] NOT NULL,
	[Transaction_Type] [varchar](20) NOT NULL,
	[Transaction_Amount] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[t_transaction] ([User_ID], [Product_ID], [Transaction_Date], [Transaction_Type], [Transaction_Amount]) VALUES (N'U1', N'P1', CAST(0x75330B00 AS Date), N'Order', 150)
INSERT [dbo].[t_transaction] ([User_ID], [Product_ID], [Transaction_Date], [Transaction_Type], [Transaction_Amount]) VALUES (N'U1', N'P1', CAST(0x8F330B00 AS Date), N'Payment', 750)
INSERT [dbo].[t_transaction] ([User_ID], [Product_ID], [Transaction_Date], [Transaction_Type], [Transaction_Amount]) VALUES (N'U1', N'P1', CAST(0x8F330B00 AS Date), N'Order', 200)
INSERT [dbo].[t_transaction] ([User_ID], [Product_ID], [Transaction_Date], [Transaction_Type], [Transaction_Amount]) VALUES (N'U1', N'P3', CAST(0x94330B00 AS Date), N'Order', 50)
INSERT [dbo].[t_transaction] ([User_ID], [Product_ID], [Transaction_Date], [Transaction_Type], [Transaction_Amount]) VALUES (N'U3', N'P2', CAST(0x95330B00 AS Date), N'Order', 100)
INSERT [dbo].[t_transaction] ([User_ID], [Product_ID], [Transaction_Date], [Transaction_Type], [Transaction_Amount]) VALUES (N'U2', N'P1', CAST(0xA8330B00 AS Date), N'Order', 75)
INSERT [dbo].[t_transaction] ([User_ID], [Product_ID], [Transaction_Date], [Transaction_Type], [Transaction_Amount]) VALUES (N'U3', N'P2', CAST(0xC7330B00 AS Date), N'Payment', 250)
/****** Object:  Table [dbo].[t_salary]    Script Date: 06/20/2014 14:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_salary](
	[Salary_id] [int] IDENTITY(1001,1) NOT NULL,
	[Emp_Id] [int] NULL,
	[Changed_date] [date] NULL,
	[New_Salary] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Salary_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[t_salary] ON
INSERT [dbo].[t_salary] ([Salary_id], [Emp_Id], [Changed_date], [New_Salary]) VALUES (1001, 1011, CAST(0xE7330B00 AS Date), CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[t_salary] ([Salary_id], [Emp_Id], [Changed_date], [New_Salary]) VALUES (1002, 1011, CAST(0xBD330B00 AS Date), CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[t_salary] ([Salary_id], [Emp_Id], [Changed_date], [New_Salary]) VALUES (1003, 1005, CAST(0xE7330B00 AS Date), CAST(26000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[t_salary] OFF
/****** Object:  Table [dbo].[t_atten_det]    Script Date: 06/20/2014 14:22:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_atten_det](
	[Atten_id] [int] IDENTITY(1001,1) NOT NULL,
	[Emp_id] [int] NULL,
	[Activity_id] [int] NULL,
	[Atten_start_datetime] [datetime] NULL,
	[Atten_end_hrs] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Atten_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[t_atten_det] ON
INSERT [dbo].[t_atten_det] ([Atten_id], [Emp_id], [Activity_id], [Atten_start_datetime], [Atten_end_hrs]) VALUES (1001, 1005, 5, CAST(0x00009E8900A4CB80 AS DateTime), 2)
INSERT [dbo].[t_atten_det] ([Atten_id], [Emp_id], [Activity_id], [Atten_start_datetime], [Atten_end_hrs]) VALUES (1002, 1005, 1, CAST(0x00009E6B00A4CB80 AS DateTime), 3)
INSERT [dbo].[t_atten_det] ([Atten_id], [Emp_id], [Activity_id], [Atten_start_datetime], [Atten_end_hrs]) VALUES (1003, 1005, 3, CAST(0x00009E6B00D63BC0 AS DateTime), 5)
INSERT [dbo].[t_atten_det] ([Atten_id], [Emp_id], [Activity_id], [Atten_start_datetime], [Atten_end_hrs]) VALUES (1004, 1011, 5, CAST(0x00009E8C00A4CB80 AS DateTime), 8)
INSERT [dbo].[t_atten_det] ([Atten_id], [Emp_id], [Activity_id], [Atten_start_datetime], [Atten_end_hrs]) VALUES (1005, 1011, 5, CAST(0x00009E8D00A4CB80 AS DateTime), 8)
INSERT [dbo].[t_atten_det] ([Atten_id], [Emp_id], [Activity_id], [Atten_start_datetime], [Atten_end_hrs]) VALUES (1006, 1011, 5, CAST(0x00009E8F00A4CB80 AS DateTime), 7)
SET IDENTITY_INSERT [dbo].[t_atten_det] OFF
/****** Object:  Check [CK__t_product__Cost___023D5A04]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_product_master]  WITH CHECK ADD CHECK  (([Cost_Per_Item]>(0)))
GO
/****** Object:  Check [CK__t_emp__Emp_DOB__21B6055D]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_emp]  WITH CHECK ADD CHECK  ((datediff(year,[Emp_DOB],getdate())>(18)))
GO
/****** Object:  Check [CK__t_transac__Trans__09DE7BCC]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_transaction]  WITH CHECK ADD CHECK  (([Transaction_Amount]>(0)))
GO
/****** Object:  ForeignKey [FK__t_transac__Produ__08EA5793]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_transaction]  WITH CHECK ADD FOREIGN KEY([Product_ID])
REFERENCES [dbo].[t_product_master] ([Product_ID])
GO
/****** Object:  ForeignKey [FK__t_transac__User___07F6335A]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_transaction]  WITH CHECK ADD FOREIGN KEY([User_ID])
REFERENCES [dbo].[t_user_master] ([User_ID])
GO
/****** Object:  ForeignKey [FK__t_salary__Emp_Id__300424B4]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_salary]  WITH CHECK ADD FOREIGN KEY([Emp_Id])
REFERENCES [dbo].[t_emp] ([Emp_id])
GO
/****** Object:  ForeignKey [FK__t_atten_d__Activ__2B3F6F97]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_atten_det]  WITH CHECK ADD FOREIGN KEY([Activity_id])
REFERENCES [dbo].[t_activity] ([Activity_id])
GO
/****** Object:  ForeignKey [FK__t_atten_d__Emp_i__2A4B4B5E]    Script Date: 06/20/2014 14:22:14 ******/
ALTER TABLE [dbo].[t_atten_det]  WITH CHECK ADD FOREIGN KEY([Emp_id])
REFERENCES [dbo].[t_emp] ([Emp_id])
GO
