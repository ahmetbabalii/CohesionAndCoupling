
namespace ResponsibleElevatorTest
{
    internal class ResponsibleElevator : Elevator
    {
        private bool doorOpen = false;
        private bool stopped = true;
        private Floors currentFloor = Floors.ENTRANCE;        
        private int weight = 0;

        private const int CAPACITY = 1000;

        public void openDoor()
        {
            if (stopped)
                doorOpen = true;

            Console.WriteLine("Kapı Açık");
        }

        public void closeDoor()
        {
            calculateCapacity();
            if (weight <= CAPACITY)
            {
                doorOpen = false;
                stopped = false;
                Console.WriteLine("Kapı Kapalı.");
            }
            else
                Console.WriteLine("Asansör kapasitesini aştı, biri çıkana kadar kapılar açık kalacak");
        }

        public void go(Floors desiredFloor)
        {
            int compare = currentFloor.CompareTo(desiredFloor);
            while (compare != 0)
            {
                if (compare < 0)
                    goUp();
                else
                    goDown();
                compare = currentFloor.CompareTo(desiredFloor);
            }
            stopped = true;
            openDoor();
        }

        private void goUp()
        {
            if (doorOpen)
                closeDoor();
            if (currentFloor.CompareTo(Floors.FIFTH) < 0)
            {
                Console.WriteLine("Yukarı çıkılıyor");
                currentFloor = new Floor((int)currentFloor).increase();
                Console.WriteLine(currentFloor);
            }
            else
                Console.WriteLine("Zaten en üst katta");
            stopped = true;
        }

        private void goDown()
        {
            if (doorOpen)
                closeDoor();
            if (currentFloor.CompareTo(Floors.ENTRANCE) > 0)
            {
                Console.WriteLine("Aşağı iniliyor");
                currentFloor = new Floor((int)currentFloor).decrease(); 
                Console.WriteLine(currentFloor);
            }
            else
                Console.WriteLine("Zaten en alt katta");
            stopped = true;
            openDoor();
        }

        private void calculateCapacity()
        {
            weight = new Random().Next(1000, 1500);
            Console.WriteLine("Ağırlık: " + weight);
        }
    }
}
