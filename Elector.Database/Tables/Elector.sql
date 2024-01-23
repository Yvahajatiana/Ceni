CREATE TABLE [dbo].[Elector]
(
    [Id] INT NOT NULL PRIMARY KEY, 
    [NameSingleFormat] VARCHAR(200) NOT NULL, 
    [FirstName] VARCHAR(200) NULL, 
    [LastName] VARCHAR(200) NULL, 
    [VoterCardNumber] INT NULL, 
    [IdCardNumber] INT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Phone] VARCHAR(15) NULL, 
    [Address] VARCHAR(100) NULL, 
    [CityId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[City](Id), 
    [RegionId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Region](Id), 
    [PostalCode] VARCHAR(10) NOT NULL, 
    [DistrictId] INT NULL FOREIGN KEY REFERENCES [dbo].[District](Id)
)