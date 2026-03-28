namespace Practice {
	public abstract class Resource {
		public string Name {get; set; }
		public bool IsOpen {get; set; }

		public Resource(string name) {
			Name = name;
		}

		public abstract void Open();
		public abstract void Close();
	}
}