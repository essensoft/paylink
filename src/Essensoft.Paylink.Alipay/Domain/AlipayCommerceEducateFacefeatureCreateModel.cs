using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureCreateModel : AlipayObject
    {
        /// <summary>
        /// 行业编码。（注：该接口为定向开放接口，使用前需要与对应的"业务产品"申请，切勿随意填写）
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 机构编号。（同：机构id/机构内标）
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// isv英文简称。（注：请不要填写中文名称）
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 唯一标识ID
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
