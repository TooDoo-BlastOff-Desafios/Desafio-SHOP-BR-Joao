CREATE OR ALTER TRIGGER trg_ProductHasStore
ON [Product]
FOR INSERT
AS
BEGIN
    DECLARE @productId VARCHAR(20), @storeId VARCHAR(25)
    
    SELECT @productId = [id] FROM inserted


    SELECT @storeId = CAST(RAND() * 3 AS INTEGER)

    INSERT INTO [ProductHasStore]
        VALUES (@productId, @storeId)

END
GO