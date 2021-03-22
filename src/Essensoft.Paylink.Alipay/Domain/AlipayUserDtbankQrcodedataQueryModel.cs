using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserDtbankQrcodedataQueryModel Data Structure.
    /// </summary>
    public class AlipayUserDtbankQrcodedataQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询的数据日期
        /// </summary>
        [JsonPropertyName("data_date")]
        public string DataDate { get; set; }

        /// <summary>
        /// 二维码Id
        /// </summary>
        [JsonPropertyName("qrcode_id")]
        public string QrcodeId { get; set; }

        /// <summary>
        /// 二维码外部ID
        /// </summary>
        [JsonPropertyName("qrcode_out_id")]
        public string QrcodeOutId { get; set; }
    }
}
