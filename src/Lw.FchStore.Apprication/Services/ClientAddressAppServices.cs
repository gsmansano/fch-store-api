﻿using Lw.FchStore.Application.Builder;
using Lw.FchStore.Domain.Entities;
using Lw.FchStore.Domain.Interfaces.Repositories;
using Lw.FchStore.Domain.Interfaces.Services;
using System.Linq;

namespace Lw.FchStore.Application.Services;

public class ClientAddressAppServices : AppServices<ClientAddress>, IClientAddressAppServices
{
    private readonly IClientAddressRepository _repository;

    public ClientAddressAppServices(IClientAddressRepository repository) : base(repository)
    {
        _repository = repository;
    }

    public async Task<ClientAddress> Add(int clientId, string fullAddress, string city, string country, string zipCode)
    {
        var clientAddress = new ClientAddress()
        {
            ClientId = clientId,
            AddressLine1 = fullAddress,
            City = city,
            Country = country,
            ZipCode = zipCode,
            IsActive = true,
            CreatedAt = DateTime.Now
        };

        return await _repository.Add(clientAddress);
    }

    public async Task<ClientAddress> GetById(int clientId, int clientAddressId)
    {

        var data = _repository.FirstOrDefault(p => p.ClientId == clientId && p.ClientAddressId == clientAddressId);

        return data;

    }
}
