using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSpOperationQrcodeQueryResponse.
    /// </summary>
    public class AlipayOpenSpOperationQrcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 商家已经绑定的支付宝账号信息
        /// </summary>
        [JsonPropertyName("bind_account")]
        public RecommendAccountDTO BindAccount { get; set; }

        /// <summary>
        /// 二维码图片地址，urlEncode处理过。 注意： 1.有效期为24h; 2.用户扫码确认授权操作（同意/拒绝）后，支付宝将通过<a href="https://opendocs.alipay.com/apis/01lc2d">alipay.open.sp.operation.result.notify</a>接口发送异步通知给服务商。
        /// </summary>
        [JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 只针对服务商代间连商家发起代运营绑定、授权时，这个字段会返回推荐的商家支付宝账号列表，包括：支付宝账号和名称，为保护商家信息，账号和名称都按照规范脱敏。
        /// </summary>
        [JsonPropertyName("recommend_accounts")]
        public RecommendAccountDTO RecommendAccounts { get; set; }
    }
}
