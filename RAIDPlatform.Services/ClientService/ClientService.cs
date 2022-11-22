//using RAIDPlatform.Data.Models.Client.Client_Application_Category;
//using RAIDPlatform.Data.Repositories.Interfaces;
//using RAIDPlatform.Utilities;
//using System.Text.RegularExpressions;

//namespace RAIDPlatform.Services.ClientService
//{
//    public class ClientService : IClientService
//    {
//        private readonly IClientRepository _clientRepository;

//        public ClientService(IClientRepository clientRepository) 
//        { 
//        _clientRepository = clientRepository;
//        }
//        public async Task<Response<List<Client_Application_Category>>> GetAllApplicationCategory()
//        {
//            var query = await _clientRepository.GetAllClientApplicationCategory();
//            if (query == null || query.Count <= 0)
//            {
//                return new Response<List<Client_Application_Category>>()
//                {
//                    Success = false,
//                    Message = "No Data found"
//                };
//            }

//            return new Response<List<Client_Application_Category>>()
//            {
//                Success = true,
//                Message = $"{query.Count} fetched successfully",
//                Data = query
//            };
//        }
//        public async Task<Response<Client_Application_Category>> GetClientApplicationCategoryByIdAsync(int id)
//        {
//            try
//            {
//                var response = await _clientRepository.GetClientApplicationCategoryByID(id);
//                return new Response<Client_Application_Category>()
//                {
//                    Success = response != null ? true : false,
//                    Message = response != null ? $"Successfully fetched Application Category." : "Sorry, No Application Category found",
//                    Data = response != null ? response : null

//                };

//            }
//            catch (Exception ex)
//            {
//                return new Response<Client_Application_Category>()
//                {
//                    Success = false,
//                    Message = $"Error occurred while Application Category responses. Reason: {ex.Message}",
//                    Data = null
//                };
//            }
//        }
//        public async Task<Response<Client_Application_Category>> UpdateQualityStatus(Client_Application_Category client_Application_Category, int Id)
//        {
//            var _temp = await _clientRepository.GetClientApplicationCategoryByID(Id);
//            try
//            {
//                await _clientRepository.UpdateClientApplicationCategory(_temp);
//                var response = await _clientRepository.UpdateClientApplicationCategory(_temp);

//                return new Response<Client_Application_Category>()
//                {
//                    Success = response > 0 ? true : false,
//                    Message = response > 0 ? $"Successfully Updated Application Category." : "",
//                    Data = response > 0 ? _temp : null
//                };
//            }
//            catch (Exception ex)
//            {
//                return new Response<Client_Application_Category>()
//                {
//                    Success = false,
//                    Message = $"Error occurred while updating Application Category. Reason: {ex.Message}",
//                    Data = null
//                };
//            }
//        }
//    }
//}
