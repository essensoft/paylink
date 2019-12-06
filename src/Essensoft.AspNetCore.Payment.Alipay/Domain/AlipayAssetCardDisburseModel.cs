using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetCardDisburseModel Data Structure.
    /// </summary>
    public class AlipayAssetCardDisburseModel : AlipayObject
    {
        /// <summary>
        /// 打款金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资产id,跟模板id二选一
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产平台类型卡/券
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        [JsonPropertyName("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务订单号，幂等用
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展信息  账单信息key:merchantBillInfo
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金流场景
        /// </summary>
        [JsonPropertyName("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 收款方支付宝用户id
        /// </summary>
        [JsonPropertyName("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 付款方支付宝用户id
        /// </summary>
        [JsonPropertyName("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 支付宝模板id,跟资产id二选一
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
