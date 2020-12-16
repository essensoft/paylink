using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAntdaoMypointsPublishResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAntdaoMypointsPublishResponse : AlipayResponse
    {
        /// <summary>
        /// 集分宝卡密短链
        /// </summary>
        [JsonPropertyName("card_url")]
        public string CardUrl { get; set; }

        /// <summary>
        /// 额外备注信息，非json形式
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 总费用
        /// </summary>
        [JsonPropertyName("total_ccost")]
        public long TotalCcost { get; set; }
    }
}
