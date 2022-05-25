SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spPurchase](
    @cpf VARCHAR(20),
    @productId INT,
    @total INT,
    @paymentType VARCHAR(20),
    @code INT
) AS
    BEGIN TRANSACTION
        DECLARE @testCpf VARCHAR(20),
                @testProductId INT,
                @testTotal INT,
                @testStock INT, @testShoppingCart INT,
                @testCode INT,
                @test BIT

        SELECT @testCode = [code] FROM [Mail]
        WHERE [code] = @code;

        SELECT @testStock = [quantity] FROM [Product]
        WHERE [id] = @testProductId

        SELECT @testShoppingCart = [quantity_purchased] FROM [Purchase]
        WHERE [ProductId] = @testProductId

        IF @testCode IS NULL BEGIN
            PRINT 'Purchase not made, mail not available'
        END
        IF @testCpf IS NULL OR @testProductId IS NULL BEGIN
            PRINT 'Purchase not made, invalid CPF or Product'
        END
        IF @testShoppingCart > @testStock BEGIN
            PRINT 'Purchase not made, insufficient quantity'
        END


    COMMIT 
GO
