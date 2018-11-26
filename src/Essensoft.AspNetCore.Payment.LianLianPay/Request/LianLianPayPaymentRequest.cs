using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 付款申请
    /// </summary>
    public class LianLianPayPaymentRequest : ILianLianPayRequest<LianLianPayPaymentResponse>
    {
        /// <summary>
        /// 平台来源标识。
        /// 定义用户来源，可以使多个商户号共享一套用户信息，使用前请联系连连技术支持部以确定您的商户号是否满足相关配置条件。
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 商户订单号。
        /// 为商户系统内对订单的唯一编号，保证唯一。
        /// 连连会根据 NoOrder 创建连连订单号 OidPaybill，如NoOrder已有对应连连订单号 OidPaybill，则将请求视为重复订单请求。
        /// 重复发起订单请求时，请求中的参数信息需与原创单时一致。
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户订单时间。
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 交易金额。
        /// 请求no_order对应的订单总金额，单位为元，精确到小数点后两位，小数点计入字符长度。
        /// 取值范围为 0.01 ~ 99999999。
        /// </summary>
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 收款方银行账号。
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 收款人姓名。
        /// </summary>
        public string AcctName { get; set; }

        /// <summary>
        /// 收款银行名称。
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 订单描述。
        /// 说明付款用途。
        /// </summary>
        public string InfoOrder { get; set; }

        /// <summary>
        /// 对公对私标志。
        /// 0 - 对私。
        /// 1 - 对公。
        /// </summary>
        public string FlagCard { get; set; }

        /// <summary>
        /// 收款备注。
        /// 传递至银行，一般作为订单摘要展示。
        /// 特殊字符会被过滤，单个字符过滤的正则表达式为[^a-zA-Z0-9\\u4e00-\\u9fa5-_]。
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 大额行号。
        /// 可调用大额行号查询接口进行查询。
        /// 对公字段，FlagCard为1时，必须选择大额行号 + 银行编码或开户支行名称 + 开户行所在市编码 + 银行编码中的一组传入。
        /// 若传入大额行号，则CityCode 与BrabankName可以不传。
        /// </summary>
        public string Prcptcd { get; set; }

        /// <summary>
        /// 银行编码。
        /// FlagCard为1时，必须选择大额行号+银行编码或开户支行名称+开户行所在市编码+银行编码中的一组传入。
        /// 可调用卡bin查询API进行查询。
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 开户行所在省市编码，标准地市编码。
        /// 对公字段，FlagCard为1时，必须选择大额行号 + 银行编码或开户支行名称 + 开户行所在市编码 + 银行编码中的一组传入。
        /// 本字段与BrabankName配合使用；若传入Prcptcd，则CityCode 与BrabankName可以不传。
        /// 可参考省市编码表。
        /// </summary>
        public string CityCode { get; set; }

        /// <summary>
        /// 开户支行名称。
        /// 对公字段，FlagCard为1时，必须选择大额行号+银行编码或开户支行名称+开户行所在市编码+银行编码中的一组传入。
        /// 本字段与CityCode配合使用；若传入Prcptcd，则CityCode 与BrabankName可以不传。
        /// </summary>
        public string BrabankName { get; set; }

        /// <summary>
        /// 接收异步通知的线上地址。
        /// 连连支付支付平台在商户打款成功后通知商户服务端的地址。
        /// </summary>
        public string NotifyUrl { get; set; }

        #region ILianLianPayRequest

        private string ApiVersion = "1.0";

        public string GetRequestUrl()
        {
            return "https://instantpay.lianlianpay.com/paymentapi/payment.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "api_version", ApiVersion },
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "money_order", MoneyOrder },
                { "card_no", CardNo },
                { "acct_name", AcctName },
                { "bank_name", BankName },
                { "info_order", InfoOrder },
                { "flag_card", FlagCard },
                { "memo", Memo },
                { "prcptcd", Prcptcd },
                { "bank_code", BankCode },
                { "city_code", CityCode },
                { "brabank_name", BrabankName },
                { "notify_url", NotifyUrl }
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        #endregion
    }
}
