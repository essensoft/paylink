using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSearchServiceorderModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenSearchServiceorderModifyModel : AlipayObject
    {
        /// <summary>
        /// 创建搜索运营申请单的入参
        /// </summary>
        [JsonPropertyName("biz_data")]
        public SearchOrderCreateRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：create、mod、cancel
        /// </summary>
        [JsonPropertyName("opt_type")]
        public string OptType { get; set; }
    }
}
