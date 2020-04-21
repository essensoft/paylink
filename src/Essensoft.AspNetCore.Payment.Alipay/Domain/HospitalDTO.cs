using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HospitalDTO Data Structure.
    /// </summary>
    public class HospitalDTO : AlipayObject
    {
        /// <summary>
        /// 医院标准名称
        /// </summary>
        [JsonPropertyName("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 医院等级，一级医院、二级医院、三级医院、其他
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 医院性质：公立医院、私立医院、其他
        /// </summary>
        [JsonPropertyName("ownership")]
        public string Ownership { get; set; }
    }
}
