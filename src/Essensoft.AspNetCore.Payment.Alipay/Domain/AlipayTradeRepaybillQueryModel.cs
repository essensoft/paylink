using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillQueryModel Data Structure.
    /// </summary>
    public class AlipayTradeRepaybillQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账单号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单产品类型，标识业务用，具体值支付宝根据业务接入场景进行分配。
        /// </summary>
        [JsonPropertyName("bill_product")]
        public string BillProduct { get; set; }

        /// <summary>
        /// 外部账单号
        /// </summary>
        [JsonPropertyName("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 账单归属主体，蚂蚁统一会员id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
