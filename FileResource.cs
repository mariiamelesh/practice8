namespace Practice {
	public class FileResource : Resource, IDisposable {

		public FileResource(string name) : base(name) {
			
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
		Console.WriteLine($"Disposed {Name}"); // викликається автоматично
		}
	}
}