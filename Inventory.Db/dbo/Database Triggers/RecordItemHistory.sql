create trigger RecordItemHistory_Delete on dbo.Items
  for delete
as
  declare @Now as DateTime = GetDate()
  set nocount on
  insert into History_Items
    select @Now, SUser_SName(), 'delete-deleted', *
      from deleted
go
exec sp_settriggerorder @triggername = 'RecordItemHistory_Delete', @order = 'last', @stmttype = 'delete'
go
create trigger RecordItemHistory_Insert on dbo.Items
  for insert
as
  declare @Now as DateTime = GetDate()
  set nocount on
  insert into History_Items
    select @Now, SUser_SName(), 'insert-inserted', *
      from inserted
go
exec sp_settriggerorder @triggername = 'RecordItemHistory_Insert', @order = 'last', @stmttype = 'insert'
go
create trigger RecordItemHistory_Update on dbo.Items
  for update
as
  declare @Now as DateTime = GetDate()
  set nocount on
  insert into History_Items
    select @Now, SUser_SName(), 'update-deleted', *
      from deleted
  insert into History_Items
    select @Now, SUser_SName(), 'update-inserted', *
      from inserted
go
exec sp_settriggerorder @triggername = 'RecordItemHistory_Update', @order = 'last', @stmttype = 'update'