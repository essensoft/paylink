using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付授权码
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 买家支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数字。
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 卡颁发机构编号
        /// </summary>
        [JsonProperty("card_org_no")]
        public string CardOrgNo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 跳回的地址
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 支付场景  条码支付，取值：bar_code  声波支付，取值：wave_code  人脸支付，取值：face_code
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }
    }
}
