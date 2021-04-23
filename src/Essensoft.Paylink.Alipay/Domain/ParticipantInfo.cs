using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ParticipantInfo Data Structure.
    /// </summary>
    public class ParticipantInfo : AlipayObject
    {
        /// <summary>
        /// 参赛者常用地址
        /// </summary>
        [JsonPropertyName("contact_address")]
        public string ContactAddress { get; set; }

        /// <summary>
        /// 参赛者当前学校
        /// </summary>
        [JsonPropertyName("current_school")]
        public string CurrentSchool { get; set; }

        /// <summary>
        /// 参赛者邮箱
        /// </summary>
        [JsonPropertyName("e_mail")]
        public string EMail { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 参赛者名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参赛者照片链接
        /// </summary>
        [JsonPropertyName("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// 参赛者性别
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 参赛者联系方式
        /// </summary>
        [JsonPropertyName("tel_number")]
        public string TelNumber { get; set; }
    }
}
