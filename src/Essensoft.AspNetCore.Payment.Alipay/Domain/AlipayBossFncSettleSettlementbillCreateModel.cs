using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCreateModel Data Structure.
    /// </summary>
    public class AlipayBossFncSettleSettlementbillCreateModel : AlipayObject
    {
        /// <summary>
        /// 结算单创建请求列表
        /// </summary>
        [JsonPropertyName("settlement_bill_create_order")]
        public List<SettlementBillCreateOrder> SettlementBillCreateOrder { get; set; }
    }
}
