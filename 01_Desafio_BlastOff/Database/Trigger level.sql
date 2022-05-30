CREATE OR ALTER TRIGGER trg_Level
ON [Purchase]
FOR INSERT
AS
BEGIN
    DECLARE @cpf VARCHAR(20), @level VARCHAR(25), @productId INT
    
    SELECT @cpf = [ClientCPF], @productId = [ProductId] FROM inserted

    SELECT @level = dbo.fcClientLevel (@cpf)

    BEGIN TRANSACTION
        UPDATE
        [Client]
        SET
            [level] = @level
        WHERE
            [cpf] = @cpf
    COMMIT

    INSERT INTO [Review] ([ProductId], [ClientCPF])
        VALUES(@productId, @cpf)

END
GO