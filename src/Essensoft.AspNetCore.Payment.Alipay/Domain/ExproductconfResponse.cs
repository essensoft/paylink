using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExproductconfResponse Data Structure.
    /// </summary>
    public class ExproductconfResponse : AlipayObject
    {
        /// <summary>
        /// 出账机构
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [JsonPropertyName("chargeinst_name")]
        public string ChargeinstName { get; set; }

        /// <summary>
        /// 销账机构
        /// </summary>
        [JsonPropertyName("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 销账机构中文名称
        /// </summary>
        [JsonPropertyName("chargeoffinst_name")]
        public string ChargeoffinstName { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 产品状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
