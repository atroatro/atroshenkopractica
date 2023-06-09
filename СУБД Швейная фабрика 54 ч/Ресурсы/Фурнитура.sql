SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furnitura](
	[idfur] [int] IDENTITY(1,1) NOT NULL,
	[namefur] [nvarchar](50) NULL,
	[photo] [nvarchar](50) NULL,
	[countfur] [int] NULL,
 CONSTRAINT [PK_Furnitura] PRIMARY KEY CLUSTERED 
(
	[idfur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Furnitura] ON 

INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (1, N'Бусинки 1 ', 'Бусинки 1.jpg', 20)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (2, N'Бусинки 2 ', 'Бусинки 2.jpg', 31)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (3, N'Бусинки 3 ', 'Бусинки 3.jpg', 150)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (4, N'Бусинки 4 ', 'Бусинки 4.jpg', 210)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (5, N'Бусинки 5 ', 'Бусинки 5.jpg', 115)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (6, N'Пряжка 1  ', 'Пряжка 1.jpg', 432)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (7, N'Пряжка 2  ', 'Пряжка 2.jpg', 54)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (8, N'Пряжка 3  ', 'Пряжка 3.jpg', 542)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (9, N'Пряжка 4  ', 'Пряжка 4.jpg', 458)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (10, N'Пуговицы 1', 'Пуговицы 1.jpg', 54)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (11, N'Пуговицы 2', 'Пуговицы 2.jpg', 354)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (12, N'Пуговицы 3', 'Пуговицы 3.jpg', 78)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (13, N'Пуговицы 4', 'Пуговицы 4.jpg', 576)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (14, N'Пуговицы 5', 'Пуговицы 5.jpg', 43)
SET IDENTITY_INSERT [dbo].[Furnitura] OFF
