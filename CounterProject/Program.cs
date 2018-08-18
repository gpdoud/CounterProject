using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject {
	class Program {
		bool isAvailable = true;

		void Run() {
			for(int idx = 0, nbr = 1; idx < 10; idx++, nbr++) {
				Console.WriteLine($"IDX is {idx}; nbr is {nbr}");
			}

			for(bool continueLooping = true; continueLooping; ) {
				continueLooping = false;
			}
		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
