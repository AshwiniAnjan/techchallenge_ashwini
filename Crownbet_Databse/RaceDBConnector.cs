using Crownbet_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crownbet_Databse
{
    public interface IRaceDBConnector
    {
        List<SP_GetCustomerDetails_Result> GetCustomer();
        List<SP_GetRaceDetails_Result> GetRaces();
        List<SP_GetHorseDetails_Result> GetHorses(long raceId);
        double GetBets();
    }

    /// <summary>
    /// Using Entity Framework here
    /// </summary>
    public class RaceDBConnector : IRaceDBConnector
    {
        private CrownbetEntities _db;
        public ILogger _logHelper;

        public RaceDBConnector(ILogger logHelper)
        {
            _db = new CrownbetEntities();
            _logHelper = logHelper;
        }

        /// <summary>
        /// Gets the Total bets for all customers
        /// </summary>
        /// <returns></returns>
        public double GetBets()
        {
            _logHelper.WriteInfo("Inside Database GetBets");
            try
            {
                if (_db != null)
                {
                   
                    var result = _db.SP_GetTotalBets().ToList();
                    if (result != null)
                    {
                        return Convert.ToDouble(result.SingleOrDefault().Value);
                    }
                }
                return Convert.ToDouble(0);
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block"+ Convert.ToString(ex));
                throw new Exception(Convert.ToString(ex));
            }
           
        }

        public List<SP_GetCustomerDetails_Result> GetCustomer()
        {
            try
            {

                _logHelper.WriteInfo("Inside Database GetCustomer");
                if (_db != null)
                {
                    return _db.SP_GetCustomerDetails().ToList();
                }
                return null;
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                throw new Exception(Convert.ToString(ex));
            }
        }

        public List<SP_GetHorseDetails_Result> GetHorses(long raceId)
        {
            try
            {

                _logHelper.WriteInfo("Inside Database GetHorses");
                if (_db != null)
                {
                    return _db.SP_GetHorseDetails(raceId).ToList();
                }
                return null;
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                throw new Exception(Convert.ToString(ex));
            }
        }

        public List<SP_GetRaceDetails_Result> GetRaces()
        {
            try
            {
                _logHelper.WriteInfo("Inside Database GetRaces");
                if (_db != null)
                {
                    return _db.SP_GetRaceDetails().ToList();
                }
                return null;
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                throw new Exception(Convert.ToString(ex));
            }
        }
    }
}
