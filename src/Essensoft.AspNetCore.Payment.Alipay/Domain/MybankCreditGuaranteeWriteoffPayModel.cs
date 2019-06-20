using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditGuaranteeWriteoffPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditGuaranteeWriteoffPayModel : AlipayObject
    {
        /// <summary>
        /// 实际平账金额，单位分
        /// </summary>
        [JsonProperty("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 实际平账金额的币种
        /// </summary>
        [JsonProperty("actual_amount_currency")]
        public string ActualAmountCurrency { get; set; }

        /// <summary>
        /// 申请平账金额，单位分
        /// </summary>
        [JsonProperty("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 申请平账金额的币种
        /// </summary>
        [JsonProperty("apply_amount_currency")]
        public string ApplyAmountCurrency { get; set; }

        /// <summary>
        /// 还款渠道。INITIATIVE_REPAY/TRADEDRIVE_REPAY
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// AE卖家sellerLoginID
        /// </summary>
        [JsonProperty("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 会员站点：AE:速卖通，ALIPAY:支付宝，MYBANK:网商银行，TAOBAO：淘宝，B2B_CN：中文站，B2B_EN：国际站
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 销账申请单号
        /// </summary>
        [JsonProperty("writeoff_apply_no")]
        public string WriteoffApplyNo { get; set; }

        /// <summary>
        /// 销账订单列表
        /// </summary>
        [JsonProperty("writeoff_order_param_list")]
        public List<WriteoffOrderParam> WriteoffOrderParamList { get; set; }
    }
}
