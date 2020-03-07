using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneSellerDataQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneSellerDataQueryModel : AlipayObject
    {
        /// <summary>
        /// 目标服务名称
        /// </summary>
        [JsonPropertyName("dx_name")]
        public string DxName { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extra_data")]
        public string ExtraData { get; set; }

        /// <summary>
        /// 机构产品号
        /// </summary>
        [JsonPropertyName("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 标准产品号
        /// </summary>
        [JsonPropertyName("sp_no")]
        public string SpNo { get; set; }
    }
}
