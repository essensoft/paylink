using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyModel Data Structure.
    /// </summary>
    public class AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 银行的标准缩写，大写。例如工行为ICBC、农行为ABC
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 规则中配置的银行卡卡bin。目前限制长度是6~8
        /// </summary>
        [JsonPropertyName("card_bin")]
        public string CardBin { get; set; }

        /// <summary>
        /// 卡bin规则的外部活动唯一编号，联合对应商家的pid作为唯一键
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
