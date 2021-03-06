﻿using AiursoftBase.Exceptions;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiursoftBase
{
    public static class Values
    {
        public static string DeveloperServerAddress { get; private set; } = "http://developer.aiursoft.obisoft.com.cn";
        public static string ApiServerAddress { get; private set; } = "http://api.aiursoft.obisoft.com.cn";
        public static string DeveloperSiteAppId { get; private set; } = string.Empty;
        public static string DeveloperSiteAppSecret { get; private set; } = string.Empty;
        public static IApplicationBuilder UseAiursoftAuthentication(this IApplicationBuilder app, string appId, string appSecret, string ServerAddress = "")
        {
            if (string.IsNullOrWhiteSpace(appId))
            {
                throw new NotAValidAiurArgumentException(nameof(appId));
            }
            if (string.IsNullOrWhiteSpace(appSecret))
            {
                throw new NotAValidAiurArgumentException(nameof(appSecret));
            }
            if (!string.IsNullOrWhiteSpace(ServerAddress))
            {
                ApiServerAddress = ServerAddress;
            }
            DeveloperSiteAppId = appId;
            DeveloperSiteAppSecret = appSecret;
            return app;
        }
    }
}
