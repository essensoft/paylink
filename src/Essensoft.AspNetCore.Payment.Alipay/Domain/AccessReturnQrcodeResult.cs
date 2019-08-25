using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessReturnQrcodeResult Data Structure.
    /// </summary>
    [Serializable]
    public class AccessReturnQrcodeResult : AlipayObject
    {
        /// <summary>
        /// 采购单ID
        /// </summary>
        [JsonProperty("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 外部单号（调用方业务主键）
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 二维码token值
        /// </summary>
        [JsonProperty("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 处理结果（成功或失败）
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
