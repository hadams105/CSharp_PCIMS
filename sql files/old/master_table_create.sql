USE [PCIMS]
GO

/****** Object:  Table [dbo].[cargo]    Script Date: 4/12/2018 10:13:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

--DROP TABLE [dbo].[cargo]
--GO

CREATE TABLE [dbo].[cargo](
	[Name] [nvarchar](40) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[table13]
--GO

CREATE TABLE [dbo].[table13](
	[API] [decimal](4, 1) NULL,
	[MT_BARREL] [decimal](6, 5) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[tableb1]
--GO

CREATE TABLE [dbo].[tableb1](
	[SHELLTEMP] [int] NULL,
	[CONVFACT] [decimal](6, 5) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[terminal]
--GO

CREATE TABLE [dbo].[terminal](
	[Name] [nvarchar](40) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[TimeDtl]
--GO

CREATE TABLE [dbo].[TimeDtl](
	[JobNbr] int NOT NULL,
	[LineNbr] [smallint] NULL,
	[Date] [smalldatetime] NULL,
	[Time] [nvarchar](4) NULL,
	[Event] [nvarchar](80) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[timehd]
--GO

CREATE TABLE [dbo].[timehd](
	[JobNbr] int NOT NULL,
	[ReportDate] [smalldatetime] NULL,
	[Pumprate] [nvarchar](15) NULL,
	[TermBy] [nvarchar](15) NULL,
	[Loadtime] [nvarchar](15) NULL,
	[Delay1] [nvarchar](30) NULL,
	[Delay2] [nvarchar](30) NULL,
	[Delay3] [nvarchar](30) NULL,
	[Lastcargo] [nvarchar](30) NULL,
	[2ndcargo] [nvarchar](30) NULL,
	[3rdcargo] [nvarchar](30) NULL,
	[Weather] [nvarchar](10) NULL,
	[Airtemp] [nvarchar](10) NULL,
	[Seatemp] [nvarchar](10) NULL,
	[Sea] [nvarchar](10) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[vessel]
--GO

CREATE TABLE [dbo].[vessel](
	[Name] [nvarchar](40) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[vgdetail]
--GO

CREATE TABLE [dbo].[vgdetail](
	[JobNbr] int NOT NULL,
	[BeforeAfter] [nvarchar](20) NULL,
	[Tank] [nvarchar](4) NULL,
	[Gauge] [nvarchar](11) NULL,
	[TrimGauge] [nvarchar](10) NULL,
	[ObservVol] [float] NULL,
	[FreeGauge] [nvarchar](10) NULL,
	[FreeVol] [float] NULL,
	[GrossObs] [float] NULL,
	[Temperature] [decimal](5, 1) NULL,
	[VCF] [decimal](8, 5) NULL,
	[GrossStd] [float] NULL,
	[LineNbr] [tinyint] NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[vgheader]
--GO

CREATE TABLE [dbo].[vgheader](
	[JobNbr] int NOT NULL,
	[Stage] [nvarchar](20) NULL,
	[Method] [nvarchar](1) NULL,
	[Gauge] [nvarchar](1) NULL,
	[MeasType] [nvarchar](1) NULL,
	[MeasDecs] [int] NULL,
	[VCFDecs] [int] NULL,
	[ConvFactor] [float] NULL,
	[ConvTable] [nvarchar](2) NULL,
	[ConvDecs] [int] NULL,
	[NbrTanks] [int] NULL,
	[CalcType] [nvarchar](1) NULL,
	[AvgTempBefore] [decimal](5, 1) NULL,
	[AvgTempAfter] [decimal](5, 1) NULL,
	[VCFBefore] [decimal](8, 5) NULL,
	[VCFAfter] [decimal](8, 5) NULL,
	[VCFTABLE] [nvarchar](2) NULL,
	[BeforeGRAV] [decimal](5, 1) NULL,
	[AfterGRAV] [decimal](5, 1) NULL,
	[ConvGRAV] [decimal](5, 1) NULL,
	[ULINBEFORE] [nvarchar](1) NULL,
	[ULINAFTER] [nvarchar](1) NULL,
	[BEFORE] [nvarchar](25) NULL,
	[AFTER] [nvarchar](25) NULL,
	[SEALS] [nvarchar](25) NULL,
	[FWDBEFORE] [nvarchar](6) NULL,
	[AFTBEFORE] [nvarchar](6) NULL,
	[LSTBEFORE] [nvarchar](6) NULL,
	[FWDAFTER] [nvarchar](6) NULL,
	[AFTAFTER] [nvarchar](6) NULL,
	[LSTAFTER] [nvarchar](6) NULL,
	[VEF] [decimal](13, 3) NULL,
	[GROSSBARRBefore] [decimal](13, 3) NULL,
	[GROSSMETEBefore] [decimal](13, 3) NULL,
	[GROSSGALLBefore] [decimal](13, 3) NULL,
	[GROSSLONGBefore] [decimal](13, 3) NULL,
	[GROSSMETRBefore] [decimal](13, 3) NULL,
	[GROSSSHORBefore] [decimal](13, 3) NULL,
	[GROSSPDSBefore] [decimal](13, 3) NULL,
	[NETBARRBefore] [decimal](13, 3) NULL,
	[NETMETEBefore] [decimal](13, 3) NULL,
	[NETGALLBefore] [decimal](13, 3) NULL,
	[NETLONGBefore] [decimal](13, 3) NULL,
	[NETMETRBefore] [decimal](13, 3) NULL,
	[NETSHORBefore] [decimal](13, 3) NULL,
	[NETPDSBefore] [decimal](13, 3) NULL,
	[GROSSBARRAfter] [decimal](13, 3) NULL,
	[GROSSMETEAfter] [decimal](13, 3) NULL,
	[GROSSGALLAfter] [decimal](13, 3) NULL,
	[GROSSLONGAfter] [decimal](13, 3) NULL,
	[GROSSMETRAfter] [decimal](13, 3) NULL,
	[GROSSSHORAfter] [decimal](13, 3) NULL,
	[GROSSPDSAfter] [decimal](13, 3) NULL,
	[NETBARRAfter] [decimal](13, 3) NULL,
	[NETMETEAfter] [decimal](13, 3) NULL,
	[NETGALLAfter] [decimal](13, 3) NULL,
	[NETLONGAfter] [decimal](13, 3) NULL,
	[NETMETRAfter] [decimal](13, 3) NULL,
	[NETSHORAfter] [decimal](13, 3) NULL,
	[NETPDSAfter] [decimal](13, 3) NULL,
	[GROSSBARR] [decimal](13, 3) NULL,
	[GROSSMETE] [decimal](13, 3) NULL,
	[GROSSGALL] [decimal](13, 3) NULL,
	[GROSSLONG] [decimal](13, 3) NULL,
	[GROSSMETR] [decimal](13, 3) NULL,
	[GROSSSHOR] [decimal](13, 3) NULL,
	[GROSSPDS] [decimal](13, 3) NULL,
	[NETBARR] [decimal](13, 3) NULL,
	[NETMETE] [decimal](13, 3) NULL,
	[NETGALL] [decimal](13, 3) NULL,
	[NETLONG] [decimal](13, 3) NULL,
	[NETMETR] [decimal](13, 3) NULL,
	[NETSHOR] [decimal](13, 3) NULL,
	[NETPDS] [decimal](13, 3) NULL,
	[SWP] [decimal](13, 3) NULL,
	[SWV] [decimal](13, 3) NULL,
	[CALCVOL] [decimal](13, 3) NULL,
	[OBQLOT] [decimal](18, 0) NULL,
	[CPT] [nvarchar](20) NULL,
	[NOTE] [nvarchar](80) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[control]
--GO

CREATE TABLE [dbo].[control](
	[STATION] [nvarchar](2) NULL,
	[LASTJOB] [int] NULL,
	[LASTINV] [int] NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[Customers]
--GO

CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[ContactFirstName] [nvarchar](30) NULL,
	[ContactLastName] [nvarchar](50) NULL,
	[CompanyOrDepartment] [nvarchar](35) NULL,
	[SortOrder] [nvarchar](35) NOT NULL,
	[BillingAddress] [nvarchar](255) NULL,
	[BillingAddress2] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[StateOrProvince] [nvarchar](20) NULL,
	[PostalCode] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[ContactTitle] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](30) NULL,
	[Extension] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](30) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[Notes] [ntext] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--DROP TABLE [dbo].[inspector]
--GO

CREATE TABLE [dbo].[inspector](
	[EMPID] [nvarchar](5) NULL,
	[LNAME] [nvarchar](30) NULL,
	[FNAME] [nvarchar](20) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[InventoryDetail]
--GO

CREATE TABLE [dbo].[InventoryDetail](
	[DtlNbr] [int] IDENTITY(1,1) NOT NULL,
	[JobNbr] int NOT NULL,
	[CalcType] [nvarchar](1) NULL,
	[VCFTABLE] [nvarchar](2) NULL,
	[BeforeGRAV] [decimal](18, 0) NULL,
	[AfterGRAV] [decimal](18, 0) NULL,
	[ConvGRAV] [decimal](18, 0) NULL,
	[GROSS_TOT] [float] NULL,
	[GROSS_BARR] [float] NULL,
	[GROSS_METE] [float] NULL,
	[GROSS_GALL] [float] NULL,
	[GROSS_LONG] [float] NULL,
	[GROSS_METR] [float] NULL,
	[GROSS_SHOR] [float] NULL,
	[GROSS_PDS] [float] NULL,
	[NET_TOT] [float] NULL,
	[NET_BARR] [float] NULL,
	[NET_METE] [float] NULL,
	[NET_GALL] [float] NULL,
	[NET_LONG] [float] NULL,
	[NET_METR] [float] NULL,
	[NET_SHOR] [float] NULL,
	[NET_PDS] [float] NULL,
	[FWG] [nvarchar](15) NULL,
	[NOTE] [nvarchar](250) NULL,
	[WT_VOL] [nvarchar](1) NULL,
	[TOT_CONV] [nvarchar](1) NULL,
	[APPLY_ROOF] [nvarchar](1) NULL,
	[TankName] [nvarchar](68) NULL,
	[T1A] [nvarchar](5) NULL,
	[G1A] [nvarchar](11) NULL,
	[NSV1A] [float] NULL,
	[TOV1A] [float] NULL,
	[WG1A] [nvarchar](10) NULL,
	[WV1A] [decimal](18, 0) NULL,
	[CTSH1A] [decimal](18, 0) NULL,
	[RC1A] [float] NULL,
	[GOV1A] [float] NULL,
	[TP1A] [decimal](18, 0) NULL,
	[API1A] [decimal](18, 0) NULL,
	[VCF1A] [decimal](18, 0) NULL,
	[TRUCK1_DE] [nvarchar](45) NULL,
	[TRUCK1_GR] [float] NULL,
	[TRUCK1_TP] [decimal](18, 0) NULL,
	[TRUCK1_API] [decimal](18, 0) NULL,
	[TRUCK1_VCF] [decimal](18, 0) NULL,
	[TRUCK1_NSV] [float] NULL,
	[TRUCK2_DE] [nvarchar](45) NULL,
	[TRUCK2_GR] [float] NULL,
	[TRUCK2_TP] [decimal](18, 0) NULL,
	[TRUCK2_API] [decimal](18, 0) NULL,
	[TRUCK2_VCF] [decimal](18, 0) NULL,
	[TRUCK2_NSV] [float] NULL,
	[TRUCK3_DE] [nvarchar](45) NULL,
	[TRUCK3_GR] [float] NULL,
	[TRUCK3_TP] [decimal](18, 0) NULL,
	[TRUCK3_API] [decimal](18, 0) NULL,
	[TRUCK3_VCF] [decimal](18, 0) NULL,
	[TRUCK3_NSV] [float] NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[InventoryHeader]
--GO

CREATE TABLE [dbo].[InventoryHeader](
	[JobNbr] int NOT NULL,
	[Gauge] [nvarchar](10) NULL,
	[MeasType] [nvarchar](15) NULL,
	[MeasDecs] [decimal](18, 0) NULL,
	[VCFTable] [nvarchar](2) NULL,
	[ConvTable] [nvarchar](2) NULL,
	[ConvDecs] [decimal](18, 0) NULL,
	[Notes] [nvarchar](250) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[InvoiceDetail]
--GO

CREATE TABLE [dbo].[InvoiceDetail](
	[DtlNbr] [int] IDENTITY(1,1) NOT NULL,
	[JobNbr] [int] NOT NULL,
	[ServiceCode] [nvarchar](4) NULL,
	[ServiceDesc] [nvarchar](50) NULL,
	[Quantity] [float] NULL,
	[Unit] [nvarchar](6) NULL,
	[UnitPrice] [float] NULL,
	[Amount] [money] NULL,
	[LineSplit] [float] NULL,
	[LineDisc] [float] NULL,
	[LineTotal] [money] NULL,
	[LineNbr] [int] NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[InvoiceHeader]
--GO

CREATE TABLE [dbo].[InvoiceHeader](
	[InvNbr] [int] NOT NULL,
	[JobNbr] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[InvDate] [nvarchar](10) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[BillingAddress] [nvarchar](255) NULL,
	[BillingAddress2] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[StateOrProvince] [nvarchar](20) NULL,
	[PostalCode] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[CustRefNbr] [nvarchar](30) NULL,
	[JobDate] [nvarchar](10) NULL,
	[JobDesc] [nvarchar](50) NULL,
	[PctDiscount] [decimal](6, 2) NULL,
	[Split] [decimal](6, 2) NULL,
	[Notes] [ntext] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

DROP TABLE [dbo].[jobs]
GO

CREATE TABLE [dbo].[jobs](
	[JobNbr] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] int NOT NULL,
	[OrderDateTime] [nvarchar](25) NULL,
	[OrderBy] [nvarchar](25) NULL,
	[TakenBy] [nvarchar](25) NULL,
	[Vessel] [nvarchar](40) NULL,
	[VesselType] [nvarchar](10) NULL,
	[Cargo] [nvarchar](40) NULL,
	[Terminal] [nvarchar](40) NULL,
	[Location] [nvarchar](40) NULL,
	[InspectionDate] [nvarchar](25) NULL,
	[JobType] int NULL,
	[Eta] [nvarchar](25) NULL,
	[CargoQty] [int] NULL,
	[Inspector] [nvarchar](50) NULL,
	[Splits] [smallint] NULL,
	[Reports] [nvarchar](15) NULL,
	[Completed] [nvarchar](10) NULL,
	[Dist1] [nvarchar](250) NULL,
	[Dist2] [nvarchar](250) NULL,
	[Subs] [tinyint] NULL,
	[LD] [nvarchar](9) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[labdetail]
--GO 

CREATE TABLE [dbo].[labdetail](
	[DtlNbr] [int] IDENTITY(1,1) NOT NULL,
	[JobNbr] [int] NOT NULL,
	[SheetNbr] [smallint] NULL,
	[LineNbr] [smallint] NULL,
	[Marked] [nvarchar](60) NULL,
	[Re] [nvarchar](6) NULL,
	[TemplateId] [int] NULL,
	[TestId] [int] NULL,
	[Test] [nvarchar](80) NULL,
	[Astm] [nvarchar](32) NULL,
	[CompBy] [nvarchar](6) NULL,
	[ReleaseId] [nvarchar](6) NULL,
	[Spec] [nvarchar](60) NULL,
	[Fee] [decimal](18, 0) NULL,
	[Result] [nvarchar](20) NULL,
	[Note] [nvarchar](140) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[labheader]
--GO

CREATE TABLE [dbo].[labheader](
	[JobNbr] int NOT NULL,
	[SheetNbr] [smallint] NULL,
	[SheetDesc] [nvarchar](30) NULL,
	[Product] [nvarchar](20) NULL,
	[Marked] [nvarchar](20) NULL,
	[WhoFrom] [nvarchar](30) NULL,
	[WhoFor] [nvarchar](30) NULL,
	[CustCode] [nvarchar](8) NULL,
	[LabNbr] [nvarchar](10) NULL,
	[LabDate] [smalldatetime] NULL,
	[TotalTest] [int] NULL,
	[TotalCharge] [decimal](18, 0) NULL,
	[Ot] [decimal](18, 0) NULL,
	[Tests] [nvarchar](126) NULL,
	[Template] [int] NULL,
	[Okayed] [nvarchar](3) NULL,
	[Disposal] [decimal](18, 0) NULL,
	[SampleDate] [smalldatetime] NULL,
	[Spec] [nvarchar](10) NULL,
	[Notes1] [nvarchar](200) NULL,
	[Notes2] [nvarchar](200) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[labrpthdr]
--GO

CREATE TABLE [dbo].[labrpthdr](
	[JobNbr] int NOT NULL,
	[LabNbr] [nvarchar](15) NULL,
	[ReportDate] [smalldatetime] NULL,
	[Sample1] [nvarchar](25) NULL,
	[Sample2] [nvarchar](25) NULL,
	[IdMarks1] [nvarchar](25) NULL,
	[IdMarks2] [nvarchar](25) NULL,
	[IdMarks3] [nvarchar](25) NULL,
	[IdMarks4] [nvarchar](25) NULL,
	[Submitted1] [nvarchar](25) NULL,
	[Submitted2] [nvarchar](25) NULL,
	[Client1] int NULL,
	[Client2] int NULL,
	[Client3] int NULL,
	[Client4] int NULL,
	[Header1] [nvarchar](25) NULL,
	[Header2] [nvarchar](25) NULL,
	[Foot1] [nvarchar](50) NULL,
	[Foot2] [nvarchar](50) NULL,
	[Foot3] [nvarchar](50) NULL,
	[RetDays] [int] NULL,
	[Notes] [nvarchar](250) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[labrptdtl]
--GO

CREATE TABLE [dbo].[labrptdtl](
	[JobNbr] [int] IDENTITY(1,1) NOT NULL,
	[LineNbr] [smallint] NULL,
	[Result] [nvarchar](10) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[labspecs]
--GO

CREATE TABLE [dbo].[labspecs](
	[TestId] [int] IDENTITY(1,1) NOT NULL,
	[JobNbr] [int] NOT NULL,
	[Test] [nvarchar](40) NULL,
	[Specname] [nvarchar](10) NULL,
	[Spec] [nvarchar](30) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[location]
--GO

CREATE TABLE [dbo].[location](
	[Name] [nvarchar](40) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[rptdist]
--GO

CREATE TABLE [dbo].[rptdist](
	[JobNbr] int NOT NULL,
	[Notes] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--DROP TABLE [dbo].[specinstr]
--GO

CREATE TABLE [dbo].[specinstr](
	[JobNbr] int NOT NULL,
	[Notes] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--DROP TABLE [dbo].[splits]
--GO

CREATE TABLE [dbo].[splits](
	[SplitID] [int] IDENTITY(1,1) NOT NULL,
	[JobNbr] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CustOrdNbr] [nvarchar](30) NULL,
	[Split] [decimal](6, 3) NULL,
	[SplitLetter] [nvarchar](2) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[stdetail]
--GO

CREATE TABLE [dbo].[stdetail](
	[JobNbr] int NOT NULL,
	[TabNbr] [tinyint] NULL,
	[Tn1] [nvarchar](68) NULL,
	[Product] [nvarchar](30) NULL,
	[T1A] [nvarchar](5) NULL,
	[T1B] [nvarchar](5) NULL,
	[G1A] [nvarchar](11) NULL,
	[G1B] [nvarchar](11) NULL,
	[TOV1A] [decimal](13, 3) NULL,
	[TOV1B] [decimal](13, 3) NULL,
	[WG1A] [nvarchar](10) NULL,
	[WG1B] [nvarchar](10) NULL,
	[WV1A] [decimal](13, 3) NULL,
	[WV1B] [decimal](13, 3) NULL,
	[CTSH1A] [decimal](6, 5) NULL,
	[CTSH1B] [decimal](6, 5) NULL,
	[RC1A] [decimal](13, 3) NULL,
	[RC1B] [decimal](13, 3) NULL,
	[GOV1A] [decimal](13, 3) NULL,
	[GOV1B] [decimal](13, 3) NULL,
	[TP1A] [decimal](5, 1) NULL,
	[TP1B] [decimal](5, 1) NULL,
	[API1A] [decimal](5, 1) NULL,
	[API1B] [decimal](5, 1) NULL,
	[VCF1A] [decimal](6, 5) NULL,
	[VCF1B] [decimal](6, 5) NULL,
	[GSV1A] [decimal](13, 3) NULL,
	[GSV1B] [decimal](13, 3) NULL,
	[PCT_SWA] [decimal](13, 3) NULL,
	[PCT_SWB] [decimal](13, 3) NULL,
	[PCT_SWT] [decimal](13, 3) NULL,
	[VOL_SWA] [decimal](13, 3) NULL,
	[VOL_SWB] [decimal](13, 3) NULL,
	[VOL_SWT] [decimal](13, 3) NULL,
	[TRUCK1_DE] [nvarchar](45) NULL,
	[TRUCK1_GR] [decimal](13, 3) NULL,
	[TRUCK1_TP] [decimal](5, 1) NULL,
	[TRUCK1_API] [decimal](5, 1) NULL,
	[TRUCK1_VCF] [decimal](6, 5) NULL,
	[TRUCK1_NSV] [decimal](13, 3) NULL,
	[TRUCK2_DE] [nvarchar](45) NULL,
	[TRUCK2_GR] [decimal](13, 3) NULL,
	[TRUCK2_TP] [decimal](5, 1) NULL,
	[TRUCK2_API] [decimal](5, 1) NULL,
	[TRUCK2_VCF] [decimal](6, 5) NULL,
	[TRUCK2_NSV] [decimal](13, 3) NULL,
	[TRUCK3_DE] [nvarchar](45) NULL,
	[TRUCK3_GR] [decimal](13, 3) NULL,
	[TRUCK3_TP] [decimal](5, 1) NULL,
	[TRUCK3_API] [decimal](5, 1) NULL,
	[TRUCK3_VCF] [decimal](6, 5) NULL,
	[TRUCK3_NSV] [decimal](13, 3) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[stheader]
--GO

CREATE TABLE [dbo].[stheader](
	[JobNbr] int NOT NULL,
	[Method] [nvarchar](1) NULL,
	[Gauge] [nvarchar](1) NULL,
	[MeasType] [nvarchar](1) NULL,
	[MeasDecs] [int] NULL,
	[VCFDecs] [int] NULL,
	[ConvFactor] [float] NULL,
	[ConvTable] [nvarchar](2) NULL,
	[ConvDecs] [int] NULL,
	[NbrTanks] [int] NULL,
	[CalcType] [nvarchar](1) NULL,
	[VCFTABLE] [nvarchar](2) NULL,
	[BeforeGRAV] [decimal](5, 1) NULL,
	[AfterGRAV] [decimal](5, 1) NULL,
	[ConvGRAV] [decimal](5, 1) NULL,
	[ADD_DE] [nvarchar](25) NULL,
	[ADD_GR] [decimal](13, 3) NULL,
	[ADD_TP] [decimal](5, 1) NULL,
	[ADD_API] [decimal](5, 1) NULL,
	[ADD_VCF] [decimal](6, 5) NULL,
	[ADD_NSV] [decimal](13, 3) NULL,
	[GROSS_TOT] [decimal](13, 3) NULL,
	[GROSS_BARR] [decimal](13, 3) NULL,
	[GROSS_METE] [decimal](13, 3) NULL,
	[GROSS_GALL] [decimal](13, 3) NULL,
	[GROSS_LONG] [decimal](13, 3) NULL,
	[GROSS_METR] [decimal](13, 3) NULL,
	[GROSS_SHOR] [decimal](13, 3) NULL,
	[GROSS_PDS] [decimal](13, 3) NULL,
	[NET_TOT] [decimal](13, 3) NULL,
	[NET_BARR] [decimal](13, 3) NULL,
	[NET_METE] [decimal](13, 3) NULL,
	[NET_GALL] [decimal](13, 3) NULL,
	[NET_LONG] [decimal](13, 3) NULL,
	[NET_METR] [decimal](13, 3) NULL,
	[NET_SHOR] [decimal](13, 3) NULL,
	[NET_PDS] [decimal](13, 3) NULL,
	[SH1] [nvarchar](5) NULL,
	[SH2] [nvarchar](5) NULL,
	[SH3] [decimal](18, 0) NULL,
	[FWG] [nvarchar](15) NULL,
	[NOTE] [nvarchar](80) NULL,
	[WT_VOL] [nvarchar](1) NULL,
	[TOT_CONV] [nvarchar](1) NULL,
	[PCT_SW_TOT] [decimal](5, 1) NULL,
	[VOL_SW_TOT] [decimal](13, 3) NULL,
	[BEFORE_SW] [nvarchar](1) NULL,
	[APPLY_ROOF] [nvarchar](1) NULL,
	[FREEWATER] [tinyint] NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[table8]
--GO

CREATE TABLE [dbo].[table8](
	[API] [decimal](4, 1) NULL,
	[PDS] [decimal](6, 5) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[table11]
--GO

CREATE TABLE [dbo].[table11](
	[API] [decimal](4, 1) NULL,
	[LT_BARREL] [decimal](6, 5) NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[labtemplates]
--GO

CREATE TABLE [dbo].[labtemplates](
	[TemplateID] [int] IDENTITY(1,1) NOT NULL,
	[TemplateName] [nvarchar](30) NULL,
	[Re] [nvarchar](3) NULL
) ON [PRIMARY]

GO

--DROP TABLE [dbo].[labtemplatefees]
--GO

CREATE TABLE [dbo].[labtemplatefees](
	[TemplateId] [int] NOT NULL,
	[TestId] [int] NOT NULL 
) ON [PRIMARY]

GO

--DROP TABLE [dbo].[jobtypes]
--GO

CREATE TABLE [dbo].[jobtypes](
	[JobTypeID] int  NOT NULL,
	[JobTypeDesc] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO

--DROP TABLE [dbo].[prices]
--GO

CREATE TABLE [dbo].[prices](		
	[ServiceCode] [nvarchar](4) NOT NULL,
	[ServiceDesc] [nvarchar](50) NOT NULL,
	[Amount] [float] NOT NULL,
	[MinCharge] [float] NOT NULL
) ON [PRIMARY]

GO

--DROP TABLE [dbo].[labfees]
--GO

CREATE TABLE [dbo].[labfees](
	[TestId] int IDENTITY(1,1) NOT NULL,
	[TestDesc] [nvarchar](250) NOT NULL,
	[Fee] decimal NOT NULL,
	[ASTM] char(16) NOT NULL
) ON [PRIMARY]

GO

--DROP TABLE [dbo].[jobtemplates]
--GO

CREATE TABLE [dbo].[jobtemplates](
	[DtlNbr] int IDENTITY(1,1) NOT NULL,
	[TemplateId] int NOT NULL,
	[JobNbr] int NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
