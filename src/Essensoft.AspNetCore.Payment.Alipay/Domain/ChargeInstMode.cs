using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ChargeInstMode Data Structure.
    /// </summary>
    public class ChargeInstMode : AlipayObject
    {
        /// <summary>
        /// 机构简称(英文名称)
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 机构中文名称
        /// </summary>
        [JsonPropertyName("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
