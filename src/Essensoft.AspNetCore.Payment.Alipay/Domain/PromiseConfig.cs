using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromiseConfig Data Structure.
    /// </summary>
    public class PromiseConfig : AlipayObject
    {
        /// <summary>
        /// 提醒用户完成行为的守约方式，可取值：promise_link(跳转到去守约页面完成守约)；promise_remind(文字提醒守约)。
        /// </summary>
        [JsonPropertyName("action_operation_type")]
        public string ActionOperationType { get; set; }

        /// <summary>
        /// 提醒用户完成行为的守约方式的取值，值为去守约页面的url或者说明文案。
        /// </summary>
        [JsonPropertyName("action_operation_value")]
        public string ActionOperationValue { get; set; }

        /// <summary>
        /// 信用服务履约单买断按钮的url
        /// </summary>
        [JsonPropertyName("button_buy")]
        public string ButtonBuy { get; set; }

        /// <summary>
        /// 信用服务履约单提前结束按钮的url
        /// </summary>
        [JsonPropertyName("button_end")]
        public string ButtonEnd { get; set; }

        /// <summary>
        /// 信用服务履约单分期按钮的url
        /// </summary>
        [JsonPropertyName("button_installment")]
        public string ButtonInstallment { get; set; }

        /// <summary>
        /// 信用服务履约单延期按钮的url
        /// </summary>
        [JsonPropertyName("button_postpone")]
        public string ButtonPostpone { get; set; }

        /// <summary>
        /// 信用服务履约单维修按钮的url
        /// </summary>
        [JsonPropertyName("button_repair")]
        public string ButtonRepair { get; set; }

        /// <summary>
        /// 信用服务履约单换新按钮的url
        /// </summary>
        [JsonPropertyName("button_replace")]
        public string ButtonReplace { get; set; }

        /// <summary>
        /// 合约履约周期，以天为单位。
        /// </summary>
        [JsonPropertyName("fulfillment_days")]
        public long FulfillmentDays { get; set; }

        /// <summary>
        /// 商户客服电话，为必填字段，需为合法电话号码。
        /// </summary>
        [JsonPropertyName("merchant_service_phone")]
        public string MerchantServicePhone { get; set; }

        /// <summary>
        /// 商户主页链接，取值为商户小程序地址或H5页面地址。
        /// </summary>
        [JsonPropertyName("merchant_service_url")]
        public string MerchantServiceUrl { get; set; }

        /// <summary>
        /// 待还款的守约方式，可取值：promise_link(跳转到去守约页面完成守约)；promise_remind(文字提醒守约)。
        /// </summary>
        [JsonPropertyName("money_operation_type")]
        public string MoneyOperationType { get; set; }

        /// <summary>
        /// 待还款守约方式的取值，值为去守约页面的url或者说明文案。
        /// </summary>
        [JsonPropertyName("money_operation_value")]
        public string MoneyOperationValue { get; set; }

        /// <summary>
        /// 待还物的守约方式，可取值：promise_link(跳转到去守约页面完成守约)；promise_remind(文字提醒守约)。
        /// </summary>
        [JsonPropertyName("product_operation_type")]
        public string ProductOperationType { get; set; }

        /// <summary>
        /// 待还物守约方式的取值，值为去守约页面的url或者说明文案。
        /// </summary>
        [JsonPropertyName("product_operation_value")]
        public string ProductOperationValue { get; set; }
    }
}
