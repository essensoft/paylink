using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeUserOrderConsultResponse.
    /// </summary>
    public class ZhimaCreditPeUserOrderConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 实际可免押额度，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 展示给C看的文案，json格式字符串
        /// </summary>
        [JsonPropertyName("display_msg")]
        public string DisplayMsg { get; set; }

        /// <summary>
        /// 在该信用场景下是否已签约
        /// </summary>
        [JsonPropertyName("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 用户在该场景下能否享用免押，返回true：可享受免押，返回false：不可享受免押
        /// </summary>
        [JsonPropertyName("permit")]
        public bool Permit { get; set; }

        /// <summary>
        /// 拒绝码，只有当permit为false时，才有值
        /// </summary>
        [JsonPropertyName("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因描述，只有在permit=false时，才会返回该信息
        /// </summary>
        [JsonPropertyName("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 芝麻咨询单号，业务处理成功后，芝麻返回该字段，实际使用时请注意保存该字段
        /// </summary>
        [JsonPropertyName("risk_order_no")]
        public string RiskOrderNo { get; set; }

        /// <summary>
        /// 盖帽额度，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("top_amount")]
        public string TopAmount { get; set; }

        /// <summary>
        /// 可免押盖帽物品件数
        /// </summary>
        [JsonPropertyName("top_goods_count")]
        public long TopGoodsCount { get; set; }
    }
}
