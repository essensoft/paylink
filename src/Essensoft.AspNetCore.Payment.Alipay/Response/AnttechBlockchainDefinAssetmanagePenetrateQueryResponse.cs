using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinAssetmanagePenetrateQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinAssetmanagePenetrateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 业务展示类信息
        /// </summary>
        [JsonPropertyName("error_view_msg")]
        public string ErrorViewMsg { get; set; }

        /// <summary>
        /// 业务查询返回数据JSON，一般为各类申请的状态，内容等，资产穿透类查询不返回个人信息
        /// </summary>
        [JsonPropertyName("result_obj")]
        public string ResultObj { get; set; }
    }
}
