UPDATE [DotW].[dbo].[Users]
SET Users.Email = AspNetUsers.Email
FROM [DotW].[dbo].[AspNetUsers], [DotW].[dbo].[Users]
WHERE AspNetUsers.Id = Users.AspNetUserId