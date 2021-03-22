using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSearchServiceorderModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenSearchServiceorderModifyModel : AlipayObject
    {
        /// <summary>
        /// 创建搜索运营申请单的入参。base_items、brand_items、service_items 分别为基础信息、品牌直达、服务直达的模块数据信息，需根据提报类型选择进行相应的设置，不能同时填写。
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
