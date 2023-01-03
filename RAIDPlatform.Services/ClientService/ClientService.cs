using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Data.Repositories.Repositories;
using RAIDPlatform.Utilities;
using System.Text.RegularExpressions;

namespace RAIDPlatform.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<Response<List<Client_Application_Category>>> GetAllClientApplicationCategoryAsync()
        {
            var query = await _clientRepository.GetAllClientApplicationCategory();
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Client_Application_Category>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Client_Application_Category>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<List<Client_Application_Category>>> GetAllClientApplicationCategoryByClientIdAsync(int Id)
        {
            var query = await _clientRepository.GetAllClientApplicationCategoryByClientId(Id);
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Client_Application_Category>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Client_Application_Category>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<Client_Application_Category>> GetClientApplicationCategoryByIdAsync(int id)
        {
            try
            {
                var response = await _clientRepository.GetClientApplicationCategoryById(id);
                return new Response<Client_Application_Category>()
                {
                    Success = response != null ? true : false,
                    Message = response != null ? $"Successfully fetched Application Category." : "Sorry, No Client Application Category found",
                    Data = response != null ? response : null

                };

            }
            catch (Exception ex)
            {
                return new Response<Client_Application_Category>()
                {
                    Success = false,
                    Message = $"Error occurred while Application Category responses. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<int>> AddClientApplicationCategoryAsync(Client_Application_Category client_Application_Category)
        {
            try
            {
                var query = await _clientRepository.AddClientApplicationCategory(client_Application_Category);

                if (query != 0)
                {

                    return new Response<int>()
                    {
                        Success = true,
                        Message = $"Client Application Category Added Successfully",
                        Data = query
                    };
                }
                else
                {
                    return new Response<int>()
                    {
                        Success = false,
                        Message = "Failed to add Client Application Category."
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Success = false,
                    Message = $"Failed to add Client Application Category. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<Client_Application_Category>> UpdateClientApplicationCategoryAsync(Client_Application_Category client_Application_Category, int Id)
        {
            var ua = await GetClientApplicationCategoryByIdAsync(Id);

            try
            {
                if (ua != null)
                {
                    ua.Data.ClientId = client_Application_Category.ClientId;
                    ua.Data.ApplicationId = client_Application_Category.ApplicationId;
                    ua.Data.Client_Application_Category_Name = client_Application_Category.Client_Application_Category_Name;
                    ua.Data.Client_Application_Category_Key = client_Application_Category.Client_Application_Category_Key;
                    ua.Data.Client_Application_Category_Description = client_Application_Category.Client_Application_Category_Description;
                    ua.Data.StatusId = client_Application_Category.StatusId;
                    ua.Data.Status_Value = client_Application_Category.Status_Value;
                    ua.Data.Updated_By_ID = client_Application_Category.Updated_By_ID;
                    ua.Data.Updated_By_Name = client_Application_Category.Updated_By_Name;
                    ua.Data.Updated_Date = DateTime.Now.Date;
                }
               // await _clientRepository.UpdateClientApplicationCategory(client_Application_Category);
                var response = await _clientRepository.UpdateClientApplicationCategory(ua.Data);

                return new Response<Client_Application_Category>()
                {
                    Success = response > 0 ? true : false,
                    Message = response > 0 ? $"Successfully Updated Client Application Category." : "",
                    Data = response > 0 ? ua.Data : null
                };
            }
            catch (Exception ex)
            {
                return new Response<Client_Application_Category>()
                {
                    Success = false,
                    Message = $"Error occurred while updating Client Application Category. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<bool>> DeleteClientApplicationCategoryAsync(int id)
        {
            try
            {
                var query = await _clientRepository.DeleteClientApplicationCategory(id);
                if (query)
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Client Application Category successfully deleted",
                        Data = true
                    };
                }
                else
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Failed to delete Client Application Category",
                        Data = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<bool>()
                {
                    Success = false,
                    Message = $"Exception occurred while deleting Client Application Category. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<List<Client_Application_Security_Group>>> GetAllClientApplicationSecurityGroupAsync()
        {
            var query = await _clientRepository.GetAllClientApplicationSecurityGroup();
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Client_Application_Security_Group>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Client_Application_Security_Group>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<List<Client_Application_Security_Group>>> GetAllClientApplicationSecurityGroupByClientIdAsync(int Id)
        {
            var query = await _clientRepository.GetAllClientApplicationSecurityGroupByClientId(Id);
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Client_Application_Security_Group>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Client_Application_Security_Group>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<Client_Application_Security_Group>> GetClientApplicationSecurityGroupByIdAsync(int id)
        {
            try
            {
                var response = await _clientRepository.GetClientApplicationSecurityGroupById(id);
                return new Response<Client_Application_Security_Group>()
                {
                    Success = response != null ? true : false,
                    Message = response != null ? $"Successfully fetched Client Application Security Group." : "Sorry, No Client Application Security Group found",
                    Data = response != null ? response : null

                };

            }
            catch (Exception ex)
            {
                return new Response<Client_Application_Security_Group>()
                {
                    Success = false,
                    Message = $"Error occurred while Client Application Security Group responses. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<int>> AddClientApplicationSecurityGroupAsync(Client_Application_Security_Group client_Application_Security_Group)
        {
            try
            {
                var query = await _clientRepository.AddClientApplicationSecurityGroup(client_Application_Security_Group);

                if (query != 0)
                {

                    return new Response<int>()
                    {
                        Success = true,
                        Message = $"Client Application Security Group Added Successfully",
                        Data = query
                    };
                }
                else
                {
                    return new Response<int>()
                    {
                        Success = false,
                        Message = "Failed to add Client Application Security Group."
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Success = false,
                    Message = $"Failed to add Client Application Security Group. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<Client_Application_Security_Group>> UpdateClientApplicationSecurityGroupAsync(Client_Application_Security_Group client_Application_Security_Group, int Id)
        {
            var ua = await GetClientApplicationSecurityGroupByIdAsync(Id);

            try
            {
                if (ua != null)
                {
                    ua.Data.ClientId = client_Application_Security_Group.ClientId;
                    ua.Data.ApplicationId = client_Application_Security_Group.ApplicationId;
                    ua.Data.Client_Application_Security_Group_Name = client_Application_Security_Group.Client_Application_Security_Group_Name;
                    ua.Data.Client_Application_Security_Group_Key = client_Application_Security_Group.Client_Application_Security_Group_Key;
                    ua.Data.Client_Application_Security_Group_Description = client_Application_Security_Group.Client_Application_Security_Group_Description;
                    ua.Data.StatusId = client_Application_Security_Group.StatusId;
                    ua.Data.Status_Value = client_Application_Security_Group.Status_Value;
                    ua.Data.Updated_By_ID = client_Application_Security_Group.Updated_By_ID;
                    ua.Data.Updated_By_Name = client_Application_Security_Group.Updated_By_Name;
                    ua.Data.Updated_Date = DateTime.Now.Date;
                }
               // await _clientRepository.UpdateClientApplicationSecurityGroup(client_Application_Security_Group);
                var response = await _clientRepository.UpdateClientApplicationSecurityGroup(ua.Data);

                return new Response<Client_Application_Security_Group>()
                {
                    Success = response > 0 ? true : false,
                    Message = response > 0 ? $"Successfully Updated Client Application Security Group." : "",
                    Data = response > 0 ? ua.Data : null
                };
            }
            catch (Exception ex)
            {
                return new Response<Client_Application_Security_Group>()
                {
                    Success = false,
                    Message = $"Error occurred while updating Client Application Security Group. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<bool>> DeleteClientApplicationSecurityGroupAsync(int id)
        {
            try
            {
                var query = await _clientRepository.DeleteClientApplicationSecurityGroup(id);
                if (query)
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Client Application Security Group successfully deleted",
                        Data = true
                    };
                }
                else
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Failed to delete Client Application Security Group",
                        Data = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<bool>()
                {
                    Success = false,
                    Message = $"Exception occurred while deleting Client Application Security Group. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<List<Users>>> GetAllUsersAsync()
        {
            var query = await _clientRepository.GetAllUsers();
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Users>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Users>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<List<Users>>> GetAllUsersByClientIdAsync(int Id)
        {
            var query = await _clientRepository.GetAllUserByClientId(Id);
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Users>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Users>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<Users>> GetUsersByIdAsync(int id)
        {
            try
            {
                var response = await _clientRepository.GetUsersByID(id);
                return new Response<Users>()
                {
                    Success = response != null ? true : false,
                    Message = response != null ? $"Successfully fetched User." : "Sorry, No User found",
                    Data = response != null ? response : null

                };

            }
            catch (Exception ex)
            {
                return new Response<Users>()
                {
                    Success = false,
                    Message = $"Error occurred while User responses. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<int>> AddUserAsync(Users users)
        {
            try
            {
                var query = await _clientRepository.AddUser(users);

                if (query != 0)
                {

                    return new Response<int>()
                    {
                        Success = true,
                        Message = $"User Added Successfully",
                        Data = query
                    };
                }
                else
                {
                    return new Response<int>()
                    {
                        Success = false,
                        Message = "Failed to add User."
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Success = false,
                    Message = $"Failed to add Users. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<Users>> UpdateUsersAsync(Users users, int Id)
        {
            var ua = await GetUsersByIdAsync(Id);

            try
            {
                if (ua != null)
                {
                    ua.Data.ClientId = users.ClientId;
                    ua.Data.UserTypeId = users.UserTypeId;
                    ua.Data.User_Type_Value = users.User_Type_Value;
                    ua.Data.Is_AD_User = users.Is_AD_User;
                    ua.Data.User_Email = users.User_Email;
                    ua.Data.User_Name = users.User_Name;
                    ua.Data.Phone_Number = users.Phone_Number;
                    ua.Data.DesignationId = users.DesignationId;
                    ua.Data.Designation_Value = users.Designation_Value;
                    ua.Data.ReportingToId = users.ReportingToId;
                    ua.Data.Reporting_To_Name = users.Reporting_To_Name;
                    ua.Data.OrgHierarchyId = users.OrgHierarchyId;
                    ua.Data.Org_Hierarchy_Value = users.Org_Hierarchy_Value;
                    ua.Data.User_Password = users.User_Password;
                    ua.Data.User_OTP = users.User_OTP;
                    ua.Data.User_OTP_Expiry = users.User_OTP_Expiry;
                    ua.Data.User_OTP_Expired = users.User_OTP_Expired;
                    ua.Data.StatusId = users.StatusId;
                    ua.Data.Status_Value = users.Status_Value;
                    ua.Data.Updated_By_ID = users.Updated_By_ID;
                    ua.Data.Updated_By_Name = users.Updated_By_Name;
                    ua.Data.Updated_Date = DateTime.Now.Date;
                }
               // await _clientRepository.UpdateUsers(users);
                var response = await _clientRepository.UpdateUsers(ua.Data);

                return new Response<Users>()
                {
                    Success = response > 0 ? true : false,
                    Message = response > 0 ? $"Successfully Updated Users." : "",
                    Data = response > 0 ? ua.Data : null
                };
            }

            catch (Exception ex)
            {
                return new Response<Users>()
                {
                    Success = false,
                    Message = $"Error occurred while updating Users. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<bool>> DeleteUsersAsync(int id)
        {
            try
            {
                var query = await _clientRepository.DeleteUsers(id);
                if (query)
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Users successfully deleted",
                        Data = true
                    };
                }
                else
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Failed to delete Users",
                        Data = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<bool>()
                {
                    Success = false,
                    Message = $"Exception occurred while deleting Users. Reason: {ex.Message}"
                };
            }
        }

        public async Task<Response<List<Clients>>> GetAllClientsAsync()
        {
            var query = await _clientRepository.GetAllClient();
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Clients>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Clients>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        } 
        public async Task<Response<Clients>> GetClientByIdAsync(int id)
        {
            try
            {
                var response = await _clientRepository.GetClientsByID(id);
                return new Response<Clients>()
                {
                    Success = response != null ? true : false,
                    Message = response != null ? $"Successfully fetched Client." : "Sorry, No Client found",
                    Data = response != null ? response : null

                };

            }
            catch (Exception ex)
            {
                return new Response<Clients>()
                {
                    Success = false,
                    Message = $"Error occurred while Client responses. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<int>> AddClientAsync(Clients clients)
        {
            try
            {
                var query = await _clientRepository.AddClient(clients);

                if (query != 0)
                {

                    return new Response<int>()
                    {
                        Success = true,
                        Message = $"Client Added Successfully",
                        Data = query
                    };
                }
                else
                {
                    return new Response<int>()
                    {
                        Success = false,
                        Message = "Failed to add Client."
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Success = false,
                    Message = $"Failed to add Client. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<Clients>> UpdateClientsAsync(Clients clients, int Id)
        {
            var ua = await GetClientByIdAsync(Id);

            try
            {
                if (ua != null)
                {
                    ua.Data.Client_Name = clients.Client_Name;
                    ua.Data.Client_Key = clients.Client_Key;
                    ua.Data.Client_Description = clients.Client_Description;
                    ua.Data.Primary_Address = clients.Primary_Address;
                    ua.Data.Primary_Email = clients.Primary_Email;
                    ua.Data.Primary_Landline = clients.Primary_Landline;
                    ua.Data.Primary_Cell = clients.Primary_Cell;
                    ua.Data.Primary_Contact_Name = clients.Primary_Contact_Name;
                    ua.Data.Primary_Contact_Email = clients.Primary_Contact_Email;
                    ua.Data.Primary_Contact_Landline = clients.Primary_Contact_Landline;
                    ua.Data.Primary_Contact_Cell = clients.Primary_Contact_Cell;
                    ua.Data.Secondary_Contact_Name = clients.Secondary_Contact_Name;
                    ua.Data.Secondary_Contact_Email = clients.Secondary_Contact_Email;
                    ua.Data.Secondary_Contact_Landline = clients.Secondary_Contact_Landline;
                    ua.Data.Secondary_Contact_Cell = clients.Secondary_Contact_Cell;
                    ua.Data.StatusId = clients.StatusId;
                    ua.Data.Status_Value = clients.Status_Value;
                    ua.Data.Created_By_ID = clients.Created_By_ID;
                    ua.Data.Created_By_Name = clients.Created_By_Name;
                    ua.Data.Created_Date = clients.Created_Date;
                    ua.Data.Updated_By_ID = clients.Updated_By_ID;
                    ua.Data.Updated_By_Name = clients.Updated_By_Name;
                    ua.Data.Updated_Date = clients.Updated_Date;
                }
              //  await _clientRepository.UpdateClients(clients);
                var response = await _clientRepository.UpdateClients(ua.Data);

                return new Response<Clients>()
                {
                    Success = response > 0 ? true : false,
                    Message = response > 0 ? $"Successfully Updated Clients." : "",
                    Data = response > 0 ? ua.Data : null
                };
            }

            catch (Exception ex)
            {
                return new Response<Clients>()
                {
                    Success = false,
                    Message = $"Error occurred while updating Clients. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<bool>> DeleteClientAsync(int id)
        {
            try
            {
                var query = await _clientRepository.DeleteClients(id);
                if (query)
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Client successfully deleted",
                        Data = true
                    };
                }
                else
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Failed to delete Clients",
                        Data = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<bool>()
                {
                    Success = false,
                    Message = $"Exception occurred while deleting Clients. Reason: {ex.Message}"
                };
            }
        }
    }
}
