﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using recommendWeb.Models;
using recommendWeb.Helpers;
using recommendWeb.Providers;
using System.Collections;

namespace recommendWeb.Controllers
{
    public class UserController : ApiController
    {
        
        [HttpGet]
        [Route("api/User/GetAll")]
        public HttpResponseMessage GetAll()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                ArrayList userList = UserHelper.GetAllUser();
                response.Content = new StringContent(JsonObjectConverter.ObjectToJson(userList));
                response.StatusCode = HttpStatusCode.OK;

                return response;
            }
            catch(Exception e)
            {
                response.Content = new StringContent(e.StackTrace);
                response.StatusCode = HttpStatusCode.NotFound;

                return response;
            }
            
        }

        [HttpGet]
        [Route("api/User/GetUserById/id")]
        public HttpResponseMessage GetUserById(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                User user = UserHelper.GetUserById(id);
                response.Content = new StringContent(JsonObjectConverter.ObjectToJson(user));
                response.StatusCode = HttpStatusCode.OK;

                return response;
            }
            catch(Exception e)
            {
                response.Content = new StringContent(e.StackTrace);
                response.StatusCode = HttpStatusCode.NotFound;

                return response;
            }

        }

       
    }
}