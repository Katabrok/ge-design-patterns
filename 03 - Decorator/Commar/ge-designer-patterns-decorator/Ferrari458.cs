namespace ge_designer_patterns_decorator
{
    internal class Ferrari458 : ICarro
    {
        public Ferrari458()
        {
        }

        public string Speed()
        {
            return "My fasted speed can be 325 km/h";
        }

        public string Brand()
        {
            return "Ferrari";
        }

        public double ConsumePerLitre(bool city)
        {
            if (city)
                return 5.5;

            return 7.5;
        }
    }
}