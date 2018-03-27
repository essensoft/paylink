using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiRoyaltyDetailInfoPojo Data Structure.
    /// </summary>
    public class OpenApiRoyaltyDetailInfoPojo : AlipayObject
    {
        /// <summary>
        /// 分账的金额，单位为元
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 分账信息中分账百分比。取值范围为大于0，少于或等于100的整数。
        /// </summary>
        [JsonProperty("amount_percentage")]
        public long AmountPercentage { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 分账收入方账户，类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        [JsonProperty("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 分账支出方账户，类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        [JsonProperty("trans_out")]
        public string TransOut { get; set; }
    }
}
