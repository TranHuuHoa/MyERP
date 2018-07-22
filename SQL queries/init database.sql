CREATE TABLE [dbo].[TblEmployee] (
  [Id]     INT       IDENTITY (1, 1) NOT NULL,
  [EmployeeNumber] NVARCHAR (250) NULL,
  [FirstName] NVARCHAR (250) NULL,
  [LastName]  NVARCHAR (250) NULL,
  [Sex]   INT NULL,
  [JobRankType]   INT NULL,
  [JobRankLevel]   INT NULL,
  [SalaryLevel]   INT NULL,
  [SalarySubLevel]   INT NULL,
  PRIMARY KEY CLUSTERED ([Id] ASC)
);
