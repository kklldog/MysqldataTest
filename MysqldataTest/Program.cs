// See https://aka.ms/new-console-template for more information
using MysqldataTest;

Console.WriteLine("Hello, World!");

string connectString = "Database=agile;Data Source=r3nqzsdz9ism.ap-northeast-2.psdb.cloud;" +
    "User Id=losuema80q51;Password=pscale_pw_MRKKdGy6mu9nUfyDoD_i8E8cyupV4iKNJA8p8qCn5S0;port=3306;" +
    "";

var FREESQL = new FreeSql.FreeSqlBuilder()
                         .UseConnectionString(FreeSql.DataType.MySql, connectString)
                         .Build();
//var effrow = FREESQL.Insert(new SysLog()
//{
//    AppId = "1",
//    LogType = SysLogType.Normal,
//    LogTime = DateTime.Now,
//    LogText = "test"
//}).ExecuteAffrows();

using (var ctx = FREESQL.CreateDbContext())
{
    var item = new SysLog()
    {
        AppId = "1",
        LogType = SysLogType.Normal,
        LogTime = DateTime.Now,
        LogText = "test"
    };
    ctx.Add(item);
    var effrow = ctx.SaveChanges();
    Console.WriteLine(effrow);
}

