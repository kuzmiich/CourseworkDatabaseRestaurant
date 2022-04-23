CREATE TRIGGER Goods_Control_Delete
ON Goods
INSTEAD OF DELETE
AS
    UPDATE Goods
    SET IsDeleted = 1
    WHERE Id = (SELECT Id FROM deleted)

    UPDATE Manufacturers
    SET IsDeleted = 1
    WHERE Id = (SELECT Id FROM deleted)
GO