CREATE PROCEDURE TodoListGetAll @UserName varchar
AS
SELECT * FROM TodoList WHERE username=@UserName