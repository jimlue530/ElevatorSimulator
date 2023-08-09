using System;
namespace ElevatorSimulator
{
	public class Elevator
	{

		private string name;
		public int current_floor { get; private set; }
		private int floor_speed = 1; //unit: second



		public Elevator(string _name, int _curret_floor)
		{
			name = _name;
			current_floor = _curret_floor;
        }



		public void Display_floor()
		{
			Console.Write($"{name}: {current_floor}");
		}



		public void Move(int floor)
		{
			if(current_floor!=floor)
			{
                Console.WriteLine($"{name} is moving to floor {floor}...\r\n");

                for (; current_floor != floor; current_floor += (current_floor < floor)? 1 : -1)
                {
                    Thread.Sleep(floor_speed*1000); // Simulate moving speed (1 second delay)
                    Console.WriteLine($" {current_floor} ... ");
                }
                Thread.Sleep(floor_speed * 1000);
                Console.WriteLine($" {current_floor} ... \r\n");
            }
        }

    }
}
