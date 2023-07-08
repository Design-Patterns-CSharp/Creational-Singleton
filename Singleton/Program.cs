namespace Singleton;

internal class Program
{
	static void Main(string[] args)
	{
		var server1 = Server.GetInstance();
		var server2 = Server.GetInstance();

		for (int index = 0; index < 10; index++)
		{
			Console.WriteLine(server1.GetServer());
			Console.WriteLine(server2.GetServer());
		}
	}
}


/*
	هنگامی که میخواهیم از یک کلاس در سطح برنامه
	تنها یک شیء ساخته شود
	سازنده کلاس را 
	private
	تعریف میکنیم
	و یک متد با نام 
	GetInstance
	به صورت 
	public
	در کلاس تعریف کرده و برای شی سازی از این متد استفاده میکنم
 */