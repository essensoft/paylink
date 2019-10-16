using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintCodeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintCodeNotifyModel : AlipayObject
    {
        /// <summary>
        /// 授权code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 授权门店ID
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
