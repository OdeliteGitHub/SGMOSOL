-- Scripts by Sujata STARTS

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
AS
BEGIN
    IF @FLAG='I'
    INSERT INTO SEC_LOGIN_DETAILS
	(USER_ID,LOGIN_TYPE,ENTERED_BY)
   VALUES (@USER_ID,@LOGIN_TYPE,@ENTERED_BY);
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
  
 

--***************************************************************--


/****** Object:  Table [dbo].[SEC_LOGIN_DETAILS]    Script Date: 02-03-2024 15:22:11 ******/
GO
ALTER TABLE [dbo].[SEC_LOGIN_DETAILS] DROP  CONSTRAINT [DF_SEC_LOGIN_DETAILS_LOGGED_IN_TIME] 
ALTER TABLE [dbo].[SEC_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_LOGIN_DETAILS_LOGGED_IN_TIME]  DEFAULT (getdate()) FOR [LOGGED_IN_TIME]
GO
ALTER TABLE [dbo].[SEC_LOGIN_DETAILS] DROP  CONSTRAINT [DF_SEC_LOGIN_DETAILS_ENTERED_ON]
ALTER TABLE [dbo].[SEC_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_LOGIN_DETAILS_ENTERED_ON]  DEFAULT (getdate()) FOR [ENTERED_ON]


--***********************************************

GO
PRINT N'Creating Procedure [dbo].[InsertDengiReceipt_LOG]...';
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


    INSERT INTO [dbo].[DEN_DENGI_RECEIPT_MST__Log] ([UserName],[Amount],[Serial_no],[LastUserName],[LastAmount],[LastSerial_no],[CreatedBy],[MACId])
     VALUES(@UserName,@Amount,@Serial_no,@LastUserName,@LastAmount,@LastSerial_no,@CreatedBy,@MACId);
    set @ID = SCOPE_IDENTITY();

END
GO

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


ALTER TABLE [dbo].[SEC_ACTIVE_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_ACTIVE_LOGIN_DETAILS_LOGGED_IN_TIME]  DEFAULT (getdate()) FOR [LOGGED_IN_TIME]
GO

ALTER TABLE [dbo].[SEC_ACTIVE_LOGIN_DETAILS] ADD  CONSTRAINT [DF_SEC_ACTIVE_LOGIN_DETAILS_ENTERED_ON]  DEFAULT (getdate()) FOR [ENTERED_ON]
GO


-- Scripts by Sujata ENDS



GO
/****** Object:  StoredProcedure [dbo].[SP_DML_MESS_PRINT_RECEIPT_DET]    Script Date: 09-03-2024 14:06:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_DML_MESS_PRINT_RECEIPT_DET]
(
@PRINT_RECEIPT_MST_ID INT,
@ITEM_ID INT,
@PRICE INT,
@QTY INT,
@AMOUNT DECIMAL,
@PR_DATE DATETIME,
@DEPT_ID INT,
@GUEST1 BIT,
@PRINT_RECEIPT_ID_DET INT OUTPUT

)
AS
BEGIN
DECLARE @PRINT_RECEIPT_ITEM_ID NUMERIC(10,0)
DECLARE @SERIAL_NO NUMERIC(10,0)
DECLARE @PRINT_RECEIPT_VALUE NUMERIC(10,0)
 DECLARE @incrementValue INT  
  SET @incrementValue = ISNULL(@incrementValue, 0) + 1;
SELECT @SERIAL_NO=SERIAL_NO FROM  MESS_PRINT_RECEIPT_MST_T WHERE PRINT_RECEIPT_MST_ID=@PRINT_RECEIPT_MST_ID

PRINT @SERIAL_NO

IF EXISTS(SELECT ITEM_PRINT_RECEIPT_ID FROM MESS_PRINT_RECEIPT_DET_T WHERE PRINT_RECEIPT_MST_ID=@PRINT_RECEIPT_MST_ID)
BEGIN
SELECT @PRINT_RECEIPT_VALUE= ITEM_PRINT_RECEIPT_ID FROM MESS_PRINT_RECEIPT_DET_T WHERE PRINT_RECEIPT_MST_ID=@PRINT_RECEIPT_MST_ID
SELECT @PRINT_RECEIPT_ITEM_ID=CAST(@PRINT_RECEIPT_VALUE AS INT)+1
END
ELSE
BEGIN
SELECT @PRINT_RECEIPT_ITEM_ID=
        CAST(@SERIAL_NO AS NVARCHAR(50)) + '000' + CAST(@incrementValue AS NVARCHAR(50));
		END


INSERT INTO MESS_PRINT_RECEIPT_DET_T(PRINT_RECEIPT_MST_ID,ITEM_ID,PRICE,QTY,AMOUNT,PR_DATE1,DEPT_ID1,GUEST1,ITEM_PRINT_RECEIPT_ID)
VALUES(@PRINT_RECEIPT_MST_ID,@ITEM_ID,@PRICE,@QTY,@AMOUNT,CONVERT(datetime, @PR_DATE,103),@DEPT_ID,@GUEST1,@PRINT_RECEIPT_ITEM_ID)
SET @PRINT_RECEIPT_ID_DET=SCOPE_IDENTITY()
END



--****************************************************************

GO
/****** Object:  StoredProcedure [dbo].[SP_DML_MESS_PRINT_RECEIPT_MST]    Script Date: 09-03-2024 14:15:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_DML_MESS_PRINT_RECEIPT_MST]
(
	@FLAG CHAR(1) = NULL,
	@PRINT_MST_ID NUMERIC (9,0) =NULL,
	@PR_DATE varchar(50) = null,
	@COM_ID INT =NULL,
	@LOC_ID INT =NULL,
	@DEPT_ID INT =NULL,
	@FY_ID INT =NULL,
	@USER_ID INT =NULL,
	@CTR_MACH_ID INT =NULL,
	@GUEST BIT,
	@AMOUNT NUMERIC(12,2)=NULL,
	@CASH NUMERIC(12,2)=NULL,
	@CHANGE NUMERIC(12,2)=NULL,
	@REMARKS VARCHAR(100) =NULL,
	@ENTERED_BY VARCHAR(50) =NULL,
	@MODIFIED_BY VARCHAR(50) =NULL,
	@MACHINE_NAME VARCHAR(30) =NULL,
	@SERVER_NAME VARCHAR(100) =NULL,
	@ITEM_NAME VARCHAR(5000) =NULL,	
	@NAME VARCHAR(50)=NULL,
	@ADDRESS VARCHAR(500)=NULL,
	@MOBILE NUMERIC(20,0)=NULL,
	@TALUKA VARCHAR(50)=NULL,
	@DOC_TYPE VARCHAR(50)=NULL,
	@DOC_DETAIL VARCHAR(50)=NULL,
	@SUCCEED numeric(9,0) OUTPUT
	
)
AS
BEGIN
IF @FLAG = 'I'
	BEGIN
		DECLARE @SERIAL_NO NUMERIC(10,0)
		IF EXISTS(SELECT  * FROM MESS_PRINT_RECEIPT_MST_T 
		WHERE FY_ID = @FY_ID and COM_ID=@COM_ID and LOC_ID=@LOC_ID AND DEPT_ID=@DEPT_ID)--AND  PRINT_RECEIPT_MST_ID <> @@IDENTITY)
			BEGIN
				SELECT @SERIAL_NO = MAX(ISNULL(SERIAL_NO,0))+1 
				FROM MESS_PRINT_RECEIPT_MST_T WHERE  FY_ID = @FY_ID and COM_ID=@COM_ID AND LOC_ID=@LOC_ID AND DEPT_ID=@DEPT_ID
			END
			ELSE		
			BEGIN
				SET @SERIAL_NO = 1
			END
			
		INSERT INTO MESS_PRINT_RECEIPT_MST_T
            (
				PR_DATE,
				SERIAL_NO,
				COM_ID,
				LOC_ID,
				DEPT_ID,
				FY_ID,
				USER_ID,
				CTR_MACH_ID,
				GUEST,
				AMOUNT,
				CASH,
				CHANGE,
				REMARKS,
				ENTERED_BY,
				MODIFIED_BY,
				MACHINE_NAME,
				SERVER_NAME,
				ITEM_NAME,
				NAME,
				ADDRESS,
				MOBILE,
				TALUKA,
				DOC_TYPE,
				DOC_DETAIL
            )
		VALUES
			(
				
			CONVERT(DATETIME,@PR_DATE,103),
				@SERIAL_NO,
				@COM_ID,
				@LOC_ID,
				@DEPT_ID,
				@FY_ID,
				@USER_ID,
				@CTR_MACH_ID,
				@GUEST,
				@AMOUNT,
				@CASH,
				@CHANGE,
				@REMARKS,
				@ENTERED_BY,
				@MODIFIED_BY,
				@MACHINE_NAME,
				@SERVER_NAME,
				@ITEM_NAME,
				@NAME,
				@ADDRESS,
				@MOBILE,
				@TALUKA,
				@DOC_TYPE,
				@DOC_DETAIL
		)
		 set @SUCCEED= SCOPE_IDENTITY();
		
	END


	ELSE
	BEGIN
	IF @FLAG = 'U'
		BEGIN
		UPDATE MESS_PRINT_RECEIPT_MST_T
             SET 
             Guest=@GUEST,
             Amount=@AMOUNT,
             Cash=@CASH,
             Change=@CHANGE,
             Remarks=@REMARKS,
             Modified_By=@MODIFIED_BY,
             Modified_On=getDate(),
             Machine_Name=@MACHINE_NAME,
             Record_Modified_Count=Record_Modified_Count + 1            
             WHERE 
            PRINT_RECEIPT_MST_ID = @PRINT_MST_ID
    
		END	
		
	END		

END

--*****************************************************


GO

/****** Object:  View [dbo].[MESS_ITEM_RECEIPT_DATA_V]    Script Date: 09-03-2024 14:19:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER VIEW [dbo].[MESS_ITEM_RECEIPT_DATA_V]
AS
SELECT
CMT.DEPT_ID,  LMT.Location_Id, ISNULL(CMT.COUNTER_MACHINE_TITLE, '') AS COUNTER, 
                       ISNULL(LMT.Location_Name, '') AS Location_Name,
					   MST.SERIAL_NO, DET.ITEM_PRINT_RECEIPT_ID,
					   

U.User_Login_Name,MST.User_Id, MST.PR_DATE, MST.Name,MST.Address,MST.TALUKA,MST.AMOUNT AS TOTAL_AMOUNT,MST.CTR_MACH_ID,MST.DOC_TYPE,MST.DOC_DETAIL,MST.MOBILE,DET.ITEM_ID,I.ITEM_TITLE,MST.PRINT_RECEIPT_MST_ID
,DET.PRICE, DET.QTY,DET.AMOUNT,
convert(varchar,MST.PR_DATE,103) as DATE
FROM MESS_PRINT_RECEIPT_MST_T MST
INNER JOIN MESS_PRINT_RECEIPT_DET_T DET
ON MST.PRINT_RECEIPT_MST_ID=DET.PRINT_RECEIPT_MST_ID
LEFT JOIN BK_MESS_ITEM_MST_T_BK I
ON DET.ITEM_ID=I.ITEM_ID
LEFT JOIN sec_user_mst_t U ON MST.User_Id=U.User_Id
inner join COM_COUNTER_MACHINE_MST_T CMT ON MST.CTR_MACH_ID = CMT.CTR_MACH_ID 
inner join  dbo.COM_LOCATION_MST_T AS LMT ON CMT.LOC_ID = LMT.Location_Id where MST.User_Id=20





GO








