CREATE TABLE [dbo].[customerdetails] (
    [userid]       INT            IDENTITY (1, 1) NOT NULL,
    [customername] NVARCHAR (100) NULL,
    [employee] NVARCHAR (500) NULL,
    [ordernumber] NVARCHAR (50)  NULL,
    [menu]         NVARCHAR (50)  NULL,
    [emailid]      NVARCHAR (50)  NULL,
    CONSTRAINT [PK_customerdetails] PRIMARY KEY CLUSTERED ([userid] ASC)
);

