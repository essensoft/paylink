using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserDtbankQrcodedataQueryResponse.
    /// </summary>
    public class AlipayUserDtbankQrcodedataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 引导绑卡数量
        /// </summary>
        [JsonPropertyName("bind_card")]
        public string BindCard { get; set; }

        /// <summary>
        /// 查询的数据日期
        /// </summary>
        [JsonPropertyName("data_date")]
        public string DataDate { get; set; }

        /// <summary>
        /// 引导关注数量
        /// </summary>
        [JsonPropertyName("lead_to_follow")]
        public string LeadToFollow { get; set; }

        /// <summary>
        /// 二维码Id
        /// </summary>
        [JsonPropertyName("qrcode_id")]
        public string QrcodeId { get; set; }

        /// <summary>
        /// 二维码外部Id
        /// </summary>
        [JsonPropertyName("qrcode_out_id")]
        public string QrcodeOutId { get; set; }

        /// <summary>
        /// 发券金额
        /// </summary>
        [JsonPropertyName("send_voucher_amt")]
        public string SendVoucherAmt { get; set; }

        /// <summary>
        /// 发券数量
        /// </summary>
        [JsonPropertyName("send_voucher_cnt")]
        public string SendVoucherCnt { get; set; }

        /// <summary>
        /// 核销券金额
        /// </summary>
        [JsonPropertyName("write_off_voucher_amt")]
        public string WriteOffVoucherAmt { get; set; }

        /// <summary>
        /// 核销券数量
        /// </summary>
        [JsonPropertyName("write_off_voucher_cnt")]
        public string WriteOffVoucherCnt { get; set; }
    }
}
