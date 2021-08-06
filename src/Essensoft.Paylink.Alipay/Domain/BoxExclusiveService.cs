using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BoxExclusiveService Data Structure.
    /// </summary>
    public class BoxExclusiveService : AlipayObject
    {
        /// <summary>
        /// 父服务编码
        /// </summary>
        [JsonPropertyName("ref_serv_code")]
        public string RefServCode { get; set; }

        /// <summary>
        /// 父服务名称
        /// </summary>
        [JsonPropertyName("ref_serv_name")]
        public string RefServName { get; set; }

        /// <summary>
        /// 父服务类型
        /// </summary>
        [JsonPropertyName("ref_serv_type")]
        public string RefServType { get; set; }

        /// <summary>
        /// 服务类目
        /// </summary>
        [JsonPropertyName("serv_cat")]
        public string ServCat { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [JsonPropertyName("serv_code")]
        public string ServCode { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("serv_desc")]
        public string ServDesc { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("serv_id")]
        public string ServId { get; set; }

        /// <summary>
        /// 服务链接
        /// </summary>
        [JsonPropertyName("serv_link")]
        public string ServLink { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [JsonPropertyName("serv_logo")]
        public string ServLogo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("serv_name")]
        public string ServName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonPropertyName("serv_type")]
        public string ServType { get; set; }
    }
}
