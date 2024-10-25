USE [ProjectPRN5]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 14/12/2023 1:57:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[classId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[status] [int] NULL,
	[semester] [int] NULL,
	[teacherId] [int] NULL,
	[courseId] [int] NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[classId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 14/12/2023 1:57:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[courseId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[courseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseGrades]    Script Date: 14/12/2023 1:57:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseGrades](
	[courseGradeId] [int] IDENTITY(1,1) NOT NULL,
	[gradeName] [varchar](50) NULL,
	[courseId] [int] NULL,
	[weight] [float] NULL,
 CONSTRAINT [PK_CourseGrades] PRIMARY KEY CLUSTERED 
(
	[courseGradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 14/12/2023 1:57:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[gradeId] [int] IDENTITY(1,1) NOT NULL,
	[classId] [int] NULL,
	[courseGradeId] [int] NULL,
	[studentID] [varchar](10) NULL,
	[score] [float] NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[gradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_classes]    Script Date: 14/12/2023 1:57:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_classes](
	[student_class_id] [int] IDENTITY(1,1) NOT NULL,
	[classId] [int] NULL,
	[studentID] [varchar](10) NULL,
 CONSTRAINT [PK_Student_classes] PRIMARY KEY CLUSTERED 
(
	[student_class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 14/12/2023 1:57:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[studentID] [varchar](10) NOT NULL,
	[email] [varchar](50) NULL,
	[comment] [nvarchar](250) NULL,
	[name] [nvarchar](50) NULL,
	[dob] [date] NULL,
	[gender] [nvarchar](50) NULL,
	[address] [varchar](50) NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 14/12/2023 1:57:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[teacherId] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_ Teacher] PRIMARY KEY CLUSTERED 
(
	[teacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([classId], [name], [status], [semester], [teacherId], [courseId]) VALUES (1, N'SE1717', 1, NULL, 1, 1)
INSERT [dbo].[Classes] ([classId], [name], [status], [semester], [teacherId], [courseId]) VALUES (2, N'SE1717', 1, NULL, 1, 2)
INSERT [dbo].[Classes] ([classId], [name], [status], [semester], [teacherId], [courseId]) VALUES (3, N'SE1717', 1, NULL, 1, 3)
INSERT [dbo].[Classes] ([classId], [name], [status], [semester], [teacherId], [courseId]) VALUES (4, N'SE1712', 1, NULL, 2, 4)
INSERT [dbo].[Classes] ([classId], [name], [status], [semester], [teacherId], [courseId]) VALUES (5, N'SE1712', 1, NULL, 2, 5)
INSERT [dbo].[Classes] ([classId], [name], [status], [semester], [teacherId], [courseId]) VALUES (6, N'SE1712', 1, NULL, 2, 6)
SET IDENTITY_INSERT [dbo].[Classes] OFF
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([courseId], [name], [status]) VALUES (1, N'PRF', 1)
INSERT [dbo].[Course] ([courseId], [name], [status]) VALUES (2, N'PRO', 1)
INSERT [dbo].[Course] ([courseId], [name], [status]) VALUES (3, N'PRJ', 1)
INSERT [dbo].[Course] ([courseId], [name], [status]) VALUES (4, N'SSG', 1)
INSERT [dbo].[Course] ([courseId], [name], [status]) VALUES (5, N'MAE', 1)
INSERT [dbo].[Course] ([courseId], [name], [status]) VALUES (6, N'DBI', 1)
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseGrades] ON 

INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (1, N'Lab1', 1, 10)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (2, N'Lab2', 1, 10)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (3, N'PT1', 1, 15)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (4, N'PT1', 2, 20)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (5, N'PT2', 2, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (6, N'FE', 2, 40)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (7, N'PT1', 3, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (8, N'PT2', 3, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (9, N'FE', 3, 40)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (10, N'PT1', 4, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (11, N'PT2', 4, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (12, N'FE', 4, 40)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (13, N'PT1', 5, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (14, N'PT2', 5, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (15, N'FE', 5, 40)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (16, N'PT1', 6, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (17, N'PT2', 6, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (18, N'PE', 6, 40)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (20, N'PT2', 1, 15)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (21, N'FE', 1, 30)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (22, N'PE', 1, 20)
INSERT [dbo].[CourseGrades] ([courseGradeId], [gradeName], [courseId], [weight]) VALUES (23, N'PE', 2, 10)
SET IDENTITY_INSERT [dbo].[CourseGrades] OFF
GO
SET IDENTITY_INSERT [dbo].[Grade] ON 

INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (1, 1, 1, N'HE161601', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (2, 1, 1, N'HE161602', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (3, 1, 1, N'HE161603', 5)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (4, 1, 1, N'HE161604', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (5, 1, 1, N'HE161605', 5)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (6, 1, 2, N'HE161601', 9)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (7, 1, 2, N'HE161602', 10)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (8, 1, 2, N'HE161603', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (9, 1, 2, N'HE161604', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (10, 1, 2, N'HE161605', 9)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (11, 1, 3, N'HE161601', 9)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (12, 1, 3, N'HE161602', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (13, 1, 3, N'HE161603', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (14, 1, 3, N'HE161604', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (15, 1, 3, N'HE161605', 10)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (16, 2, 4, N'HE161601', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (17, 2, 4, N'HE161602', 2)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (18, 2, 4, N'HE161603', 3)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (19, 2, 4, N'HE161604', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (20, 2, 4, N'HE161605', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (21, 2, 5, N'HE161601', 10)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (22, 2, 5, N'HE161602', 7)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (23, 2, 5, N'HE161603', 3)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (24, 2, 5, N'HE161604', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (25, 2, 5, N'HE161605', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (26, 2, 6, N'HE161601', 9)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (27, 2, 6, N'HE161602', 7)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (28, 2, 6, N'HE161603', 3)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (29, 2, 6, N'HE161604', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (30, 2, 6, N'HE161605', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (31, 6, 16, N'HE161601', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (32, 6, 16, N'HE161602', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (33, 6, 16, N'HE161603', 2)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (34, 6, 16, N'HE161604', 3)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (35, 6, 16, N'HE161605', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (36, 6, 17, N'HE161601', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (37, 6, 17, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (38, 6, 17, N'HE161603', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (39, 6, 17, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (40, 6, 17, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (41, 6, 18, N'HE161601', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (42, 6, 18, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (43, 6, 18, N'HE161603', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (44, 6, 18, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (45, 6, 18, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (46, 1, 1, N'HE161606', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (47, 1, 2, N'HE161606', 2)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (48, 1, 3, N'HE161606', 3)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (49, 1, 20, N'HE161601', 9)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (50, 1, 20, N'HE161602', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (51, 1, 20, N'HE161603', 8)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (52, 1, 20, N'HE161604', 3)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (53, 1, 20, N'HE161605', 2)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (54, 1, 20, N'HE161606', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (55, 1, 21, N'HE161601', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (56, 1, 21, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (57, 1, 21, N'HE161603', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (58, 1, 21, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (59, 1, 21, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (60, 1, 21, N'HE161606', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (61, 1, 22, N'HE161601', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (62, 1, 22, N'HE161602', 2)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (63, 1, 22, N'HE161603', 3)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (64, 1, 22, N'HE161604', 4)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (65, 1, 22, N'HE161605', 5)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (66, 1, 22, N'HE161606', 6)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (67, 4, 10, N'HE161601', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (68, 4, 11, N'HE161601', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (69, 4, 12, N'HE161601', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (70, 4, 10, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (71, 4, 11, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (72, 4, 12, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (73, 4, 10, N'HE161603', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (74, 4, 11, N'HE161603', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (75, 4, 12, N'HE161603', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (76, 4, 10, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (77, 4, 11, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (78, 4, 12, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (79, 4, 10, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (80, 4, 11, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (81, 4, 12, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (82, 5, 13, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (83, 5, 14, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (84, 5, 15, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (85, 5, 13, N'HE161601', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (86, 5, 14, N'HE161601', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (87, 5, 15, N'HE161601', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (88, 5, 13, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (89, 5, 14, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (90, 5, 15, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (91, 5, 13, N'HE161607', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (92, 5, 14, N'HE161607', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (93, 5, 15, N'HE161607', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (94, 5, 13, N'HE161608', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (95, 5, 14, N'HE161608', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (96, 5, 15, N'HE161608', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (97, 3, 7, N'HE161601', 1)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (98, 3, 8, N'HE161601', 2)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (99, 3, 9, N'HE161601', NULL)
GO
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (100, 3, 7, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (101, 3, 8, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (102, 3, 9, N'HE161602', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (103, 3, 7, N'HE161607', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (104, 3, 8, N'HE161607', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (105, 3, 9, N'HE161607', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (106, 3, 7, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (107, 3, 8, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (108, 3, 9, N'HE161604', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (109, 3, 7, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (110, 3, 8, N'HE161605', NULL)
INSERT [dbo].[Grade] ([gradeId], [classId], [courseGradeId], [studentID], [score]) VALUES (111, 3, 9, N'HE161605', NULL)
SET IDENTITY_INSERT [dbo].[Grade] OFF
GO
SET IDENTITY_INSERT [dbo].[Student_classes] ON 

INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (1, 1, N'HE161601')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (2, 1, N'HE161602')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (3, 1, N'HE161603')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (4, 1, N'HE161604')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (5, 1, N'HE161605')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (6, 2, N'HE161601')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (7, 2, N'HE161602')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (8, 2, N'HE161603')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (9, 2, N'HE161604')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (10, 2, N'HE161605')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (11, 6, N'HE161601')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (12, 6, N'HE161602')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (13, 6, N'HE161603')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (14, 6, N'HE161604')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (15, 6, N'HE161605')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (16, 1, N'HE161606')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (17, 4, N'HE161601')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (18, 4, N'HE161602')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (19, 4, N'HE161603')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (20, 4, N'HE161604')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (21, 4, N'HE161605')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (22, 5, N'HE161605')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (23, 5, N'HE161601')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (24, 5, N'HE161602')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (25, 5, N'HE161607')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (26, 5, N'HE161608')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (27, 3, N'HE161601')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (28, 3, N'HE161602')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (29, 3, N'HE161607')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (30, 3, N'HE161604')
INSERT [dbo].[Student_classes] ([student_class_id], [classId], [studentID]) VALUES (31, 3, N'HE161605')
SET IDENTITY_INSERT [dbo].[Student_classes] OFF
GO
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161601', N'student1@example.com', NULL, N'Huy Hoang', CAST(N'2002-05-15' AS Date), N'Male', N'123 Street, City', 1)
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161602', N'student2@example.com', NULL, N'Van An', CAST(N'2002-06-20' AS Date), N'Female', N'456 Avenue, Town', 1)
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161603', N'student3@example.com', NULL, N'Cong Minh', CAST(N'2001-07-25' AS Date), N'Male', N'789 Road, Village', 1)
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161604', N'student4@example.com', NULL, N'Manh Dat', CAST(N'2002-08-30' AS Date), N'Female', N'1011 Lane, County', 1)
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161605', N'student5@example.com', NULL, N'Hoa La', CAST(N'2002-09-05' AS Date), N'Male', N'1213 Boulevard, State', 1)
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161606', N'student16@example.com', NULL, N'Bac Hoi', CAST(N'2002-05-15' AS Date), N'Male', N'123 Street, City', 1)
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161607', N'student16@example1.com', NULL, N'Hoa lo', CAST(N'2002-05-15' AS Date), N'Male', N'123 Street, City', 1)
INSERT [dbo].[Students] ([studentID], [email], [comment], [name], [dob], [gender], [address], [status]) VALUES (N'HE161608', N'student16@exam.com', NULL, N'Khanh Thanh', CAST(N'2002-05-15' AS Date), N'Male', N'123 Street, City', 1)
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([teacherId], [email], [password], [name], [status]) VALUES (1, N'vinhnqhe@gmail.com', N'pass1', N'vinhnq', 1)
INSERT [dbo].[Teacher] ([teacherId], [email], [password], [name], [status]) VALUES (2, N'hoa123@gmail.com', N'pass2', N'hoa123', 1)
INSERT [dbo].[Teacher] ([teacherId], [email], [password], [name], [status]) VALUES (3, N'user3@gmail.com', N'pass3', N'anam', 1)
INSERT [dbo].[Teacher] ([teacherId], [email], [password], [name], [status]) VALUES (4, N'user4@gmail.com', N'pass4', N'hoaq12', 1)
INSERT [dbo].[Teacher] ([teacherId], [email], [password], [name], [status]) VALUES (5, N'user5@gmail.com', N'pass5', N'abc123', 1)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD FOREIGN KEY([courseId])
REFERENCES [dbo].[Course] ([courseId])
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD FOREIGN KEY([teacherId])
REFERENCES [dbo].[Teacher] ([teacherId])
GO
ALTER TABLE [dbo].[CourseGrades]  WITH CHECK ADD FOREIGN KEY([courseId])
REFERENCES [dbo].[Course] ([courseId])
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([classId])
REFERENCES [dbo].[Classes] ([classId])
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([courseGradeId])
REFERENCES [dbo].[CourseGrades] ([courseGradeId])
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([studentID])
REFERENCES [dbo].[Students] ([studentID])
GO
ALTER TABLE [dbo].[Student_classes]  WITH CHECK ADD FOREIGN KEY([classId])
REFERENCES [dbo].[Classes] ([classId])
GO
ALTER TABLE [dbo].[Student_classes]  WITH CHECK ADD FOREIGN KEY([studentID])
REFERENCES [dbo].[Students] ([studentID])
GO
