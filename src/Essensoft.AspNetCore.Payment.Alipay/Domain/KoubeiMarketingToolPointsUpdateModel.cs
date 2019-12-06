using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingToolPointsUpdateModel Data Structure.
    /// </summary>
    public class KoubeiMarketingToolPointsUpdateModel : AlipayObject
    {
        /// <summary>
        /// 活动集点帐户ID, 开发者通过查询集点活动详情获取
        /// </summary>
        [JsonPropertyName("activity_account")]
        public string ActivityAccount { get; set; }

        /// <summary>
        /// 业务流水号，集点交易类型为  DEPOSIT, 传入支付交易号;  CANCEL／COMMIT, 传入冻结集点的集点流水号;  CONSUME／FREEZE, 不允许传入biz_no;
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部流水号, 由开发者提供, 用于控制业务幂等
        /// </summary>
        [JsonPropertyName("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 门店ID，集点交易类型为DEPOSIT时填写
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 集点交易数量，必须为正整数字符串
        /// </summary>
        [JsonPropertyName("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 集点交易类型，目前支持:  DEPOSIT，增加集点  FREEZE，冻结集点  COMMIT，提交冻结集点  CANCEL，取消冻结集点  CONSUME, 消费集点
        /// </summary>
        [JsonPropertyName("trans_type")]
        public string TransType { get; set; }

        /// <summary>
        /// 用户ID, 开发者通过用户信息授权产品获取
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
