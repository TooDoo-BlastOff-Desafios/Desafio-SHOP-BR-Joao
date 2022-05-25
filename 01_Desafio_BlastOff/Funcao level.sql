CREATE OR ALTER PROCEDURE [spClientLevel](
   @p_clientCPF VARCHAR(20)
) AS
    BEGIN TRANSACTION

        DECLARE @v_level VARCHAR(25),
                @v_quantity INT,
                @test VARCHAR (25)

        SELECT @v_quantity = [quantity_purchased], @test = [ClientCPF]
        FROM [Purchase]
        WHERE [ClientCPF] =  @p_clientCPF;

        IF @v_quantity IS NULL BEGIN
            SET @v_quantity = 0
        END

        IF @v_quantity >= 0 AND @v_quantity <=10 BEGIN
            SET @v_level = '1';
        END 
        ELSE BEGIN
            IF @v_quantity > 10 AND @v_quantity <=20 BEGIN
            SET @v_level = '2';
            END 
        ELSE BEGIN
            IF @v_quantity > 20 BEGIN
            SET @v_level = '3';
            END 
        ELSE BEGIN
            SET @v_level = 'Invalid level'
            END
        END
        END

        IF @test IS NULL BEGIN
            PRINT 'This client not exist'
        END

        UPDATE
        [Client]
        SET
            [level] = @v_level
        WHERE
            [cpf] = @p_clientCPF
    COMMIT
    RETURN @v_level