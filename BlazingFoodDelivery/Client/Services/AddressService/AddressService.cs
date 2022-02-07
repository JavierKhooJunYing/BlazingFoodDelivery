﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;

namespace BlazingFoodDelivery.Client.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _http;

        public AddressService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Address> AddOrUpdateAddress(Address address)
        {
            var response = await _http.PostAsJsonAsync("api/address", address);
            return response.Content.ReadFromJsonAsync<ServiceResponse<Address>>().Result.Data;
        }

        public async Task<Address> GetAddress()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<Address>>("api/address");
            return response.Data;
        }
    }
}
