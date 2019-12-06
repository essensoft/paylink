using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// JfExportChargeInstModel Data Structure.
    /// </summary>
    public class JfExportChargeInstModel : AlipayObject
    {
        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [JsonPropertyName("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 出账机构所在城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 出账机构所在省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
