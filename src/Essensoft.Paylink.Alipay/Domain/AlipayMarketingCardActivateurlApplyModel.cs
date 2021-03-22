using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardActivateurlApplyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardActivateurlApplyModel : AlipayObject
    {
        /// <summary>
        /// 会员卡开卡表单提交后回调地址。 说明： 1.该地址不可带参数，如需回传参数，可设置out_string入参。 2.小程序应用无需传入。
        /// </summary>
        [JsonPropertyName("callback")]
        public string Callback { get; set; }

        /// <summary>
        /// 需要关注的生活号AppId。若需要在领卡页面展示“关注生活号”提示，需开通生活号并绑定会员卡。生活号快速接入详见：https://doc.open.alipay.com/docs/doc.htm?treeId=193&articleId=105933&docType=1
        /// </summary>
        [JsonPropertyName("follow_app_id")]
        public string FollowAppId { get; set; }

        /// <summary>
        /// 扩展信息，会员领卡完成后将此参数原样带回商户页面。
        /// </summary>
        [JsonPropertyName("out_string")]
        public string OutString { get; set; }

        /// <summary>
        /// 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
