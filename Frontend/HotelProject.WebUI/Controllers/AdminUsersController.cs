﻿using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUsersController : Controller
    {
        //    private readonly UserManager<AppUser> _userManager;

        //    public AdminUsersController(UserManager<AppUser> userManager)
        //    {
        //        _userManager = userManager;
        //    }
        //    [AllowAnonymous]
        //    public IActionResult Index()
        //    {
        //        var values = _userManager.Users.ToList();
        //        return View(values);
        //    }
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:5001/api/AppUser");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserListDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
