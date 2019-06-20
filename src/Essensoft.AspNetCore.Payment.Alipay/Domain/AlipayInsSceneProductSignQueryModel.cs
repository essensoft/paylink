using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductSignQueryModel : AlipayObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 支付宝会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
