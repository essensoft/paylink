using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFlashsalesStockSyncUpdateResponse.
    /// </summary>
    public class AlipayFlashsalesStockSyncUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 成功时返回的业务参数信息。
        /// </summary>
        [JsonProperty("biz_result")]
        [XmlElement("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 当更新库存不成功时，错误码
        /// </summary>
        [JsonProperty("error_code")]
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
