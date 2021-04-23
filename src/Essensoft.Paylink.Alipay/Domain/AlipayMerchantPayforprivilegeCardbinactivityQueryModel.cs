using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantPayforprivilegeCardbinactivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 卡bin规则的外部活动唯一编号，联合对应商家的pid作为唯一键
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
