﻿using Newtonsoft.Json;

namespace MoocDownloader.App.Models.MoocModels
{
    /// <summary>
    /// Response of /eds/api/v1/vod/video.
    /// </summary>
    public class VideoResponseModel
    {
        [JsonProperty("result")]
        public VideoResultModel Result { get; set; }
    }
}