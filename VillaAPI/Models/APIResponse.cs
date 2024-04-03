﻿using System.Net;

namespace VillaAPI.Models
{
    public class APIResponse
    {
        public APIResponse() => ErrorMessages = [];
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessages {  get; set; }
        public object Result { get; set; }
    }
}
