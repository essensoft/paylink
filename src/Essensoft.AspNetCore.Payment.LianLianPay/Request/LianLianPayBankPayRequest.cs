using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayBankPayRequest : ILianLianPayRequest<LianLianPayBankPayResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 商户唯一订单号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户订单时间
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string NameGoods { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        public string InfoOrder { get; set; }

        /// <summary>
        /// 交易金额
        /// 单位为RMB-元
        /// </summary>
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 异步通知url
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 同步跳转url
        /// </summary>
        public string UrlReturn { get; set; }

        /// <summary>
        /// 用户端申请IP
        /// </summary>
        public string UserreqIp { get; set; }

        /// <summary>
        /// 订单地址
        /// </summary>
        public string UrlOrder { get; set; }

        /// <summary>
        /// 订单有效时间
        /// </summary>
        public string ValidOrder { get; set; }

        /// <summary>
        /// 指定银行网银编号
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 支付方式
        /// 1：网银支付（借记卡）
        /// 8：网银支付（信用卡）
        /// 9：B2B 企业网银支付
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 分账信息数据
        /// </summary>
        public string ShareingData { get; set; }

        /// <summary>
        /// 风险控制参数
        /// </summary>
        public string RiskItem { get; set; }

        #region ILianLianPayRequest

        private string Version = "1.0";

        public string GetRequestUrl()
        {
            return "https://payment.lianlianpay.com/payment/bankgateway.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "version", Version },
                { "user_id", UserId },
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "name_goods", NameGoods },
                { "info_order", InfoOrder },
                { "money_order", MoneyOrder },
                { "notify_url", NotifyUrl },
                { "url_return", UrlReturn },
                { "userreq_ip", UserreqIp?.Replace(".", "_") },
                { "url_order", UrlOrder },
                { "valid_order", ValidOrder },
                { "bank_code", BankCode },
                { "pay_type", PayType },
                { "shareing_data", ShareingData },
                { "risk_item", RiskItem },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return Version;
        }

        public void SetApiVersion(string apiVersion)
        {
            Version = apiVersion;
        }
        #endregion
    }
}
