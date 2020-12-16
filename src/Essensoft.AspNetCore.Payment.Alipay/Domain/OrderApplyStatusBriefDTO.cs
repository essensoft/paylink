using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderApplyStatusBriefDTO Data Structure.
    /// </summary>
    public class OrderApplyStatusBriefDTO : AlipayObject
    {
        /// <summary>
        /// SUCCESS：开票成功 FAIL：开票失败 PROCESS：开票中 NOTEXIST：申请不存在
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 开票申请时传入订单号（支持主单号、子单号），不限是否为支付宝体内交易单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
