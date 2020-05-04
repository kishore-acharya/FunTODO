declare @xmlval xml;
set @xmlval='<todolist>
    <todotitle>Albie</todotitle>
    <todoItem>Vestibulum ac est lacinia nisi venenatis tristique.</todoItem>
	<todoItem>Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.</todoItem>
	<todoItem>In congue. Etiam justo. Etiam pretium iaculis justo.</todoItem>
	<todoItem>In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.</todoItem>
  </todolist>'
INSERT INTO [dbo].[TodoList] ([username], [created_at], [last_modified], [list_data]) VALUES ('kishore101', '2019-05-06 05:43:47', NULL, @xmlval)

