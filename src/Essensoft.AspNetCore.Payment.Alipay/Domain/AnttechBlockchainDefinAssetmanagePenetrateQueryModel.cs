using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinAssetmanagePenetrateQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinAssetmanagePenetrateQueryModel : AlipayObject
    {
        /// <summary>
        /// 具体查询功能所需的业务数据JSON
        /// </summary>
        [JsonPropertyName("biz_params")]
        public string BizParams { get; set; }

        /// <summary>
        /// 业务查询所需使用的接口功能
        /// </summary>
        [JsonPropertyName("function")]
        public string Function { get; set; }

        /// <summary>
        /// 系统幂等请求id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
