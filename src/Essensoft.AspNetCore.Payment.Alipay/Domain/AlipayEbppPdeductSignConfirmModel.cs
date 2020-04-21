using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppPdeductSignConfirmModel Data Structure.
    /// </summary>
    public class AlipayEbppPdeductSignConfirmModel : AlipayObject
    {
        /// <summary>
        /// 机构签约代扣来源渠道 PUBLICPLATFORM：服务窗
        /// </summary>
        [JsonPropertyName("agent_channel")]
        public string AgentChannel { get; set; }

        /// <summary>
        /// 二级渠道码，预留字段
        /// </summary>
        [JsonPropertyName("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 户号签约失败原因
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 外部产生的协议ID
        /// </summary>
        [JsonPropertyName("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 商户PartnerId
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 流水号，用于跨系统追踪请求状态，无业务意义
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 签约是否成功，T:成功，F:失败
        /// </summary>
        [JsonPropertyName("sign_result")]
        public string SignResult { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
