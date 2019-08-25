using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmIndirectMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmIndirectMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 收单机构ID
        /// </summary>
        [JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 代理收单机构MCC
        /// </summary>
        [JsonProperty("agent_mcc")]
        public string AgentMcc { get; set; }

        /// <summary>
        /// 代理收单机构名称
        /// </summary>
        [JsonProperty("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 商户所在的城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户所在城市简体中文名
        /// </summary>
        [JsonProperty("city_name_sc")]
        public string CityNameSc { get; set; }

        /// <summary>
        /// 间连商户ID（外标）
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 间连商户MCC
        /// </summary>
        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户类型  企业取值：ENTERPRISE  个人取值：  PERSONAL  个体工商户取值：  PERSONAL_BUSINESS
        /// </summary>
        [JsonProperty("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 间连商户名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
