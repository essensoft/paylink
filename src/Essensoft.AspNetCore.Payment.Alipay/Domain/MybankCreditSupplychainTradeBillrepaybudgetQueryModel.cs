using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeBillrepaybudgetQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainTradeBillrepaybudgetQueryModel : AlipayObject
    {
        /// <summary>
        /// 买家信息
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品销售码
        /// </summary>
        [JsonPropertyName("sale_pd_code")]
        public string SalePdCode { get; set; }
    }
}
