USE [ClincAR]
GO
/****** Object:  Table [dbo].[PatDate]    Script Date: 2/12/2022 2:03:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatDate](
	[VisitDate] [date] NOT NULL,
	[phone_number] [varchar](13) NOT NULL,
	[NextVisit] [date] NULL,
 CONSTRAINT [Pat_Date_pk] PRIMARY KEY CLUSTERED 
(
	[VisitDate] ASC,
	[phone_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 2/12/2022 2:03:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[FirstName] [varchar](20) NOT NULL,
	[MidName] [varchar](20) NOT NULL,
	[LName] [varchar](20) NOT NULL,
	[P_num] [varchar](13) NOT NULL,
	[age] [int] NOT NULL,
	[Gender] [char](1) NULL,
 CONSTRAINT [PatPk] PRIMARY KEY CLUSTERED 
(
	[P_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatPic]    Script Date: 2/12/2022 2:03:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatPic](
	[ID] [int] NOT NULL,
	[img] [image] NULL,
	[phoneNumber] [varchar](13) NOT NULL,
 CONSTRAINT [PK_PatPic_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[phoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presc]    Script Date: 2/12/2022 2:03:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presc](
	[AppointmentDate] [date] NOT NULL,
	[PatPhone] [varchar](13) NOT NULL,
	[Medicines] [varchar](1000) NULL,
 CONSTRAINT [Presc_pk] PRIMARY KEY CLUSTERED 
(
	[PatPhone] ASC,
	[AppointmentDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PatDate]  WITH CHECK ADD  CONSTRAINT [Pat_Date_fk] FOREIGN KEY([phone_number])
REFERENCES [dbo].[Patient] ([P_num])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PatDate] CHECK CONSTRAINT [Pat_Date_fk]
GO
ALTER TABLE [dbo].[PatPic]  WITH CHECK ADD  CONSTRAINT [PatPic_fk] FOREIGN KEY([phoneNumber])
REFERENCES [dbo].[Patient] ([P_num])
GO
ALTER TABLE [dbo].[PatPic] CHECK CONSTRAINT [PatPic_fk]
GO
ALTER TABLE [dbo].[Presc]  WITH CHECK ADD  CONSTRAINT [Presc_fk] FOREIGN KEY([PatPhone])
REFERENCES [dbo].[Patient] ([P_num])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Presc] CHECK CONSTRAINT [Presc_fk]
GO
