using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosOrderKey Data Structure.
    /// </summary>
    public class PosOrderKey : AlipayObject
    {
        /// <summary>
        /// pos设备序列号
        /// </summary>
        [JsonPropertyName("dv_sn")]
        public string DvSn { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 订单版本号
        /// </summary>
        [JsonPropertyName("order_version")]
        public long OrderVersion { get; set; }

        /// <summary>
        /// pos本地的订单号,同一个商户下唯一标识一笔订单的编号。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
