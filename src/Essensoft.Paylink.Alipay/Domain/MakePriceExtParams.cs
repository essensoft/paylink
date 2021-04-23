using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MakePriceExtParams Data Structure.
    /// </summary>
    public class MakePriceExtParams : AlipayObject
    {
        /// <summary>
        /// 外部扩展特征,用于传入商家侧用户特征,如商家侧用户的会员等级,用户手机型号等
        /// </summary>
        [JsonPropertyName("ext_feature")]
        public string ExtFeature { get; set; }

        /// <summary>
        /// 外部扩展参数,用于商家侧定义传入一些系统控制参数,如此次请求是否可在定价区间外出价
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }
    }
}
