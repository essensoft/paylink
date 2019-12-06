using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtendParams Data Structure.
    /// </summary>
    public class ExtendParams : AlipayObject
    {
        /// <summary>
        /// 卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 使用花呗分期要进行的分期数
        /// </summary>
        [JsonPropertyName("hb_fq_num")]
        public string HbFqNum { get; set; }

        /// <summary>
        /// 使用花呗分期需要卖家承担的手续费比例的百分值，传入100代表100%
        /// </summary>
        [JsonPropertyName("hb_fq_seller_percent")]
        public string HbFqSellerPercent { get; set; }

        /// <summary>
        /// 行业数据回流信息, 详见：地铁支付接口参数补充说明
        /// </summary>
        [JsonPropertyName("industry_reflux_info")]
        public string IndustryRefluxInfo { get; set; }

        /// <summary>
        /// 系统商编号  该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [JsonPropertyName("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
