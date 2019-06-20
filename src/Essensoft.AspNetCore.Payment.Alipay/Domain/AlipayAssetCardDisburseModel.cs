using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetCardDisburseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetCardDisburseModel : AlipayObject
    {
        /// <summary>
        /// 打款金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资产id,跟模板id二选一
        /// </summary>
        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产平台类型卡/券
        /// </summary>
        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        [JsonProperty("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务订单号，幂等用
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展信息  账单信息key:merchantBillInfo
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金流场景
        /// </summary>
        [JsonProperty("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 收款方支付宝用户id
        /// </summary>
        [JsonProperty("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 付款方支付宝用户id
        /// </summary>
        [JsonProperty("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 支付宝模板id,跟资产id二选一
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
