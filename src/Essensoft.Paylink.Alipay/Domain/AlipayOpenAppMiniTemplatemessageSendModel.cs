using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMiniTemplatemessageSendModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMiniTemplatemessageSendModel : AlipayObject
    {
        /// <summary>
        /// 模板消息内容。商家/开发者将模板占位符替换为自定义内容。 注意： * 选用模板时配置的关键字顺序与keyword_ X相互对应，填写时需注意。 * 自定义消息内容仅需替换 value 后内容即可，其余内容请勿修改。如 {"keyword1": {"value" : "2021年01月"}。表示第一个关键字数据为"2021年01月" 。
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// *支付消息模板：需传入用户发生的交易行为的支付宝交易号 trade_no； *表单提交模板：需传入用户在小程序触发表单提交事件获得的表单号； *刷脸消息模板：需传入在IOT刷脸后得到的ftoken等，用于信息发送的校验。 说明：订阅消息模板无需传入本参数。
        /// </summary>
        [JsonPropertyName("form_id")]
        public string FormId { get; set; }

        /// <summary>
        /// 小程序的跳转页面。用于用户点击模板消息 进入小程序查看 按钮后，跳转至商家小程序对应页面。
        /// </summary>
        [JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>
        /// 接收模板消息的用户 user_id，一般为2088开头的16为数字。 注意：需为实际支付/提交表单/刷脸/订阅消息的用户。
        /// </summary>
        [JsonPropertyName("to_user_id")]
        public string ToUserId { get; set; }

        /// <summary>
        /// 商家在商家自运营中心选用的消息模板ID，详情参见 <a href="https://opendocs.alipay.com/mini/01rnqx#%E9%80%89%E7%94%A8%E6%B6%88%E6%81%AF%E6%A8%A1%E6%9D%BF">选用消息模板</a> 。
        /// </summary>
        [JsonPropertyName("user_template_id")]
        public string UserTemplateId { get; set; }
    }
}
