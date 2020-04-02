using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcBindModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportEtcBindModifyModel : AlipayObject
    {
        /// <summary>
        /// 绑定申请协议号
        /// </summary>
        [JsonPropertyName("bind_agreement_no")]
        public string BindAgreementNo { get; set; }

        /// <summary>
        /// 用户办理ETC时预留的手机号
        /// </summary>
        [JsonPropertyName("binded_mobile")]
        public string BindedMobile { get; set; }

        /// <summary>
        /// 卡号，带省份前缀
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// OBUID，设备号
        /// </summary>
        [JsonPropertyName("device_no")]
        public string DeviceNo { get; set; }
    }
}
