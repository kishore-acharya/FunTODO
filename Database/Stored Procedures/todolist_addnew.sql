create procedure todolist_addnew @username varchar, @todoitems xml
as
insert into dbo.TodoList (username,list_data,created_at,last_modified)
values (@username,@todoitems,GETUTCDATE(),GETUTCDATE())