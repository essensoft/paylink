using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalCreateormodifyModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 商家支付宝PID，新增商家时必填
        /// </summary>
        [JsonPropertyName("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 商家的全量资质列表，用于商家资质资质审核
        /// </summary>
        [JsonPropertyName("attachment_list")]
        public List<OuterAttachment> AttachmentList { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商家id，修改商家时必填
        /// </summary>
        [JsonPropertyName("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 二级行业ID
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 投放账户id，新增商家时必填
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
    }
}
