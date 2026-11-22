CREATE DATABASE StudentRegistrationDB;
GO

USE StudentRegistrationDB;
GO

CREATE TABLE Programs
(
    ProgramId INT IDENTITY(1,1)
        CONSTRAINT PK_Programs PRIMARY KEY,
    ProgramCode VARCHAR(20) NOT NULL
        CONSTRAINT UQ_Programs_ProgramCode UNIQUE,
    ProgramName VARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL
        CONSTRAINT DF_Programs_IsActive DEFAULT 1,
    CreatedAt DATETIME2 NOT NULL
        CONSTRAINT DF_Programs_CreatedAt DEFAULT SYSDATETIME()
);
GO

CREATE TABLE Students
(
    StudentId INT IDENTITY(1,1)
        CONSTRAINT PK_Students PRIMARY KEY,
    NIM VARCHAR(20) NOT NULL
        CONSTRAINT UQ_Students_NIM UNIQUE,
    Name VARCHAR(100) NOT NULL,
    ProgramId INT NOT NULL,
    BirthDate DATE NULL,
    Address VARCHAR(255) NULL,
    PhoneNumber VARCHAR(20) NULL,
    CreatedAt DATETIME2 NOT NULL
        CONSTRAINT DF_Students_CreatedAt DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2 NULL,

    CONSTRAINT FK_Students_Programs
        FOREIGN KEY (ProgramId)
            REFERENCES Programs(ProgramId)
);
GO

INSERT INTO Programs (ProgramCode, ProgramName)
VALUES
    ('TI',  'Teknik Informatika'),
    ('SI',  'Sistem Informasi'),
    ('MKT', 'Manajemen'),
    ('TE',  'Teknik Elektro'),
    ('DKV', 'Desain Komunikasi Visual');
GO

INSERT INTO Students (NIM, Name, ProgramId, BirthDate, Address, PhoneNumber)
VALUES
    ('2024001', 'Andi Pratama',   1, '2005-03-14', 'Jl. Raya Menganti No. 10, Surabaya',     '081234567801'),
    ('2024002', 'Siti Rahma',     2, '2005-07-21', 'Jl. Sambikerep Indah No. 5, Surabaya',   '081234567802'),
    ('2024003', 'Budi Santoso',   1, '2004-11-02', 'Jl. Kertajaya No. 22, Surabaya',         '081234567803'),
    ('2024004', 'Dewi Lestari',   3, '2005-01-30', 'Jl. Keputih Tegal No. 8, Surabaya',      '081234567804'),
    ('2024005', 'Rizky Ramadhan', 4, '2005-05-09', 'Jl. Raya Lontar No. 3, Surabaya',        '081234567805');
GO

SELECT
    s.StudentId,
    s.NIM,
    s.Name,
    p.ProgramCode,
    p.ProgramName,
    s.BirthDate,
    s.Address,
    s.PhoneNumber,
    s.CreatedAt,
    s.UpdatedAt
FROM Students s
INNER JOIN Programs p ON s.ProgramId = p.ProgramId
ORDER BY s.StudentId;
GO

SELECT
    s.StudentId,
    s.NIM,
    s.Name,
    p.ProgramName,
    s.BirthDate,
    s.PhoneNumber
FROM Students s
INNER JOIN Programs p ON s.ProgramId = p.ProgramId
WHERE
    s.NIM LIKE '%' + @Search + '%'
    OR s.Name LIKE '%' + @Search + '%'
    OR p.ProgramName LIKE '%' + @Search + '%'
ORDER BY s.StudentId;
GO

SELECT COUNT(*) AS TotalStudents
FROM Students;

SELECT
    p.ProgramName,
    COUNT(s.StudentId) AS TotalStudents
FROM Programs p
LEFT JOIN Students s ON p.ProgramId = s.ProgramId
GROUP BY p.ProgramId, p.ProgramName
ORDER BY TotalStudents DESC;
GO

UPDATE Students
SET
    NIM = @NIM,
    Name = @Name,
    ProgramId = @ProgramId,
    BirthDate = @BirthDate,
    Address = @Address,
    PhoneNumber = @PhoneNumber,
    UpdatedAt = SYSDATETIME()
WHERE StudentId = @StudentId;

DELETE FROM Students
WHERE StudentId = @StudentId;
GO
