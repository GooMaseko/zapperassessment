CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(200),
    LastName VARCHAR(200),
    CreatDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE Merchants (
    MerchantId INT PRIMARY KEY AUTO_INCREMENT,
    Merchant VARCHAR(200),
    CreateDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerID INT,
    MerchantID INT,
    Amount DECIMAL(10, 2),
    TransactionDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (MerchantId) REFERENCES Merchants(MerchantId)
);