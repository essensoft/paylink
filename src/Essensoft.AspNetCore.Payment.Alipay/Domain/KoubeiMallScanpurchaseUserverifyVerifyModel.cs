using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseUserverifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseUserverifyVerifyModel : AlipayObject
    {
        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [JsonProperty("verify_code")]
        public string VerifyCode { get; set; }
    }
}
