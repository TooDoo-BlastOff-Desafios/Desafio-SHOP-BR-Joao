USE[SHOP_BR]

CREATE TABLE [Product] 
(
    [id] INT NOT NULL IDENTITY(1, 1),
    [name] VARCHAR(45) NOT NULL,
    [brand] VARCHAR(35) NOT NULL,
    [type] VARCHAR(30) NOT NULL,
    [price] MONEY NOT NULL,
    [quantity] INT NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY ([id])
    CONSTRAINT [CK_type] CHECK ([type] IN('Smartphones', 'Peripherals', 'Electronics in general', 'Hardware'))
);
GO

CREATE TABLE [Store] 
(
    [id] INT NOT NULL IDENTITY(1, 1),
    [name] VARCHAR(45) NOT NULL,
    [address] VARCHAR(45) NOT NULL UNIQUE,
    [phone] VARCHAR(20) NOT NULL UNIQUE,
    [email] NVARCHAR(45) NULL UNIQUE,
    CONSTRAINT [PK_Store] PRIMARY KEY ([id])
);
GO
-- -----------------------------------------------------
-- Table Product_has_Store
-- -----------------------------------------------------
CREATE TABLE [ProductHasStore] 
(
    [ProductId] INT NOT NULL,
    [StoreId] INT NOT NULL,
    CONSTRAINT [FK_ProductHasStore_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProductHasStore_Store_StoreId] FOREIGN KEY ([StoreId]) REFERENCES [Store] ([id]) ON DELETE NO ACTION
);
GO

-- -----------------------------------------------------
-- Table Client
-- -----------------------------------------------------
CREATE TABLE [Client] 
(
    [cpf] VARCHAR(20) NOT NULL UNIQUE,
    [name] VARCHAR(45) NOT NULL,
    [cep] VARCHAR(20) NOT NULL,
    [email] VARCHAR(45) NOT NULL UNIQUE,
    [password] NVARCHAR(45) NOT NULL,
    [level] VARCHAR(1) NOT NULL,
    [phone] VARCHAR(20) NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY ([cpf]),
    CONSTRAINT [CK_level] CHECK ([level] IN('0', '1', '2', '3'))
);
GO

-- -----------------------------------------------------
-- Table Mail
-- -----------------------------------------------------
CREATE TABLE [Mail]
(
    [code] UNIQUEIDENTIFIER NOT NULL,
    [deadline] INT NOT NULL,
    [price] MONEY NOT NULL,
    CONSTRAINT [PK_Mail]PRIMARY KEY ([code]),
);
GO

-- -----------------------------------------------------
-- Table Purchase
-- -----------------------------------------------------
CREATE TABLE [Purchase]
(
    [ProductId] INT NOT NULL,
    [ClientCPF] VARCHAR(20) NOT NULL,
    [MailCode] UNIQUEIDENTIFIER NOT NULL,
    [price] MONEY NOT NULL,
    [payment_type] VARCHAR(20) NOT NULL,
    [tracking_code] UNIQUEIDENTIFIER NOT NULL,
    [quantity_purchased] INT NOT NULL,

    CONSTRAINT [FK_Purchase_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([id]),
    CONSTRAINT [FK_Purchase_Client_ClientCPF] FOREIGN KEY ([ClientCPF]) REFERENCES [Client] ([cpf]),
    CONSTRAINT [FK_Purchase_Mail_MailCode] FOREIGN KEY ([MailCode]) REFERENCES [Mail] ([code])
);
GO

-- -----------------------------------------------------
-- Table Review
-- -----------------------------------------------------
CREATE TABLE [Review]
(
    [ProductId] INT NOT NULL,
    [ClientCPF] VARCHAR(20) NOT NULL,
    [score] VARCHAR(1) NOT NULL,
    [text] NVARCHAR(200) NULL,
    
    CONSTRAINT [FK_Review_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([id]),
    CONSTRAINT [FK_Review_Client_ClientCPF] FOREIGN KEY ([ClientCPF]) REFERENCES [Client] ([cpf]),
    CONSTRAINT [CK_score] CHECK ([score] IN ('1', '2', '3', '4', '5'))
);
GO