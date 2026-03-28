namespace Practice {
	public class NetworkResource : Resource, IDisposable {

		public NetworkResource(string name) : base(name) {

		}
		
		public override void Open() {
		IsOpen = true;
		Console.WriteLine($"Resource {Name} opened");
		}
		public override void Close() {
		IsOpen = false;
		Console.WriteLine($"Resource {Name} closed");
		}
		public void Dispose()
		{
		Close();
		Console.WriteLine($"Disposed {Name}"); 
		}
	}
}