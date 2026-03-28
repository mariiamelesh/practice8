namespace Practice {
	public class ResourceManager<T> where T : Resource {
		private List<T> _items = new List<T>();
		
		public void Add(T resource) {
			_items.Add(resource);
		}

		public void OpenAll() {
			foreach (T item in _items) {
				item.Open();
			}
		}

		public void CloseAll() {
			foreach (T item in _items) {
				item.Close();
			}
		}
	}
}