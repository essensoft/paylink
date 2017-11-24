using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MedicalHospitalDoctorInfo Data Structure.
    /// </summary>
    public class MedicalHospitalDoctorInfo : AlipayObject
    {
        /// <summary>
        /// 医生唯一标识，编码开发者生成并保证唯一
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 性别  女性：F  男性：M  未知：U
        /// </summary>
        [JsonProperty("sex")]
        public string Sex { get; set; }
    }
}
