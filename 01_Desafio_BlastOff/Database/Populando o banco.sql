SELECT * FROM [Product]
SELECT * FROM [Purchase]
SELECT * FROM [Mail]
SELECT * FROM [Client]
SELECT * FROM [ProductHasStore]
SELECT * FROM [Store]
SELECT * FROM [Product]

SELECT 
    [Product].[name],
    [Purchase].[totalValue],
    [Purchase].[payment_type],
    [Client].[name]
    FROM [Client] 
    INNER JOIN [Purchase] ON [Client].[cpf] = [Purchase].[ClientCPF] AND [Client].[cpf] = '123456789-74'
    INNER JOIN [Product] ON [Purchase].[ProductId] = [Product].[id]

SELECT PR.[name], PU.[totalValue], PU.[payment_type], C.[name] FROM [Client] AS C INNER JOIN [Purchase] AS PU ON C.[cpf] = PU.[ClientCPF] AND C.[name] = 'João Vitor Alves Lima' INNER JOIN [Product] AS PR ON PU.[ProductId] = PR.[id]

SELECT PR.[name], PU.[totalValue], PU.[payment_type], C.[name] FROM [Client] AS C INNER JOIN [Purchase] AS PU ON C.[cpf] = PU.[ClientCPF] INNER JOIN [Product] AS PR ON PU.[ProductId] = PR.[id]

DELETE Purchase WHERE ProductId = '2' AND ClientCPF = '123456789-74' AND totalValue = 3800.56

SELECT 
    [Store].[name],
    [Product].[name]
    FROM [ProductHasStore]
    INNER JOIN [Store] ON [ProductHasStore].[StoreId] = [Store].[id]
    INNER JOIN [Product] ON [Product].[id] = [ProductHasStore].[ProductId]

INSERT INTO [ProductHasStore]
VALUES ('1','1'), ('1', '3'), ('5', '3'), ('5', '2'), ('2', '1'), ('2', '3'),
     ('3', '4'),  ('3', '1'),  ('3', '2')


INSERT INTO
    [Product]
VALUES ('Redmi Note 7', 'Xiaomi', 'Smartphones', 1236.00, 5000),
('Iphone 11', 'Apple', 'Smartphones', 3599.01, 5000),
('Galaxy S20 Fe', 'Samsung', 'Smartphones', 1869.10, 5000)

DELETE FROM [Client] WHERE [cpf] = '123456789-74'
DELETE FROM [Purchase] WHERE [ClientCPF] = '123456789-74' AND [ProductId] = '2' AND [totalValue] = '3641,91';

INSERT INTO
    [Client]
VALUES ('123456789-74', 'João Vitor Alves Lima', '68412-112', 'joaovitor@gmail.com', '111222333@$', '11', '(34)99323-3232')

EXEC spClientLevel '123456789-74'

EXEC spPurchase '2','151.151.555-85','1', 'Bank slip','1'

INSERT INTO
    [Mail]
VALUES (5, 42.90)

ALTER TABLE [Purchase]
    ALTER COLUMN[totalValue] MONEY NULL

DECLARE @test1 VARCHAR(20), @test2 VARCHAR(20), @test3 MONEY

SET @test1 = '1'
SET @test1 = '123456789-74'
SET @test1 = 18540

SELECT 
    [Store].[name],
    [Product].[name]
    FROM [ProductHasStore]
    INNER JOIN [Store] ON [ProductHasStore].[StoreId] = [Store].[id]
    INNER JOIN [Product] ON [Product].[id] = [ProductHasStore].[ProductId]

SELECT
    [Client].[name] AS Client,
    [Product].[name] AS Product,
    [Review].[score],
    [Review].[text]
    FROM [Review]
    INNER JOIN [Client] ON [Review].[ClientCPF] = [Client].[cpf]
    INNER JOIN [Product] ON [Product].[id] = [Review].[ProductId]

SELECT * FROM [Review]

UPDATE [Review]
    SET [score] = '4', [text] = 'Muito bão'
    WHERE [ProductId] = '2' AND [ClientCPF] = '123456789-74'