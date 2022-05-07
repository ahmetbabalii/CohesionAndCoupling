
namespace ResponsibleElevatorTest
{
    public enum Floors
    {     
        ENTRANCE = 0, 
        FIRST = 1, 
        SECOND = 2, 
        THIRD = 3, 
        FOURTH = 4, 
        FIFTH = 5
    }
    
    public class Floor
    {
        private int _floor;
        public Floor(int floor)
        {
            this._floor = floor;
        }

        public int getIntFloor()
        {
            return _floor;
        }

        public Floors increase()
        {
            Floors upperFloor;
            if (_floor == (int)Floors.ENTRANCE)
                upperFloor = Floors.FIRST;
            else if (_floor == (int)Floors.FIRST)
                upperFloor = Floors.SECOND;
            else if (_floor == (int)Floors.SECOND)
                upperFloor = Floors.THIRD;
            else if (_floor == (int)Floors.THIRD)
                upperFloor = Floors.FOURTH;
            else
                upperFloor = Floors.FIFTH;

            return upperFloor;
        }

        public Floors decrease()
        {
            Floors lowerFloor;
            if (_floor == (int)Floors.FIFTH)
                lowerFloor = Floors.FOURTH;
            else if (_floor == (int)Floors.FOURTH)
                lowerFloor = Floors.THIRD;
            else if (_floor == (int)Floors.THIRD)
                lowerFloor = Floors.SECOND;
            else if (_floor == (int)Floors.SECOND)
                lowerFloor = Floors.FIRST;
            else
                lowerFloor = Floors.ENTRANCE;

            return lowerFloor;
        }

        public override string ToString()
        {
            string text = "Floor: " + getIntFloor();            
            return text;
        }
    }
}
