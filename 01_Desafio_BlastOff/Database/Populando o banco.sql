SELECT * FROM [Product]
SELECT * FROM [Client]
SELECT * FROM [Mail]
SELECT * FROM [Product]
SELECT * FROM [Purchase]


INSERT INTO
    [Product]
VALUES ('Redmi Note 7', 'Xiaomi', 'Smartphones', 1236.00, 5000),
('Iphone 11', 'Apple', 'Smartphones', 3599.01, 5000),
('Galaxy S20 Fe', 'Samsung', 'Smartphones', 1869.10, 5000)

DELETE FROM [Client] WHERE [cpf] = '123456789-74'

INSERT INTO
    [Client]
VALUES ('123456789-74', 'João Vitor Alves Lima', '68412-112', 'joaovitor@gmail.com', '111222333@$', '11', '(34)99323-3232')

EXEC spClientLevel '123456789-74'

EXEC spPurchase '1','123456789-74','2', 'Bank slip','1'

INSERT INTO
    [Mail]
VALUES (5, 42.90)

ALTER TABLE [Purchase]
    ALTER COLUMN[totalValue] MONEY NULL
