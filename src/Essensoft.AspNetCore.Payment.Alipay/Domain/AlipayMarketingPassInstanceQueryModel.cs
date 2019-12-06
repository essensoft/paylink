using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingPassInstanceQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingPassInstanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，必须为大于0的整数， 1表示第一页，2表示第2页；  不填则默认为1，查第1页数据。
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，必须为大于0的整数，最大值为20；  不填则默认20。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 卡券实例id，对应调卡券发放alipay.pass.instance.add接口返回的passId
        /// </summary>
        [JsonPropertyName("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// 卡券单据号，由商户发券时指定的卡券唯一凭证号。
        /// </summary>
        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 模板ID（编号）
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }

        /// <summary>
        /// 所属用户user_id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
