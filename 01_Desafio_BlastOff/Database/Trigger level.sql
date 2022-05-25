CREATE OR ALTER TRIGGER trg_Level
ON [Purchase]
FOR INSERT
AS
BEGIN
    DECLARE @cpf VARCHAR(20)
    
    SELECT @cpf = [ClientCPF] FROM inserted

    EXEC spClientLevel @cpf
END
GO