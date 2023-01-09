IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF SCHEMA_ID(N'Country') IS NULL EXEC(N'CREATE SCHEMA [Country];');
GO

IF SCHEMA_ID(N'Director') IS NULL EXEC(N'CREATE SCHEMA [Director];');
GO

IF SCHEMA_ID(N'Genre') IS NULL EXEC(N'CREATE SCHEMA [Genre];');
GO

IF SCHEMA_ID(N'Movie') IS NULL EXEC(N'CREATE SCHEMA [Movie];');
GO

CREATE TABLE [Country].[tblCountries] (
    [Id] int NOT NULL IDENTITY,
    [Name] varchar(100) NOT NULL,
    CONSTRAINT [PK_tblCountries] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Director].[tblDirectors] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] varchar(25) NOT NULL,
    [LastName] varchar(25) NOT NULL,
    [DateOfBirth] date NOT NULL,
    [Nationality] varchar(25) NOT NULL,
    [IsActive] varchar(25) NOT NULL,
    [PicturePath] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_tblDirectors] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Genre].[tblGenres] (
    [Id] int NOT NULL IDENTITY,
    [Name] varchar(25) NOT NULL,
    CONSTRAINT [PK_tblGenres] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Movie].[tblMovies] (
    [Id] int NOT NULL IDENTITY,
    [Title] varchar(50) NOT NULL,
    [ReleaseDate] date NOT NULL,
    [DirectorId] int NOT NULL,
    [CountryId] int NOT NULL,
    [GenreId] int NOT NULL,
    CONSTRAINT [PK_tblMovies] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_tblMovies_tblCountries_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Country].[tblCountries] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_tblMovies_tblDirectors_DirectorId] FOREIGN KEY ([DirectorId]) REFERENCES [Director].[tblDirectors] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_tblMovies_tblGenres_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [Genre].[tblGenres] ([Id]) ON DELETE NO ACTION
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] ON;
INSERT INTO [Country].[tblCountries] ([Id], [Name])
VALUES (1, 'Afghanistan'),
(2, 'Albania'),
(3, 'Algeria'),
(4, 'Andorra'),
(5, 'Angola'),
(6, 'Antigua and Barbuda'),
(7, 'Argentina'),
(8, 'Armenia'),
(9, 'Australia'),
(10, 'Austria'),
(11, 'Azerbaijan'),
(12, 'Bahamas'),
(13, 'Bahrain'),
(14, 'Bangladesh'),
(15, 'Barbados'),
(16, 'Belarus'),
(17, 'Belgium'),
(18, 'Belize'),
(19, 'Benin'),
(20, 'Bhutan'),
(21, 'Bolivia'),
(22, 'Bosnia and Herzegovina'),
(23, 'Botswana'),
(24, 'Brazil'),
(25, 'Brunei'),
(26, 'Bulgaria'),
(27, 'Burkina Faso'),
(28, 'Burundi'),
(29, 'Côte d''Ivoire'),
(30, 'Cabo Verde'),
(31, 'Cambodia'),
(32, 'Cameroon'),
(33, 'Canada'),
(34, 'Central African Republic'),
(35, 'Chad'),
(36, 'Chile'),
(37, 'China'),
(38, 'Colombia'),
(39, 'Comoros'),
(40, 'Congo (Congo-Brazzaville)'),
(41, 'Costa Rica'),
(42, 'Croatia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] ON;
INSERT INTO [Country].[tblCountries] ([Id], [Name])
VALUES (43, 'Cuba'),
(44, 'Cyprus'),
(45, 'Czechia (Czech Republic)'),
(46, 'Democratic Republic of the Congo'),
(47, 'Denmark'),
(48, 'Djibouti'),
(49, 'Dominica'),
(50, 'Dominican Republic'),
(51, 'Ecuador'),
(52, 'Egypt'),
(53, 'El Salvador'),
(54, 'Equatorial Guinea'),
(55, 'Eritrea'),
(56, 'Estonia'),
(57, 'Eswatini (fmr. "Swaziland")'),
(58, 'Ethiopia'),
(59, 'Fiji'),
(60, 'Finland	'),
(61, 'France'),
(62, 'Gabon'),
(63, 'Gambia'),
(64, 'Georgia'),
(65, 'Germany'),
(66, 'Ghana'),
(67, 'Greece'),
(68, 'Grenada'),
(69, 'Guatemala'),
(70, 'Guinea'),
(71, 'Guinea-Bissau'),
(72, 'Guyana'),
(73, 'Haiti'),
(74, 'Holy See'),
(75, 'Honduras'),
(76, 'Hungary'),
(77, 'Iceland'),
(78, 'India'),
(79, 'Indonesia'),
(80, 'Iran'),
(81, 'Iraq'),
(82, 'Ireland'),
(83, 'Israel'),
(84, 'Italy');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] ON;
INSERT INTO [Country].[tblCountries] ([Id], [Name])
VALUES (85, 'Jamaica'),
(86, 'Japan'),
(87, 'Jordan'),
(88, 'Kazakhstan'),
(89, 'Kenya'),
(90, 'Kiribati'),
(91, 'Kuwait'),
(92, 'Kyrgyzstan'),
(93, 'Laos'),
(94, 'Latvia'),
(95, 'Lebanon'),
(96, 'Lesotho'),
(97, 'Liberia'),
(98, 'Libya'),
(99, 'Liechtenstein'),
(100, 'Lithuania'),
(101, 'Luxembourg'),
(102, 'Madagascar'),
(103, 'Malawi'),
(104, 'Malaysia'),
(105, 'Maldives'),
(106, 'Mali'),
(107, 'Malta'),
(108, 'Marshall Islands'),
(109, 'Mauritania'),
(110, 'Mauritius'),
(111, 'Mexico'),
(112, 'Micronesia'),
(113, 'Moldova'),
(114, 'Monaco'),
(115, 'Mongolia'),
(116, 'Montenegro'),
(117, 'Morocco'),
(118, 'Mozambique'),
(119, 'Myanmar (formerly Burma)'),
(120, 'Namibia'),
(121, 'Nauru'),
(122, 'Nepal'),
(123, 'Netherlands'),
(124, 'New Zealand'),
(125, 'Nicaragua'),
(126, 'Niger');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] ON;
INSERT INTO [Country].[tblCountries] ([Id], [Name])
VALUES (127, 'Nigeria'),
(128, 'North Korea'),
(129, 'North Macedonia'),
(130, 'Norway'),
(131, 'Oman'),
(132, 'Pakistan'),
(133, 'Palau'),
(134, 'Palestine State'),
(135, 'Panama'),
(136, 'Papua New Guinea'),
(137, 'Paraguay'),
(138, 'Peru'),
(139, 'Philippines'),
(140, 'Poland'),
(141, 'Portugal'),
(142, 'Qatar'),
(143, 'Romania'),
(144, 'Russia'),
(145, 'Rwanda'),
(146, 'Saint Kitts and Nevis'),
(147, 'Saint Lucia'),
(148, 'Saint Vincent and the Grenadines'),
(149, 'Samoa'),
(150, 'San Marino'),
(151, 'Sao Tome and Principe'),
(152, 'Saudi Arabia'),
(153, 'Senegal'),
(154, 'Serbia'),
(155, 'Seychelles'),
(156, 'Sierra Leone'),
(157, 'Singapore'),
(158, 'Slovakia'),
(159, 'Slovenia'),
(160, 'Solomon Islands'),
(161, 'Somalia'),
(162, 'South Africa'),
(163, 'South Korea'),
(164, 'South Sudan'),
(165, 'Spain'),
(166, 'Sri Lanka'),
(167, 'Sudan'),
(168, 'Suriname');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] ON;
INSERT INTO [Country].[tblCountries] ([Id], [Name])
VALUES (169, 'Sweden'),
(170, 'Switzerland'),
(171, 'Syria'),
(172, 'Tajikistan'),
(173, 'Tanzania'),
(174, 'Thailand'),
(175, 'Timor-Leste'),
(176, 'Togo'),
(177, 'Tonga'),
(178, 'Trinidad and Tobago'),
(179, 'Tunisia'),
(180, 'Turkey'),
(181, 'Turkmenistan'),
(182, 'Tuvalu'),
(183, 'Uganda'),
(184, 'Ukraine'),
(185, 'United Arab Emirates'),
(186, 'United Kingdom'),
(187, 'United States of America'),
(188, 'Uruguay'),
(189, 'Uzbekistan'),
(190, 'Vanuatu'),
(191, 'Venezuela'),
(192, 'Vietnam'),
(193, 'Yemen'),
(194, 'Zambia'),
(195, 'Zimbabwe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Country].[tblCountries]'))
    SET IDENTITY_INSERT [Country].[tblCountries] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DateOfBirth', N'FirstName', N'IsActive', N'LastName', N'Nationality', N'PicturePath') AND [object_id] = OBJECT_ID(N'[Director].[tblDirectors]'))
    SET IDENTITY_INSERT [Director].[tblDirectors] ON;
INSERT INTO [Director].[tblDirectors] ([Id], [DateOfBirth], [FirstName], [IsActive], [LastName], [Nationality], [PicturePath])
VALUES (1, '1965-02-17', 'Michael', 'Yes', 'Bay', 'American', N'/images/MichaelBay.png'),
(2, '1970-07-30', 'Christopher', 'Yes', 'Nolan', 'English', N'/images/ChristopherNolan.png'),
(3, '1937-11-30', 'Ridley', 'Yes', 'Scott', 'English', N'/images/RidleyScott.png'),
(4, '1935-12-01', 'Woody', 'No', 'Allen', 'American', N'/images/WoodyAllen.png'),
(5, '1961-10-31', 'Peter', 'Yes', 'Jackson', 'New Zealander', N'/images/PeterJackson.png');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DateOfBirth', N'FirstName', N'IsActive', N'LastName', N'Nationality', N'PicturePath') AND [object_id] = OBJECT_ID(N'[Director].[tblDirectors]'))
    SET IDENTITY_INSERT [Director].[tblDirectors] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Genre].[tblGenres]'))
    SET IDENTITY_INSERT [Genre].[tblGenres] ON;
INSERT INTO [Genre].[tblGenres] ([Id], [Name])
VALUES (1, 'Action'),
(2, 'Adventure'),
(3, 'Animation'),
(4, 'Comedy'),
(5, 'Devotional'),
(6, 'Drama'),
(7, 'Hindu mythology'),
(8, 'Historical'),
(9, 'Horror'),
(10, 'Science fiction');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Genre].[tblGenres]'))
    SET IDENTITY_INSERT [Genre].[tblGenres] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Genre].[tblGenres]'))
    SET IDENTITY_INSERT [Genre].[tblGenres] ON;
INSERT INTO [Genre].[tblGenres] ([Id], [Name])
VALUES (11, 'Western');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Genre].[tblGenres]'))
    SET IDENTITY_INSERT [Genre].[tblGenres] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Genre].[tblGenres]'))
    SET IDENTITY_INSERT [Genre].[tblGenres] ON;
INSERT INTO [Genre].[tblGenres] ([Id], [Name])
VALUES (12, 'Other');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Genre].[tblGenres]'))
    SET IDENTITY_INSERT [Genre].[tblGenres] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryId', N'DirectorId', N'GenreId', N'ReleaseDate', N'Title') AND [object_id] = OBJECT_ID(N'[Movie].[tblMovies]'))
    SET IDENTITY_INSERT [Movie].[tblMovies] ON;
INSERT INTO [Movie].[tblMovies] ([Id], [CountryId], [DirectorId], [GenreId], [ReleaseDate], [Title])
VALUES (1, 187, 1, 1, '2003-10-08', 'Bad Boys 2'),
(2, 186, 2, 1, '2020-08-26', 'Tenet'),
(3, 186, 3, 10, '1979-09-13', 'Aliens'),
(4, 187, 4, 6, '2011-06-15', 'Midnight in Paris'),
(5, 124, 5, 1, '2005-12-14', 'King Kong');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryId', N'DirectorId', N'GenreId', N'ReleaseDate', N'Title') AND [object_id] = OBJECT_ID(N'[Movie].[tblMovies]'))
    SET IDENTITY_INSERT [Movie].[tblMovies] OFF;
GO

CREATE UNIQUE INDEX [IX_tblCountries_Id] ON [Country].[tblCountries] ([Id]);
GO

CREATE UNIQUE INDEX [IX_tblCountries_Name] ON [Country].[tblCountries] ([Name]);
GO

CREATE UNIQUE INDEX [IX_tblDirectors_Id] ON [Director].[tblDirectors] ([Id]);
GO

CREATE UNIQUE INDEX [IX_tblGenres_Id] ON [Genre].[tblGenres] ([Id]);
GO

CREATE UNIQUE INDEX [IX_tblGenres_Name] ON [Genre].[tblGenres] ([Name]);
GO

CREATE INDEX [IX_tblMovies_CountryId] ON [Movie].[tblMovies] ([CountryId]);
GO

CREATE INDEX [IX_tblMovies_DirectorId] ON [Movie].[tblMovies] ([DirectorId]);
GO

CREATE INDEX [IX_tblMovies_GenreId] ON [Movie].[tblMovies] ([GenreId]);
GO

CREATE UNIQUE INDEX [IX_tblMovies_Id] ON [Movie].[tblMovies] ([Id]);
GO

CREATE UNIQUE INDEX [IX_tblMovies_Title] ON [Movie].[tblMovies] ([Title]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230109161519_FullScript', N'6.0.10');
GO

COMMIT;
GO

