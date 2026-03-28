namespace Practice {
	public class Program {
		static void Main(string[] args) {
			//Step 1 ResourceManager
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


			// Step 2 Struct vs Class 
			Point p1 = new Point { X = 1, Y = 2 };
			Point p2 = p1; 
			p2.X = 67; 
			Console.WriteLine(p1.X); // тут виходить 1 бо ми змінили властивість КОПІЇ а не оригінальної структури

			PointRef r1 = new PointRef { X = 1, Y = 2 };
			PointRef r2 = r1; 
			r2.X = 67;
			Console.WriteLine(r1.X); // тут виходить 67 бо змінилась властивість класу
		}
	}
}