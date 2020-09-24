using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }
        //apply single responsibility to create separate classes for every responsibility
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
        public PolicySerializer policySerializer { set; get; } = new PolicySerializer();
        public FilePolicySource PolicySource { get; set; } = new FilePolicySource();
        public void Rate()
        {
            Logger.Log("Starting rate.");

            Logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = PolicySource.GetPolicyFromSource();

            var policy = policySerializer.GetPolicyfromJsonString(policyJson);

            var factory = new RaterFactory();
            var rater = factory.Create(policy, this);
            rater.Rate(policy);
            Logger.Log("Rating completed.");
        }
    }
}
