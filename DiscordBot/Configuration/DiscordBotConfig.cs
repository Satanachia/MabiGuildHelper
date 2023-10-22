﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Configuration
{
    public class DiscordBotConfig
    {
        public const string SectionName = "DiscordBot";

        public string Token { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(Token);
        }
    }
}