using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataSendBusinessResult Data Structure.
    /// </summary>
    public class DataSendBusinessResult : AlipayObject
    {
        /// <summary>
        /// 数据发送业务处理结果码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 数据发送业务处理结果描述
        /// </summary>
        [JsonPropertyName("biz_msg")]
        public string BizMsg { get; set; }
    }
}
