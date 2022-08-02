CREATE TABLE Books
(
    [BookId] int,
    [AuthorFirstName] nvarchar(50),
    [AuthorLastName] nvarchar(50),
    [BooksTitle] nvarchar(100),
    [BooksCategory] nvarchar(50),
	[BooksAvailableQuantity] int,
);

INSERT INTO Books
(
    [BookId],
    [AuthorFirstName],
    [AuthorLastName],
    [BooksTitle],
    [BooksCategory],
	[BooksAvailableQuantity]
)
VALUES
(1,'George','Martin','A Game of Thrones','Fantasy',10),
(2,'Agatha','Christie','Death on the Nile','Thriller',5),
(3,'Balague','Guillem','Cristiano Ronaldo.Biography','Biography',5),
(4,'Jan','Brzechwa','Akademia Pana Kleksa','Childrens literature',15),
(5,'Frank','Herbert','Dune','Science fiction',5);


CREATE TABLE Users
(
    [Username] nvarchar(50),
    [Password] nvarchar(50),
	[EmailAddress] nvarchar(50),
    [PhoneNumber] int,
    [FirstName] nvarchar(50),
    [LastName] nvarchar(50),
);

INSERT INTO Users
(
    [Username],
    [Password],
	[EmailAddress],
    [PhoneNumber],
    [FirstName],
    [LastName]
)
VALUES
('LM','LM','l@m.pl',123456789,'Lucyfer','Morningstar'),
('CD','CD','c@d.pl',123456789,'Chloe','Decker'),
('DE','DE','d@e.pl',123456789,'Dan','Espinoza');





