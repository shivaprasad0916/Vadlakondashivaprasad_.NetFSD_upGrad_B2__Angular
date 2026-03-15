BEGIN TRANSACTION

BEGIN TRY

    -- Insert order
    INSERT INTO orders(order_id, order_date)
    VALUES (1, GETDATE());

    -- Insert order items
    INSERT INTO order_items(item_id, order_id, product_id, quantity)
    VALUES
    (1,1,101,2),
    (2,1,102,1);

    COMMIT TRANSACTION
    PRINT 'Order placed successfully'

END TRY

BEGIN CATCH

    ROLLBACK TRANSACTION
    PRINT 'Order failed due to insufficient stock'

END CATCH