using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoActivityRecycleSendModel Data Structure.
    /// </summary>
    public class AlipayEcoActivityRecycleSendModel : AlipayObject
    {
        /// <summary>
        /// 买家的用户id
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 清单明细
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<EnergyGoodRequest> ItemList { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务类型
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 卖家的用户id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
