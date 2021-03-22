using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSpOperationResultQueryResponse.
    /// </summary>
    public class AlipayOpenSpOperationResultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户支付宝pid。仅间连场景，且存在绑定关系时返回值。
        /// </summary>
        [JsonPropertyName("bind_user_id")]
        public string BindUserId { get; set; }

        /// <summary>
        /// 代运营操作结果。 SUCCESS：代表成功。 PROCESS：待商家确认中。 NO_PERMISSION：表示当前商家支付宝账号无权限操作。需要提醒商家切换成发起授权时指定的支付宝账号。 NONE：表示不存在代运营绑定或授权关系。 NONE_ACCOUNT：间连商家推荐支付宝账号列表为空。
        /// </summary>
        [JsonPropertyName("handle_status")]
        public string HandleStatus { get; set; }

        /// <summary>
        /// 支付宝商户号。间连场景为商户smid，直连场景为商户支付宝pid
        /// </summary>
        [JsonPropertyName("merchant_no")]
        public string MerchantNo { get; set; }
    }
}
