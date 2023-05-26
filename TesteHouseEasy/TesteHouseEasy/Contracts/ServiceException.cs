using Microsoft.Extensions.Localization;
using System.Collections;
using TesteHouseEasy.Models.Contract;

namespace TesteHouseEasy.Contracts
{
    public class ServiceException
    {
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public ServiceException(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }

        public ResultRequest ResultHandleException(bool success, Exception ex)
        {
            ResultRequest result = new ResultRequest(false, null);

            if (ex.GetType().Name == "PostgresException")
            {
                bool validation = false;
                foreach (DictionaryEntry de in ex.Data)
                {
                    if (de.Key.Equals("SqlState") && ex.Data[de.Key].Equals("P0001"))
                    {
                        validation = true;
                        result = new ResultRequest(false, ex.Message, null);
                    }
                }
                if (!validation)
                {
                    result = new ResultRequest(false, _sharedLocalizer["ErrorGeneric"], null);
                }
            }
            else
            {
                result = new ResultRequest(false, _sharedLocalizer["ErrorGeneric"], null);
            }

            return result;
        }
    }
}
