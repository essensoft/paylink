using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodeDeleteModel : AlipayObject
    {
        /// <summary>
        /// 支付方式名称
        /// </summary>
        [JsonProperty("pay_name")]
        public string PayName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 是否系统（false:否；true:是）
        /// </summary>
        [JsonProperty("system")]
        public bool System { get; set; }
    }
}
