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
                @testTrackingCode UNIQUEIDENTIFIER,
                @test BIT

        SELECT @testCode = [code] FROM [Mail]
        WHERE [code] = @code;

        SELECT @testStock = [quantity] FROM [Product]
        WHERE [id] = @productId
        
        SELECT @testCpf = [cpf] FROM [Client]
        WHERE [cpf] = @cpf
        
        SELECT @testProductId = [id] FROM [Product]
        WHERE [id] = @productId
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
            INSERT INTO [Purchase]([ProductId], [ClientCPF], [MailCode], [totalValue], [payment_type], [tracking_code], [quantity_purchased]) VALUES(@productId, @cpf, @code, 500, LOWER(@paymentType), @testTrackingCode, @quantityPurchased); 
        END

    COMMIT 
GO
