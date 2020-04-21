using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandBenefitConfirmResponse.
    /// </summary>
    public class AntMerchantExpandBenefitConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 权益实例ID
        /// </summary>
        [JsonPropertyName("benefit_instance_id")]
        public string BenefitInstanceId { get; set; }

        /// <summary>
        /// 返回错误相关的一些详情  比如：发奖奖品不存在
        /// </summary>
        [JsonPropertyName("detail_msg")]
        public string DetailMsg { get; set; }

        /// <summary>
        /// 权益发放失败时，参考：  发奖失败错误码 格式：端类型|错误码 例如：promocore|xxxxx，会同步到业务子错误码上
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 发奖流水号(一般为外部业务号)
        /// </summary>
        [JsonPropertyName("grant_sn")]
        public string GrantSn { get; set; }

        /// <summary>
        /// 发奖记录ID
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// SUCCESS 发放成功  FAIL 发放失败  GIVING 发放中
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
