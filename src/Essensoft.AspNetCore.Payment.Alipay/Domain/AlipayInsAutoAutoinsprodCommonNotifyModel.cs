using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodCommonNotifyModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodCommonNotifyModel : AlipayObject
    {
        /// <summary>
        /// 业务内容 具体内容按照业务类型对应的key值传输
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// AUTO_LEADS_STATUS_SYNC：新电焊名单状态同步服务
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }
    }
}
