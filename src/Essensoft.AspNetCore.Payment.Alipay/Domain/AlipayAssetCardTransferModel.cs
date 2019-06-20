using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetCardTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetCardTransferModel : AlipayObject
    {
        /// <summary>
        /// 转移金额，单位元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 模板实例，资产id
        /// </summary>
        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产平台类型卡/券
        /// </summary>
        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonProperty("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务订单号，幂等字段
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金流场景
        /// </summary>
        [JsonProperty("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 接收方支付宝用户id
        /// </summary>
        [JsonProperty("receive_user_id")]
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
