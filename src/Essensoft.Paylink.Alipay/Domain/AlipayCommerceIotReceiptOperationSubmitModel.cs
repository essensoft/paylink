using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotReceiptOperationSubmitModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotReceiptOperationSubmitModel : AlipayObject
    {
        /// <summary>
        /// 在op_type为create的时候实体为必传字段
        /// </summary>
        [JsonPropertyName("banner_info")]
        public BannerInfo BannerInfo { get; set; }

        /// <summary>
        /// 操作类型 create  创建 banner offline 下线banner
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 直连商户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间连模式商户id
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
