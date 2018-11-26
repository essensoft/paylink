using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthContractMerchantSignModel : AlipayObject
    {
        /// <summary>
        /// 商家银行账号
        /// </summary>
        [JsonProperty("account_no")]
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// json串格式的扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 费率模型
        /// </summary>
        [JsonProperty("fee_value")]
        [XmlElement("fee_value")]
        public FeeValue FeeValue { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonProperty("inst_id")]
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("scene_code")]
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 生效失效策略模型
        /// </summary>
        [JsonProperty("valid_strategy")]
        [XmlElement("valid_strategy")]
        public ValidStrategy ValidStrategy { get; set; }
    }
}
