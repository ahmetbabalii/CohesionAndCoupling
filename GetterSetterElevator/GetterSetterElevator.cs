
namespace GetterSetterElevatorTest
{
    internal class GetterSetterElevator
	{
		private bool doorOpen = false;
		private int currentFloor = 1;
		private int weight = 0;

		private const int CAPACITY = 1000;
		private const int TOP_FLOOR = 5;
		private const int BOTTOM_FLOOR = 1;

		public bool isDoorOpen()
		{
			return doorOpen;
		}

		public void setDoorOpen(bool doorOpen)
		{
			this.doorOpen = doorOpen;
		}

		public int getCurrentFloor()
		{
			return currentFloor;
		}

		public void setCurrentFloor(int currentFloor)
		{
			this.currentFloor = currentFloor;
		}

		public int getWeight()
		{
			return weight;
		}

		public void setWeight(int weight)
		{
			this.weight = weight;
		}

		public int getCAPACITY()
		{
			return CAPACITY;
		}

		public int getTOP_FLOOR()
		{
			return TOP_FLOOR;
		}

		public int getBOTTOM_FLOOR()
		{
			return BOTTOM_FLOOR;
		}
	}
}
