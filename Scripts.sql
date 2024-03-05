-- Scripts by Sujata STARTS

USE [OSOL23]
GO
PRINT N'Altering Procedure [dbo].[SP_GET_DEN_DENGI_RECEIPT_DATA]...';
/****** Object:  StoredProcedure [dbo].[DML_SEC_LOGIN_DETAILS]    Script Date: 02-03-2024 14:37:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DML_SEC_LOGIN_DETAILS]
    @FLAG VARCHAR(10)=NULL,
	@USER_ID int,
	@LOGGED_IN_TIME DATETIME=NULL,
	@LOGGED_OUT_TIME DATETIME=NULL,
	@LOGIN_TYPE varchar(100)=NULL,
	@ENTERED_BY varchar(50)=null
	
	
GO
	
 ALTER PROCEDURE [dbo].[SP_GET_DEN_DENGI_RECEIPT_DATA]
(
    @RECEIPT_F_NO NUMERIC(20,0) = NULL,
    @RECEIPT_L_NO NUMERIC(20,0) = NULL,
    @NAME VARCHAR(50) = NULL,
    @FDATE DATETIME = NULL,
    @LDATE DATETIME = NULL,
    @MOBILE_NUMBER VARCHAR(50) = NULL,
    --@DENGI_TYPE INT,
    @LOC_ID INT,
    @DEPT_ID INT,
    @CTR_MACH_ID INT
)
AS
as
BEGIN
    SELECT   
	R.DENGI_RECEIPT_ID,
        R.DR_DATE as DATE, 
        R.SERIAL_NO AS [SERIAL NUMBER],
        MST.TYPE AS [DENGI TYPE], 
        R.NAME,
        R.AMOUNT,
        R.CONTACT AS [MOBILE NUMBER],
		R.DOC_DETAIL AS [DOCUMENT DETAILS],
        R.GOTRA_NAME AS GOTRA, 
        R.ADDRESS,
		T.Token_Detail_Name AS [PAYMENT TYPE]
IF @FLAG='I'
BEGIN
    INSERT INTO SEC_LOGIN_DETAILS
	(USER_ID,LOGIN_TYPE,ENTERED_BY)
   VALUES (@USER_ID,@LOGIN_TYPE,@ENTERED_BY);

    FROM 
        DEN_DENGI_RECEIPT_MST_T R
    INNER JOIN 
        com_token_det_t T ON R.PAYMENT_TYPE_ID = T.Token_Detail_Id
    INNER JOIN 
        DEN_DENGI_MASTER_T MST ON R.DENGI_MST_ID = MST.DENGI_MST_ID
    LEFT JOIN 
        tbl_gotra_master G ON R.GOTRA_ID = G.gotra_id
    WHERE 
        R.DR_DATE BETWEEN CONVERT(DATETIME, @FDATE, 103) AND CONVERT(DATETIME, @LDATE, 103)
        AND (@RECEIPT_F_NO IS NULL OR SERIAL_NO >= @RECEIPT_F_NO)
        AND (@RECEIPT_L_NO IS NULL OR SERIAL_NO <= @RECEIPT_L_NO)
        AND (@NAME IS NULL OR Name = @Name)
        --AND (@DENGI_TYPE IS NULL OR R.DENGI_MST_ID = @DENGI_TYPE)
        AND (@MOBILE_NUMBER IS NULL OR R.CONTACT = @MOBILE_NUMBER)
        AND LOC_ID = @LOC_ID
        AND DEPT_ID = @DEPT_ID
        AND CTR_MACH_ID = @CTR_MACH_ID
    INSERT INTO SEC_ACTIVE_LOGIN_DETAILS
	(USER_ID,LOGIN_TYPE,ENTERED_BY)
   VALUES (@USER_ID,@LOGIN_TYPE,@ENTERED_BY);
   END
--exec SP_GET_DEN_DENGI_RECEIPT_DATA  322340, 326041, NULL, '2023-01-01', '2024-02-05',NULL,3,7,39,78;
   IF @FLAG='U'
   BEGIN
   UPDATE SEC_LOGIN_DETAILS SET LOGGED_OUT_TIME=CONVERT(datetime, @LOGGED_OUT_TIME,103) WHERE 
   USER_ID=(SELECT TOP 1 USER_ID
FROM SEC_LOGIN_DETAILS
WHERE user_id = @USER_ID
ORDER BY LOGGED_IN_TIME DESC)
   END
   IF @FLAG='D'
   BEGIN
   DELETE FROM SEC_ACTIVE_LOGIN_DETAILS WHERE USER_ID=@USER_ID
   END
END 

--***************************************************************--

GO

/****** Object:  Table [dbo].[SEC_LOGIN_DETAILS]    Script Date: 02-03-2024 15:22:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--SELECT * FROM tbl_gotra_master
CREATE TABLE [dbo].[SEC_LOGIN_DETAILS](
	[LOGIN_MASTER_ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[USER_ID] [int] NULL,
	[LOGGED_IN_TIME] [datetime] NULL,
	[LOGGED_OUT_TIME] [datetime] NULL,
	[LOGIN_TYPE] [int] NULL,
	[ENTERED_BY] [varchar](50) NOT NULL,
	[ENTERED_ON] [datetime] NULL,
 CONSTRAINT [PK_SEC_LOGIN_DETAILS] PRIMARY KEY CLUSTERED 
(
	[LOGIN_MASTER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SEC_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_LOGIN_DETAILS_LOGGED_IN_TIME]  DEFAULT (getdate()) FOR [LOGGED_IN_TIME]
GO

ALTER TABLE [dbo].[SEC_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_LOGIN_DETAILS_ENTERED_ON]  DEFAULT (getdate()) FOR [ENTERED_ON]
GO
PRINT N'Creating Procedure [dbo].[InsertDengiReceipt_LOG]...';

--***********************************************

USE [OSOL23]
GO
CREATE PROCEDURE [dbo].[InsertDengiReceipt_LOG]
	@UserName varchar(300),
    @Amount numeric(18,2),
    @Serial_no bigint,
    @LastUserName varchar(300),
    @LastAmount numeric(18,2),
    @LastSerial_no bigint,
    @CreatedBy varchar(300),
    @MACId varchar(300),
	@ID NUMERIC(20,0) output

as
BEGIN
/****** Object:  Table [dbo].[SEC_ACTIVE_LOGIN_DETAILS]    Script Date: 02-03-2024 15:23:02 ******/
SET ANSI_NULLS ON
GO

    INSERT INTO [dbo].[DEN_DENGI_RECEIPT_MST__Log] ([UserName],[Amount],[Serial_no],[LastUserName],[LastAmount],[LastSerial_no],[CreatedBy],[MACId])
     VALUES(@UserName,@Amount,@Serial_no,@LastUserName,@LastAmount,@LastSerial_no,@CreatedBy,@MACId);
    set @ID = SCOPE_IDENTITY();

END
CREATE TABLE [dbo].[SEC_ACTIVE_LOGIN_DETAILS](
	[LOGIN_MASTER_ID] [int] IDENTITY(1,1) NOT NULL,
	[USER_ID] [int] NULL,
	[LOGGED_IN_TIME] [datetime] NULL,
	[LOGGED_OUT_TIME] [datetime] NULL,
	[LOGIN_TYPE] [int] NULL,
	[ENTERED_BY] [varchar](50) NULL,
	[ENTERED_ON] [datetime] NULL,
 CONSTRAINT [PK_SEC_ACTIVE_LOGIN_DETAILS] PRIMARY KEY CLUSTERED 
(
	[LOGIN_MASTER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
PRINT N'Update complete.';

ALTER TABLE [dbo].[SEC_ACTIVE_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_ACTIVE_LOGIN_DETAILS_LOGGED_IN_TIME]  DEFAULT (getdate()) FOR [LOGGED_IN_TIME]
GO

ALTER TABLE [dbo].[SEC_ACTIVE_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_ACTIVE_LOGIN_DETAILS_ENTERED_ON]  DEFAULT (getdate()) FOR [ENTERED_ON]
GO


-- Scripts by Sujata ENDS




