using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCooklistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCooklistQueryModel : AlipayObject
    {
        /// <summary>
        /// 菜谱业务类型
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
