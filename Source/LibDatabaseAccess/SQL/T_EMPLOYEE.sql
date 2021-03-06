USE [BAMTS_DB]
GO

/****** Object:  Table [dbo].[T_EMPLOYEE]    Script Date: 2022/05/18 16:08:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T_EMPLOYEE](
	[EMP_ID] [varchar](16) NOT NULL,
	[EMP_NAME] [nvarchar](64) NULL,
	[BIRTH_DATE] [datetime] NULL,
	[JOINED_DATE] [datetime] NULL,
	[USED_PAID_HOLIDAY] [int] NULL,
	[GENDER] [int] NULL,
	[CELLPHONE_NO] [varchar](32) NULL,
	[CELLPHONE_MAIL_ADDRESS] [varchar](64) NULL,
	[PC_MAIL_ADDRESS] [varchar](64) NULL,
	[PC_MAIL_PASSWORD] [varchar](64) NULL,
	[NOTE] [nvarchar](256) NULL,
 CONSTRAINT [PK_T_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[EMP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


