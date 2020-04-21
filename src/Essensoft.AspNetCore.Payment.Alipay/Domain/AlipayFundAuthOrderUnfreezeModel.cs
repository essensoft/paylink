using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundAuthOrderUnfreezeModel Data Structure.
    /// </summary>
    public class AlipayFundAuthOrderUnfreezeModel : AlipayObject
    {
        /// <summary>
        /// 本次操作解冻的金额，单位为：元（人民币），精确到小数点后两位，取值范围：[0.01,100000000.00]
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资金授权订单号
        /// </summary>
        [JsonPropertyName("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 解冻扩展信息，json格式；unfreezeBizInfo 目前为芝麻消费字段，支持Key值如下：  "bizComplete":"true" -- 选填：标识本次解冻用户是否履约，如果true信用单会完结为COMPLETE
        /// </summary>
        [JsonPropertyName("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 商户本次资金操作的请求流水号，同一商户每次不同的资金操作请求，商户请求流水号不能重复
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户对本次解冻操作的附言描述
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
