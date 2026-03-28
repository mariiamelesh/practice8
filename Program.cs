namespace Practice {
	public class Program {
		static void Main(string[] args) {

			FileResource fr1 = new FileResource("xxx.txt");
			NetworkResource nr1 = new NetworkResource("bebebe");
			ResourceManager<Resource> rm = new ResourceManager<Resource>();
			rm.Add(fr1);
			rm.Add(nr1);
			rm.OpenAll();
			
			var res = new FileResource("memem.txt");

			using (res) {
				res.Open();
			} 
			Console.WriteLine($"IsOpen after using: {res.IsOpen}"); 

			rm.CloseAll();
		}
	}
}