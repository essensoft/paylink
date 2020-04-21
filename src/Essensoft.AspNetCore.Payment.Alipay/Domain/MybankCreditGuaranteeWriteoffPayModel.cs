using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditGuaranteeWriteoffPayModel Data Structure.
    /// </summary>
    public class MybankCreditGuaranteeWriteoffPayModel : AlipayObject
    {
        /// <summary>
        /// 实际平账金额，单位分
        /// </summary>
        [JsonPropertyName("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 实际平账金额的币种
        /// </summary>
        [JsonPropertyName("actual_amount_currency")]
        public string ActualAmountCurrency { get; set; }

        /// <summary>
        /// 申请平账金额，单位分
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 申请平账金额的币种
        /// </summary>
        [JsonPropertyName("apply_amount_currency")]
        public string ApplyAmountCurrency { get; set; }

        /// <summary>
        /// 还款渠道。INITIATIVE_REPAY/TRADEDRIVE_REPAY
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// AE卖家sellerLoginID
        /// </summary>
        [JsonPropertyName("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 会员站点：AE:速卖通，ALIPAY:支付宝，MYBANK:网商银行，TAOBAO：淘宝，B2B_CN：中文站，B2B_EN：国际站
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 销账申请单号
        /// </summary>
        [JsonPropertyName("writeoff_apply_no")]
        public string WriteoffApplyNo { get; set; }

        /// <summary>
        /// 销账订单列表
        /// </summary>
        [JsonPropertyName("writeoff_order_param_list")]
        public List<WriteoffOrderParam> WriteoffOrderParamList { get; set; }
    }
}
