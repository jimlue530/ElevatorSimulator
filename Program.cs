using System;
using System.Threading;
using ElevatorSimulator;

class Program
{
    static void Main(string[] args)
    {
        Elevator e1 = new("Elevator1", 1); //start from floor 1
        Elevator e2 = new("Elevator2", 1); //start from floor 1
        e1.Display_floor();
        Console.Write("  ,  ");
        e2.Display_floor();
        Console.WriteLine("\r\n");

        while (true)
        {
            Console.Write("請輸入您在的樓層以及您想去的樓層(以空白間隔)： ");

            int floor, target;
            string userInput = Console.ReadLine();
            string[] floors = userInput.Split(' ');
            if (floors.Length == 2)
            {
                floor = int.Parse(floors[0]);
                target = int.Parse(floors[1]);
                Console.WriteLine("");

                Elevator temp = (Math.Abs(e1.current_floor - floor)) < (Math.Abs(e2.current_floor - floor)) ? e1 : e2;
                //根據和使用者的距離，讓較近的電梯優先前往

                temp.Move(floor);
                Console.WriteLine($"現在帶您到{target}樓");
                temp.Move(target);

                e1.Display_floor();
                Console.Write("  ,  ");
                e2.Display_floor();
                Console.WriteLine("\r\n");
            }
        }
    }
}