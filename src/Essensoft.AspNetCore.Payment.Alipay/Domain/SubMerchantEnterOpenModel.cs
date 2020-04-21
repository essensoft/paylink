using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubMerchantEnterOpenModel Data Structure.
    /// </summary>
    public class SubMerchantEnterOpenModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，为json字符串格式；入驻缴费后开票的产品如果需要传入自定义开票链接，由此字段传入。
        /// </summary>
        [JsonPropertyName("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 商户行业，枚举值如下：subway：地铁，etc：ETC，online_car_hailing：网约车，catering：餐饮，hotel：酒店，convenience_store：便利店，oil：加油，insurance：保险，service_provider：运营商，life_payment：生活缴费，political：政务，other：其他
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 开票商户pid，入驻支付即开票场景的时候，该字段必传
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 商户门店税号。
        /// </summary>
        [JsonPropertyName("register_no")]
        public string RegisterNo { get; set; }

        /// <summary>
        /// 商户门店全称。
        /// </summary>
        [JsonPropertyName("sub_m_name")]
        public string SubMName { get; set; }

        /// <summary>
        /// 商户门店简称，只能由大写字母、下划线、数字组成，且必须以大写字母开头。
        /// </summary>
        [JsonPropertyName("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
