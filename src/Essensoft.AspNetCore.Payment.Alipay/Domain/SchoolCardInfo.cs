using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SchoolCardInfo Data Structure.
    /// </summary>
    public class SchoolCardInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝校园卡卡号
        /// </summary>
        [JsonPropertyName("alipay_card_no")]
        public string AlipayCardNo { get; set; }

        /// <summary>
        /// 认证类型， 1:官方校园卡；2:一卡通
        /// </summary>
        [JsonPropertyName("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [JsonPropertyName("campus_no")]
        public string CampusNo { get; set; }

        /// <summary>
        /// 支付宝校园卡类型，1:学生卡；2.教工卡
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 创建时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 展示码类型， 0:在线码；1:离线码
        /// </summary>
        [JsonPropertyName("display_code_type")]
        public string DisplayCodeType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 一卡通实体卡号
        /// </summary>
        [JsonPropertyName("physical_card_number")]
        public string PhysicalCardNumber { get; set; }

        /// <summary>
        /// 支付宝学校编码
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校标识码
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// isv分配的学生短码
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; }

        /// <summary>
        /// 支付宝校园卡状态，0:有效，1:无效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
