namespace Singleton;

public class Server
{
	private static Server _instance;
	private readonly List<string> _servers = new List<string>();
	private int _nextServer = 0;

	private Server()
	{
		_servers.Add("192.168.1.1");
		_servers.Add("192.168.1.2");
		_servers.Add("192.168.1.3");
		_servers.Add("192.168.1.4");
	}

	public static Server GetInstance()
	{
		_instance ??= new Server();

		return _instance;
	}

	public string GetServer()
	{
		var result =
			_servers[_nextServer];

		_nextServer++;

		if (_nextServer == _servers.Count)
		{
			_nextServer = 0;
		}

		return result;
	}
}
