namespace LeetCode.SpiralMatrix
{
    public struct Pointer
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        private int maxX;
        private int maxY;

        private int minX;
        private int minY;

        private int route;

        public Pointer(int maxX, int maxY)
        {
            this.maxX = maxX;
            this.maxY = maxY;

            minX = 0;
            minY = 0;
            route = 0;
            X = 0;
            Y = 0;
        }

        public void GoToNextRoute()
        {
            if (route == 3) route = 0;
            else route++;
        }

        public bool TryMoveNext()
        {
            switch (route)
            {
                case 0: return TryMoveRight();
                case 1: return TryMoveDown();
                case 2: return TryMoveLeft();
                case 3: return TryMoveTop();
                default: return false;
            }
        }

        public bool TryMoveRight()
        {
            if (X >= maxX)
            {
                minY++;
                return false;
            }

            X++;
            return true;
        }

        public bool TryMoveDown()
        {
            if (Y >= maxY)
            {
                maxX--;
                return false;
            }

            Y++;
            return true;
        }

        public bool TryMoveLeft()
        {
            if (X <= minX)
            {
                maxY--;
                return false;
            }

            X--;
            return true;
        }

        public bool TryMoveTop()
        {
            if (Y <= minY)
            {
                minX++;
                return false;
            }

            Y--;
            return true;
        }
    }
}