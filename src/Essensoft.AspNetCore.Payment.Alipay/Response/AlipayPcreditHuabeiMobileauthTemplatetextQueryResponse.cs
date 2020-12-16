using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthTemplatetextQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthTemplatetextQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditRpcBaseResult<MemberTemplate>
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
