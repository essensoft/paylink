using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceMedicalCardQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付授权码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 买家支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数字。
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 卡颁发机构编号
        /// </summary>
        [JsonPropertyName("card_org_no")]
        public string CardOrgNo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 机构类型：医保(YB),人社(RS) 默认为RS
        /// </summary>
        [JsonPropertyName("ins_type")]
        public string InsType { get; set; }

        /// <summary>
        /// 跳回的地址
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 支付场景  条码支付，取值：bar_code  声波支付，取值：wave_code  人脸支付，取值：face_code
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("version_no")]
        public string VersionNo { get; set; }
    }
}
