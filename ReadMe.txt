常用命令
1、增加包
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -V 2.0.0

dotnet add package Microsoft.EntityFrameworkCore -V 2.0.1
2、编译发布
dotnet publish --framework netcoreapp2.0 --output "E:\Com.App.Core\OutPut"--configuration Release
3、生成sln文件
dotnet new sln
4、
dotnet ef migrations add InitialCreate
5、数据库初始化
dotnet ef migrations add initial
更新数据库
dotnet ef database update
6、向数据库生成表
dotnet ef database update


7 oracle 数据库支持
 dotnet add package Oracle.ManagedDataAccess
dotnet add packag Oracle.ManagedDataAccess.EntityFramework.dll

如果是在VS中编辑则会自动还原，外面编辑需要手动dotnet restore。

还原好以后就可以使用dotnet ef 命令。

在命令提示符中首先输入dotnet ef migrations add MyFirstMigration，然后再输入dotnet ef database update。

这里我们只是启用了迁移，但不是自动迁移。从提示信息中我们可以看到若要启用自动迁移则要删除Migrations文件夹并在Packge Manager Console中输入

Enable-Migrations –EnableAutomaticMigrations命令或者在Migrations文件夹的Configuration.cs文件中设置AutomaticMigrationsEnabled属性为true即可。