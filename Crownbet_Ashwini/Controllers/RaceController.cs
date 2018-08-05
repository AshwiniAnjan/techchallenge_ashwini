using System.Web.Http;
using CrownbetModels;
using Crownbet_Ashwini.Helpers;
using Crownbet_Common;
using System;

namespace Crownbet_Web.Controllers
{
    public class RaceController : ApiController
    {
        //Interfaces are used here for dependency injection
        public IRaceHelper _raceHelper;
        public ILogger _logHelper;

        #region  Constructor
        public RaceController(IRaceHelper raceHelper, ILogger logHelper)
        {
            _raceHelper = raceHelper;
            _logHelper = logHelper;
        }
        #endregion

        /// <summary>
        /// Gets all the races and horses running in the race
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public StandardResponse GetRaces(string name = default(string))
        {
            try
            {
                _logHelper.WriteInfo("Inside Race Method --- Entry");
                if (name == string.Empty || name == null)
                {
                    _logHelper.WriteInfo("name is empty");
                    ErrorRespose error = new ErrorRespose { ErrorReason = "Name is Empty" };
                    return new StandardResponse { Response = error };
                }
                _logHelper.WriteInfo("Calling Helper Method");
                return _raceHelper.GetRaces();
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                StandardResponse errorResponse = new StandardResponse();
                errorResponse.Response = Convert.ToString(ex);
                return errorResponse;
            }

        }

        /// <summary>
        /// Gets all the customers info
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public StandardResponse GetCustomers(string name = default(string))
        {
            try
            {
                _logHelper.WriteInfo("Inside GetCustomers Method --- Entry");
                if (name == string.Empty || name ==null)
                {
                    _logHelper.WriteInfo("name is empty");
                    ErrorRespose error = new ErrorRespose { ErrorReason = "Name is Empty" };
                    return new StandardResponse { Response = error };
                }
                return _raceHelper.GetCustomers();
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                StandardResponse errorResponse = new StandardResponse();
                errorResponse.Response = Convert.ToString(ex);
                return errorResponse;
            }
        }

        /// <summary>
        /// Gets Total bet value
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public StandardResponse GetBets(string name = default(string))
        {
            try
            {
                _logHelper.WriteInfo("Inside GetBets Method --- Entry");
                if (name == string.Empty || name == null)
                {
                    _logHelper.WriteInfo("name is empty");
                    ErrorRespose error = new ErrorRespose { ErrorReason = "Name is Empty" };
                    return new StandardResponse { Response = error };
                }
                return _raceHelper.GetBets();
            }
            catch (Exception ex)
            {
                _logHelper.WriteInfo("Inside Exception Block" + Convert.ToString(ex));
                StandardResponse errorResponse = new StandardResponse();
                errorResponse.Response = Convert.ToString(ex);
                return errorResponse;
            }
        }
    }
}
