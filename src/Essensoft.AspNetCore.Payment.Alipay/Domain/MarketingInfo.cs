using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MarketingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingInfo : AlipayObject
    {
        /// <summary>
        /// 营销明细
        /// </summary>
        [JsonProperty("promotion_list")]
        public List<PromotionDetail> PromotionList { get; set; }

        /// <summary>
        /// 总的营销金额，包括金本位和非金本位。该金额为所有promotion_list的金额总额。单位为元，精确到小数点后两位，取值范围[0.01,100000000]。返回promotion_list时，该字段不为空
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单营销的使用模式。该参数的值与商户入参中的制定营销use_mode一致
        /// </summary>
        [JsonProperty("use_mode")]
        public string UseMode { get; set; }
    }
}
