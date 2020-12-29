using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSearchOpenstatusModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenSearchOpenstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改运营服务的上下架请求入参
        /// </summary>
        [JsonPropertyName("biz_data")]
        public SearchOpenStatusRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：mod
        /// </summary>
        [JsonPropertyName("opt_type")]
        public string OptType { get; set; }
    }
}
