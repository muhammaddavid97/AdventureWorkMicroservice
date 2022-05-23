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
                    var emailEntity = _repository.Email.GetAllEmailAsync(trackChanges: true).Result.Where(e => e.BusinessEntityID == personEntity.BusinessEntityID);
                    foreach (var itemEmail in profileDto.Email)
                    {
                        try
                        {
                            bool isFound = false;

                            foreach (var itemEmailData in emailEntity)
                            {
                                if (itemEmail == itemEmailData.EmailAddress1)
                                {
                                    isFound = true;
                                    break;
                                }
                            }
                            // Kalo data yg diinput ga ada di database
                            if (isFound == false)
                            {
                                var emailModel = new EmailAddress();
                                emailModel.EmailAddress1 = itemEmail;
                                emailModel.BusinessEntityID = businessEntityId;

                                _repository.Email.CreateEmailAsync(emailModel);
                                await _repository.SaveAsync();
                            }
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
                    var emailDelete = _repository.Email.GetAllEmailAsync(trackChanges: true).Result.Where(e => e.BusinessEntityID == businessEntityId);
                    foreach (var item in emailDelete)
                    {
                        try
                        {
                            bool isFound = false;

                            foreach (var itemEmail in profileDto.Email)
                            {
                                if (itemEmail == item.EmailAddress1)
                                {
                                    isFound = true;
                                    break;
                                }
                            }
                            if (isFound == false)
                            {
                                _repository.Email.DeleteEmailAsync(item);
                                _repository.SaveAsync();
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
            /*else if (profileDto.Email.Count == objEmail.Count())
            {
                var emailUpdate = _repository.Email.GetAllEmailAsync(trackChanges: true).Result.Where(e => e.BusinessEntityID == businessEntityId);
                foreach (var itemDb in emailUpdate)
                {
                    bool isFound = false;
                    foreach (var itemDto in profileDto.Email)
                    {
                        if (itemDb.EmailAddress1 == itemDto)
                        {
                            isFound = true;
                            break;
                        }

                    }
                    if (isFound == false)
                    {
                        string dtoEmail = "";

                        itemDb.EmailAddress1 = dtoEmail;
                        _repository.Email.UpdateEmailAsync(itemDb);
                        await _repository.SaveAsync();
                    }
                }
            }*/

            // Tabel PersonPhone
            // Pada PhoneNumber hanya dapat Create dan Delete. Tidak dapat edit!
            var objPhone = _repository.PhoneNumber.GetAllPhoneNumberAsync(trackChanges: true).Result.Where(p => p.BusinessEntityID == personEntity.BusinessEntityID);
            // Mengecek kondisi dimana jumlah dari input untuk phone number tidak sama dengan jumlah data email di database
            if (profileDto.PhoneNumber.Count != objPhone.Count())
            {
                // Kondisi untuk Add PhoneNumber
                if (profileDto.PhoneNumber.Count > objPhone.Count())
                {
                    var phoneEntity = _repository.PhoneNumber.GetAllPhoneNumberAsync(trackChanges: true).Result.Where(p => p.BusinessEntityID == personEntity.BusinessEntityID);
                    foreach (var itemPhone in profileDto.PhoneNumber)
                    {
                        try
                        {
                            bool isFound = false;

                            foreach (var itemPhoneData in phoneEntity)
                            {
                                if (itemPhone.PhoneNumberTypeID == itemPhoneData.PhoneNumberTypeID && itemPhone.PhoneNumber == itemPhoneData.PhoneNumber)
                                {
                                    isFound = true;
                                    break;
                                }
                            }
                            // Kalo data yg diinput ga ada di database
                            if (isFound == false)
                            {
                                var phoneNumberModel = new PersonPhone();
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
                    var phoneDelete = _repository.PhoneNumber.GetAllPhoneNumberAsync(trackChanges: true).Result.Where(p => p.BusinessEntityID == businessEntityId);
                    foreach (var item in phoneDelete)
                    {
                        try
                        {
                            bool isFound = false;

                            foreach (var itemPhone in profileDto.PhoneNumber)
                            {
                                if (itemPhone.PhoneNumberTypeID == item.PhoneNumberTypeID && itemPhone.PhoneNumber == item.PhoneNumber)
                                {
                                    isFound = true;
                                    break;
                                }
                            }
                            // Kondisi menghapus data yang ada di Dto tpi ga ada di database
                            if (isFound == false)
                            {
                                _repository.PhoneNumber.DeletePhoneNumberAsync(item);
                                _repository.SaveAsync();
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
            /*var objAddress = _repository.BeAddress.GetAllBeAddressAsync(trackChanges: true).Result.Where(a => a.BusinessEntityID == personEntity.BusinessEntityID);
            // Mengecek kondisi dimana jumlah dari input untuk address tidak sama dengan jumlah data email di database
            if (profileDto.Address.Count != objAddress.Count())
            {
                // Kondisi untuk Add Address
                if (profileDto.Address.Count > objAddress.Count())
                {
                    var addressEntity = _repository.BeAddress.GetAllBeAddressAsync(trackChanges: true).Result.Where(a => a.BusinessEntityID == personEntity.BusinessEntityID);

                    // Kondisi jika Address null maka akan create
                    if (addressEntity == null)
                    {
                        try
                        {
                            foreach (var itemAddressDto in profileDto.Address)
                            {
                                var newAddress = new Address();
                                var newBEAddress = new BusinessEntityAddress();
                                var newState = new StateProvince();

                                newAddress.StateProvinceID = itemAddressDto.StateProvinceID;
                                newAddress.AddressLine1 = itemAddressDto.AddressLine1;
                                _repository.Address.CreateAddressAsync(newAddress);
                                await _repository.SaveAsync();

                                newBEAddress.BusinessEntityID = businessEntityId;
                                newBEAddress.AddressTypeID = itemAddressDto.AddressTypeID;
                                newBEAddress.AddressID = newAddress.AddressID;
                                _repository.BeAddress.CreateBeAddressAsync(newBEAddress);
                                await _repository.SaveAsync();

                                newState.CountryRegionCode = itemAddressDto.CountryRegionCode;
                                _repository.StateProvince.CreateStateProvincevAsync(newState);
                                await _repository.SaveAsync();
                            }
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                    }

                    // Kondisi Add address
                    foreach (var inputItemAddress in profileDto.Address)
                    {
                        try
                        {
                            bool isFound = false;

                            foreach (var itemAddressData in addressEntity)
                            {
                                if (inputItemAddress.AddressTypeID == itemAddressData.AddressTypeID
                                    && inputItemAddress.AddressLine1 == itemAddressData.Address.AddressLine1)
                                {
                                    isFound = true;
                                    break;
                                }
                            }
                            // Kalo data yg diinput ga ada di database
                            if (isFound == false)
                            {
                                var newAddress = new Address();
                                var newBEAddress = new BusinessEntityAddress();
                                var newState = new StateProvince();

                                newAddress.StateProvinceID = inputItemAddress.StateProvinceID;
                                newAddress.AddressLine1 = inputItemAddress.AddressLine1;
                                _repository.Address.CreateAddressAsync(newAddress);
                                await _repository.SaveAsync();

                                newBEAddress.BusinessEntityID = businessEntityId;
                                newBEAddress.AddressTypeID = inputItemAddress.AddressTypeID;
                                newBEAddress.AddressID = newAddress.AddressID;
                                _repository.BeAddress.CreateBeAddressAsync(newBEAddress);
                                await _repository.SaveAsync();

                                newState.CountryRegionCode = inputItemAddress.CountryRegionCode;
                                _repository.StateProvince.CreateStateProvincevAsync(newState);
                                await _repository.SaveAsync();
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error when insert into Table Address {ex.Message}");
                            return false;
                        }
                    }
                }
                // Kondisi untuk Delete PhoneNumber
                if (profileDto.Address.Count < objAddress.Count())
                {
                    var addressDelete = _repository.BeAddress.GetAllBeAddressAsync(trackChanges: true).Result.Where(a => a.BusinessEntityID == businessEntityId);
                    foreach (var itemAddDb in addressDelete)
                    {
                        try
                        {
                            bool isFound = false;

                            foreach (var itemAddDto in profileDto.Address)
                            {
                                if (itemAddDto.AddressTypeID == itemAddDb.AddressTypeID &&
                                    itemAddDto.AddressLine1 == itemAddDb.Address.AddressLine1)
                                {
                                    isFound = true;
                                    break;
                                }
                            }
                            // Kondisi menghapus data yang ada di Dto tpi ga ada di database
                            if (isFound == false)
                            {
                                _repository.BeAddress.DeleteBeAddressAsync(itemAddDb);
                                _repository.SaveAsync();
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error when insert into Table Address {ex.Message}");
                            return false;
                        }
                    }
                }
            }
            else
            {
                var bussAddUpdate = _repository.BeAddress.GetAllBeAddressAsync(trackChanges: true).Result.Where(a => a.BusinessEntityID == businessEntityId);
                *//*foreach (var itemAddDto in profileDto.Address)
                {
                    bool isFound = false;
                    foreach (var itemAddDb in bussAddUpdate) 
                    {
                        if (itemAddDb.Address.AddressLine1 == itemAddDto.AddressLine1)
                        {
                            isFound = true;
                            break;
                        }
                    }
                    if (isFound == false)
                    {
                        itemAddDb.AddressTypeID = ;
                        _repository.Email.UpdateEmailAsync(itemDb);
                        await _repository.SaveAsync();
                    }
                }*//*
            }*/

            //jangan di hapus 
            return true;
        }
    }
}

//---------------------------------------- METHOD GET DATA PERTABLE ---------------------------------------------------------------------------------------------------------------------------------------------
/*public async Task<IEnumerable<Address>> GetAddressByBEIdAsync(int addressId)
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
}*/
//=================================================================================================================================================


