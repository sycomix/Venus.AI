﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Venus.AI.ConsoleClient
{
    class IntentModificationRespone
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("voiceData")]
        public byte[] VoiceData { get; set; }
        [JsonProperty("intentName")]
        public string IntentName { get; set; }
    }
}
