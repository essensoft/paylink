using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationResultQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenSpOperationResultQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 代运营操作类型。取值如下 ACCOUNT_BIND：账号绑定； OPERATION_AUTH：代运营授权。
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }
    }
}
