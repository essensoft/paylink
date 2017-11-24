using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MedicalHospitalInfo Data Structure.
    /// </summary>
    public class MedicalHospitalInfo : AlipayObject
    {
        /// <summary>
        /// 医院唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 医院联系电话
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
