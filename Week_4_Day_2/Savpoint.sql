DECLARE @OrderID INT = 1;

BEGIN TRANSACTION

BEGIN TRY

    -- Savepoint before stock restoration
    SAVE TRANSACTION RestoreStockPoint;

    -- Restore stock quantities
    UPDATE p
    SET p.stock_quantity = p.stock_quantity + oi.quantity
    FROM products p
    JOIN order_items oi
    ON p.product_id = oi.product_id
    WHERE oi.order_id = @OrderID;

    -- Update order status to Rejected (3)
    UPDATE orders
    SET order_status = 3
    WHERE order_id = @OrderID;

    -- Commit if everything succeeds
    COMMIT TRANSACTION;
    PRINT 'Order cancelled successfully and stock restored';

END TRY

BEGIN CATCH

    -- Rollback only to SAVEPOINT if stock restore fails
    ROLLBACK TRANSACTION RestoreStockPoint;

    PRINT 'Error occurred during stock restoration';
    PRINT ERROR_MESSAGE();

    -- Rollback full transaction
    ROLLBACK TRANSACTION;

END CATCH;