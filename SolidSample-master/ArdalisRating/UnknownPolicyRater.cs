namespace ArdalisRating
{
    internal class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(RatingEngine engine, ConsoleLogger logger) : base(engine, logger)
        {
            _logger.Log("Unknown Policy Type ...");
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("cant rate Unknown Policy Type ...");
        }
    }
}