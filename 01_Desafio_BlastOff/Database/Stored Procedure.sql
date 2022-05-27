CREATE OR ALTER PROCEDURE spPurchase(
    @productId INT,
    @cpf VARCHAR(20),
    @quantityPurchased INT,
    @paymentType VARCHAR(20),
    @code INT
) AS
    BEGIN TRANSACTION
        DECLARE @testCpf VARCHAR(20),
                @testProductId INT,
                @testQuantityPurchased INT,
                @testStock INT, 
                @testCode INT,
                @mailPrice MONEY,
                @testTrackingCode UNIQUEIDENTIFIER,
                @totalValue MONEY,
                @productPrice MONEY,
                @test BIT

        SELECT @testCode = [code], @mailPrice = [price] FROM [Mail]
        WHERE [code] = @code;

        SELECT @testStock = [quantity] FROM [Product]
        WHERE [id] = @productId
        
        SELECT @testCpf = [cpf] FROM [Client]
        WHERE [cpf] = @cpf
        
        SELECT @testProductId = [id] FROM [Product]
        WHERE [id] = @productId

        SELECT @productPrice = [price] FROM [Product]
        WHERE [id] = @productId                

        SET @totalValue = (@quantityPurchased * @productPrice) + @mailPrice
        SET @test = 1
        SET @testTrackingCode = NEWID()

        IF @testCode IS NULL BEGIN
            SET @test = 0
            PRINT 'Purchase not made, mail not available'
        END
        IF @testCpf IS NULL OR @testProductId IS NULL BEGIN
            SET @test = 0
            PRINT 'Purchase not made, invalid CPF or Product'
        END
        IF @quantityPurchased > @testStock BEGIN
            SET @test = 0
            PRINT 'Purchase not made, insufficient quantity'
        END
        IF @test = 1 BEGIN
            INSERT INTO [Purchase]([ProductId], [ClientCPF], [MailCode], [totalValue], [payment_type], [tracking_code], [quantity_purchased]) VALUES(@productId, @cpf, @code, @totalValue, LOWER(@paymentType), @testTrackingCode, @quantityPurchased); 
        END

        UPDATE [Product]
        SET [quantity] = [quantity] - @quantityPurchased
        WHERE [id] = @productId

    COMMIT 
GO
