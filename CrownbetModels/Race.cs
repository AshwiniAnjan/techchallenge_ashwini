using System.Collections.Generic;

namespace CrownbetModels
{
    public class Customer
    {

        public long Id { get; set; }


        public string Name { get; set; }


        public int BetCount { get; set; }


        public double BetAmount { get; set; }


        public bool RiskIndicator { get; set; }
    }

    public class TotalBets
    {
        public double TotalAmount { get; set; }
    }

    public class Race
    {

        public long Id { get; set; }


        public string Name { get; set; }


        public string Status { get; set; }


        public decimal Stake { get; set; }


        public List<Horse> Horses { get; set; }
    }

    public class Horse
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public long NumberOfBets { get; set; }

        public decimal MoneyPayOut { get; set; }
    }


    public class StandardResponse
    {
        public string apiVersion { get; set; }
        public dynamic Response { get; set; }
        public StandardResponse()
        {
            apiVersion = "0.1";
        }
    }

    public class ErrorRespose
    {
        public string ErrorReason { get; set; }
    }
}
