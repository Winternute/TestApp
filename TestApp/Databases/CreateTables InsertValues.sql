CREATE TABLE [dbo].[Users] (
    [id]            INT   PRIMARY KEY IDENTITY,
    [name]          NVARCHAR (255) NOT NULL,
    [gender]        BIT            NULL,
    [date_of_birth] DATETIME       NULL,     
);

CREATE TABLE [dbo].[Products] (
    [id]          INT        PRIMARY KEY IDENTITY,
    [name]        NCHAR (45) NOT NULL,
    [description] NCHAR (45) NULL
);

CREATE TABLE [dbo].[Orders] (
    [id]          INT      PRIMARY KEY IDENTITY,
    [created_on]  DATETIME NOT NULL,
    [modified_on] DATETIME NULL,
    [user_id]     INT      NOT NULL,
    CONSTRAINT [fk_order_user1_idx] FOREIGN KEY ([user_id]) REFERENCES [dbo].[Users] ([id])
);

CREATE TABLE [dbo].[Order_lines] (
    [id]         INT          PRIMARY KEY IDENTITY,
    [price]      DECIMAL (18) NULL,
    [quantity]   INT          NULL,
    [product_id] INT          NOT NULL,
    [order_id]   INT          NOT NULL,     
    CONSTRAINT [fk_order_line_product1_idx] FOREIGN KEY ([product_id]) REFERENCES [dbo].[Products] ([id]),
    CONSTRAINT [fk_order_line_order1_idx] FOREIGN KEY ([order_id]) REFERENCES [dbo].[Orders] ([id])
);

INSERT INTO Users Values (N'Иванов Иван', NULL, NULL),
						 (N'Петров Петр', NULL, NULL),
						 (N'Пупкин Василий', NULL, NULL)

INSERT INTO Products Values (N'Товар 1', NULL),
							(N'Товар 2', NULL),
							(N'Товар 3', NULL),
							(N'Товар 4', NULL),
							(N'Товар 5', NULL),
							(N'Товар 6', NULL),
							(N'Товар 7', NULL),
							(N'Товар 8', NULL),
							(N'Товар 9', NULL),
							(N'Товар 10', NULL),
							(N'Товар 11', NULL),
							(N'Товар 12', NULL)

INSERT INTO Orders Values (GETDATE(), NULL, 1),
						    (GETDATE(), NULL, 2),
						    (GETDATE(), NULL, 1),
						    (GETDATE(), NULL, 1),
						    (GETDATE(), NULL, 3)

INSERT INTO Order_lines Values (1023, 2, 1, 1),
							   (56, 4, 2, 1),
							   (2331, 1, 3, 1),
							   (244, 12, 5, 1),
							   (311, 1, 8, 1),
							   (56, 3, 9, 1),
							   (43, 2, 12, 1),
							   (213, 5, 11, 1),

							   (123, 1, 5, 2),
							   (675, 4, 8, 2),
							   (54, 5, 9, 2),
							   (1234, 10, 3, 2),
							   (3454, 20, 10, 2),

							   (1231, 1, 3, 3),

							   (2133, 13, 7, 4),
							   (3243, 14, 5, 4),
							   (1231, 10, 3, 4),
							   (235, 30, 10, 4),

							   (300, 2, 1, 5),
							   (200, 6, 8, 5),
							   (1000, 7, 3, 5)