using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInviteOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenInviteOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 商家的支付宝账号，如果调用alipay.open.invite.order.create接口时有传入支付宝账号，则这里查询签约状态时必须要传
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// isv业务系统单据编号
        /// </summary>
        [JsonPropertyName("isv_biz_id")]
        public string IsvBizId { get; set; }
    }
}
