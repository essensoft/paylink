using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointSendResponse.
    /// </summary>
    public class AntfortuneEquityInstpointSendResponse : AlipayResponse
    {
        /// <summary>
        /// 积分发放流水，发放结果为true时，流水号可唯一索引本次发放记录
        /// </summary>
        [JsonPropertyName("point_trans_no")]
        public string PointTransNo { get; set; }

        /// <summary>
        /// 积分发放结果，true：成功；false：失败
        /// </summary>
        [JsonPropertyName("send_result")]
        public bool SendResult { get; set; }
    }
}
