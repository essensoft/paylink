using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoCancelModel Data Structure.
    /// </summary>
    public class KoubeiCateringOrderInfoCancelModel : AlipayObject
    {
        /// <summary>
        /// 关单时间,格式yyyy-mm-dd
        /// </summary>
        [JsonPropertyName("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonPropertyName("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
