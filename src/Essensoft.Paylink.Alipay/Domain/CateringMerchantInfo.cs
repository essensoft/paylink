using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CateringMerchantInfo Data Structure.
    /// </summary>
    public class CateringMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 商家logo（上传logo图片返回的material_key）。平台小程序必填；模板或自研小程序选填，不填官方会取小程序Logo 请使用此文档集的图片上传接口上传获取的ID （alipay.merchant.item.file.upload）
        /// </summary>
        [JsonPropertyName("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 品牌在支付宝商家平台的PID。除排队场景外，PID/SMID必填一个。
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 品牌在支付宝商家平台的入驻得到的sub_merchant_id，受理商户唯一标识。除排队场景外，PID/SMID必填一个。
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
