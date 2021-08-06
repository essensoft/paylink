using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BoxExclusiveServiceData Data Structure.
    /// </summary>
    public class BoxExclusiveServiceData : AlipayObject
    {
        /// <summary>
        /// 2020012321000607972103
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
    }
}
