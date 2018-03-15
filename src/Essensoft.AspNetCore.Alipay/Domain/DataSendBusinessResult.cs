using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// DataSendBusinessResult Data Structure.
    /// </summary>
    public class DataSendBusinessResult : AlipayObject
    {
        /// <summary>
        /// 数据发送业务处理结果码
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 数据发送业务处理结果描述
        /// </summary>
        [JsonProperty("biz_msg")]
        public string BizMsg { get; set; }
    }
}
