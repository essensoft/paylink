using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SingleStartAppVO Data Structure.
    /// </summary>
    [Serializable]
    public class SingleStartAppVO : AlipayObject
    {
        /// <summary>
        /// 小程序启动协议
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// 按照标准定义的startAppModel
        /// </summary>
        [JsonProperty("start_app_model")]
        public string StartAppModel { get; set; }
    }
}
