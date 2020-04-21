using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncSettleReceivableConfirmModel Data Structure.
    /// </summary>
    public class AlipayBossFncSettleReceivableConfirmModel : AlipayObject
    {
        /// <summary>
        /// 批量应收确认请求列表
        /// </summary>
        [JsonPropertyName("receivable_confirm_order_list")]
        public List<ReceivableConfirmOrder> ReceivableConfirmOrderList { get; set; }
    }
}
