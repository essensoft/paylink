using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransOrderCloseModel Data Structure.
    /// </summary>
    public class AlipayFundTransOrderCloseModel : AlipayObject
    {
        /// <summary>
        /// 描述特定的业务场景，开放网关必须要的参数，在资金这里统一识别配置
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户描述关单的原因。可以不填写
        /// </summary>
        [JsonPropertyName("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 支付宝转账单据号： 本参数和商户转账唯一订单号、支付宝支付资金流水号三者不能同时为空。 当本参数和商户转账唯一订单号、支付宝支付资金流水号三者同时提供时，将用支付宝支付资金流水号进行查询，忽略其余两者； 当本参数和支付宝支付资金流水号同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数。 当本参数和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 （注意 和 out_biz_no 不可以同时为空）
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，商户的唯一订单标示 （注意和order_id 不能同时为空）
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： STD_RED_PACKET：现金红包 TRANS_ACCOUNT_NO_PWD：单笔无密转账到支付宝账户 TRANS_BANKCARD_NO_PWD：单笔无密转账到银行卡
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
