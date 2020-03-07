using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessReturnQrcodeResult Data Structure.
    /// </summary>
    public class AccessReturnQrcodeResult : AlipayObject
    {
        /// <summary>
        /// 采购单ID
        /// </summary>
        [JsonPropertyName("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 外部单号（调用方业务主键）
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 二维码token值
        /// </summary>
        [JsonPropertyName("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 处理结果（成功或失败）
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
