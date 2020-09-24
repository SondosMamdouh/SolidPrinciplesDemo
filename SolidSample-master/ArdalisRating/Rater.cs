namespace ArdalisRating
{
    public abstract class Rater
    {
        public readonly RatingEngine _enging;
        public ConsoleLogger _logger;

        public Rater(RatingEngine engine, ConsoleLogger logger)
        {
            _enging = engine;
            _logger = logger;
        }


        public abstract void Rate(Policy policy);
    }
}