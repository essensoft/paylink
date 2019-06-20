using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishGroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishGroupQueryModel : AlipayObject
    {
        /// <summary>
        /// 项目组id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
