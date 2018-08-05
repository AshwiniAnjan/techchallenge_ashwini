using Crownbet_Databse;
using CrownbetModels;
using System;
using System.Collections.Generic;
using AutoMapper;
using Crownbet_Common;

namespace Crownbet_Ashwini.Helpers
{
    public interface IRaceHelper
    {
        StandardResponse GetRaces();
        StandardResponse GetCustomers();
        StandardResponse GetBets();
    }

    public class RaceHelper : IRaceHelper
    {
        public IRaceDBConnector _raceDBConnector;
        public ILogger _logHelper;

        public RaceHelper(IRaceDBConnector raceDBConnector, ILogger logHelper)
        {
            _raceDBConnector = raceDBConnector;
            _logHelper = logHelper;
        }

        /// <summary>
        /// Get Bets
        /// </summary>
        /// <returns></returns>
        public StandardResponse GetBets()
        {
            try
            {
                _logHelper.WriteInfo("Inside Helper Get Bets");
                var result = _raceDBConnector.GetBets();

                _logHelper.WriteInfo("Total Bet=" + result);
                TotalBets totalBets = new TotalBets { TotalAmount = result };
                return new StandardResponse { Response = totalBets };
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                ErrorRespose response = new ErrorRespose { ErrorReason = Convert.ToString(ex) };
                return new StandardResponse { Response = response };
            }
            
        }

        /// <summary>
        /// Get Customers
        /// </summary>
        /// <returns></returns>
        public StandardResponse GetCustomers()
        {
            try
            {
                _logHelper.WriteInfo("Inside Helper GetCustomers");
                var result = _raceDBConnector.GetCustomer();
                List<Customer> lstCustomer = new List<Customer>();
                //Automapper maps the object 
                lstCustomer = Mapper.Map<List<SP_GetCustomerDetails_Result>, List<Customer>>(result);

                _logHelper.WriteInfo("Customer Count = " + lstCustomer?? lstCustomer.Count.ToString());
                return new StandardResponse { Response = lstCustomer };
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                ErrorRespose response = new ErrorRespose { ErrorReason = Convert.ToString(ex) };
                return new StandardResponse { Response = response };
            }
        }

        /// <summary>
        /// GetRaces
        /// </summary>
        /// <returns></returns>
        public StandardResponse GetRaces()
        {
            try
            {
                _logHelper.WriteInfo("Inside Helper GetRaces");
                var result = _raceDBConnector.GetRaces();

                List<Race> lstRace = new List<Race>();
                lstRace = Mapper.Map<List<SP_GetRaceDetails_Result>, List<Race>>(result);

                _logHelper.WriteInfo("Race Count = " + lstRace ?? lstRace.Count.ToString());
                foreach (var item in lstRace)
                {
                    _logHelper.WriteInfo("For each race get horse information");
                    _logHelper.WriteInfo("Fetching information for item"+ item.Id);
                    var horses = _raceDBConnector.GetHorses(item.Id);
                    item.Horses = Mapper.Map<List<SP_GetHorseDetails_Result>, List<Horse>>(horses);
                }
                return new StandardResponse { Response = lstRace };
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                ErrorRespose response = new ErrorRespose { ErrorReason = Convert.ToString(ex) };
                return new StandardResponse { Response = response };
            }
        }
    }
}