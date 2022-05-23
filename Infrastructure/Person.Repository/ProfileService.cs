using Persons.Contracts;
using Persons.Contracts.Interfaces;
using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository
{
    public class ProfileService : IProfileService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ProfileService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        //---------------------------------------- METHOD GET PERTABLE ---------------------------------------------------------------------------------------------------------------------------------------------
        public async Task<IEnumerable<Address>> GetAddressByBEIdAsync(int addressId)
        {
            try
            {
                var address = _repository.Address.GetAllAddressAsync(trackChanges: false).Result.Where(e => e.AddressID.Equals(addressId));
                return address;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<BusinessEntityAddress>> GetAddressTypeByBEIdAsync(int businessEntityId)
        {
            try
            {
                var addressTypes = _repository.BeAddress.GetAllBeAddressAsync(trackChanges: false).Result.Where(e => e.BusinessEntityID.Equals(businessEntityId));
                return addressTypes;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<EmailAddress>> GetEmailByEmailAsync(int businessEntityId)
        {
            try
            {
                var emails = _repository.Email.GetAllEmailAsync(trackChanges: false).Result.Where(e => e.BusinessEntityID.Equals(businessEntityId));
                return emails;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<PersonPhone>> GetPhoneNumberByBEIdAsync(int businessEntityId)
        {
            try
            {
                var phoneNumbers = _repository.PhoneNumber.GetAllPhoneNumberAsync(trackChanges: false).Result.Where(e => e.BusinessEntityID.Equals(businessEntityId));
                return phoneNumbers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<StateProvince>> GetStateProvinceByBEIdAsync(int stateProvinceId)
        {
            try
            {
                var stateProvinces = _repository.StateProvince.GetAllStateProvinceAsync(trackChanges: false).Result.Where(e => e.StateProvinceID.Equals(stateProvinceId));
                return stateProvinces;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //=================================================================================================================================================

        public async Task<bool> SaveAll(int businessEntityId, PersonMyProfileDto profileDto)
        {
            var personEntity = await _repository.Person.GetPersonAsync(businessEntityId, trackChanges: true);

            personEntity.FirstName = profileDto.FirstName;
            personEntity.MiddleName = profileDto.MiddleName;
            personEntity.LastName = profileDto.LastName;
            personEntity.Suffix = profileDto.Suffix;
            await _repository.SaveAsync();

            if (personEntity == null)
            {
                _logger.LogError($"Person with BusinessEntityId : {businessEntityId} not found");
            }

            // Tabel EmailAddress
            var objEmail = _repository.Email.GetAllEmailAsync(trackChanges: true).Result.Where(e => e.BusinessEntityID == personEntity.BusinessEntityID);
            // Mengecek kondisi dimana jumlah dari input untuk email tidak sama dengan jumlah data email di database
            if (profileDto.Email.Count != objEmail.Count())
            {
                // Kondisi untuk Add email
                if (profileDto.Email.Count > objEmail.Count())
                {
                    foreach (var itemEmail in profileDto.Email)
                    {
                        try
                        {
                            var emailEntity = await _repository.Email.GetEmailAsync(itemEmail, trackChanges: true);
                            var emailModel = new EmailAddress();
                            // Kondisi ADD email
                            if (emailEntity == null)
                            {
                                emailModel.EmailAddress1 = itemEmail;
                                emailModel.BusinessEntityID = businessEntityId;

                                _repository.Email.CreateEmailAsync(emailModel);
                                await _repository.SaveAsync();
                            }
                            /*else
                            // Kondisi Edit email
                            {
                                emailEntity.EmailAddress1 = itemEmail;
                                _repository.Email.UpdateEmailAsync(emailEntity);
                                await _repository.SaveAsync();
                            }*/
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error when insert into EmailAddress {ex.Message}");
                            return false;
                        }
                    }
                }
                // Kondisi untuk Delete email
                if (profileDto.Email.Count < objEmail.Count())
                {
                    foreach (var itemEmail in profileDto.Email) 
                    {
                        try
                        {
                            var emailDelete = _repository.Email.GetAllEmailAsync(trackChanges: true).Result.Where(e => e.BusinessEntityID == businessEntityId);

                            foreach (var item in emailDelete)
                            {
                                if (item.EmailAddress1 != itemEmail)
                                {
                                    _repository.Email.DeleteEmailAsync(item);
                                    _repository.SaveAsync();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error when insert into EmailAddress {ex.Message}");
                            return false;
                        }
                    }
                }
            }
            // Mengecek kondisi dimana kalo jumlah dari input untuk email sama dengan jumlah data email di database
            // Kalo sama dan ada data yang beda maka diupdate
            else
            {
                foreach (var itemEmail in profileDto.Email)
                {
                    try
                    {
                        var emailEntity = _repository.Email.GetAllEmailAsync(trackChanges: true).Result.Where(e => e.BusinessEntityID == businessEntityId );
                        foreach(var item in emailEntity)
                        {
                            if(item.EmailAddress1 != itemEmail )
                            {
                                item.EmailAddress1 = itemEmail;
                                _repository.Email.UpdateEmailAsync(item);
                                await _repository.SaveAsync();  
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Error when insert into EmailAddress {ex.Message}");
                        return false;
                    }
                }    
            }

            // Tabel PersonPhone
            // Pada PhoneNumber hanya dapat Create dan Delete. Tidak dapat edit
            var objPhone = _repository.PhoneNumber.GetAllPhoneNumberAsync(trackChanges: true).Result.Where(p => p.BusinessEntityID == personEntity.BusinessEntityID);
            // Mengecek kondisi dimana jumlah dari input untuk phone number tidak sama dengan jumlah data email di database
            if (profileDto.PhoneNumber.Count != objPhone.Count())
            {
                // Kondisi untuk Add PhoneNumber
                if (profileDto.PhoneNumber.Count > objPhone.Count())
                {
                    foreach (var itemPhone in profileDto.PhoneNumber)
                    {
                        try
                        {
                            var phoneEntity = await _repository.PhoneNumber.GetPhoneNumberAsync(businessEntityId, trackChanges: true);
                            var phoneNumberModel = new PersonPhone();
                            // Kondisi ADD phone number
                            if (itemPhone != objPhone)
                            {
                                phoneNumberModel.PhoneNumber = itemPhone.PhoneNumber;
                                phoneNumberModel.PhoneNumberTypeID = itemPhone.PhoneNumberTypeID;
                                phoneNumberModel.BusinessEntityID = businessEntityId;

                                _repository.PhoneNumber.CreatePhoneNumberAsync(phoneNumberModel);
                                await _repository.SaveAsync();
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error when insert into Table PersonPhone {ex.Message}");
                            return false;
                        }
                    }
                }
                // Kondisi untuk Delete PhoneNumber
                if (profileDto.PhoneNumber.Count < objPhone.Count())
                {
                    foreach (var itemPhone in profileDto.PhoneNumber)
                    {
                        try
                        {
                            var phoneDelete = _repository.PhoneNumber.GetAllPhoneNumberAsync(trackChanges: true).Result.Where(p => p.BusinessEntityID == businessEntityId);

                            foreach (var item in phoneDelete)
                            {
                                if (item.PhoneNumber != itemPhone.PhoneNumber)
                                {
                                    _repository.PhoneNumber.DeletePhoneNumberAsync(item);
                                    _repository.SaveAsync();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error when insert into Table PersonPhone {ex.Message}");
                            return false;
                        }
                    }
                }
            }
            
            // Tabel Address


            //jangan di hapus 
            return true;
        }

    }
}

