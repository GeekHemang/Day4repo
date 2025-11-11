namespace ConsoleEncapsulationViolation.Domain
{
    class Rectangle
    {
        public int width;
        public int height;
        public string color;

        public int CalculatedArea()
        {
            return width * height;  
        }


    }
}
