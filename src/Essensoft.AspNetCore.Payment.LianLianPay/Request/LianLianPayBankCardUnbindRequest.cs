using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayBankCardUnbindRequest : ILianLianPayRequest<LianLianPayBankCardUnbindResponse>
    {
        /// <summary>
        /// 商户用户唯一编号
        /// 该用户在商户系统中的唯一编号，要求是该编 号在商户系统中唯一标识该用户
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 平台来源标示
        /// 该参数可实现多个商户号之间用户数据共享，平台来源标示要能有效区分属于该商户所有，例如域名
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 支付方式
        /// 2：快捷支付
        /// D：认证支付
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 签约协议号
        /// 银行卡签约的唯一编号
        /// </summary>
        public string NoAgree { get; set; }

        #region ILianLianPayRequest

        public string GetRequestUrl()
        {
            return "https://traderapi.lianlianpay.com/bankcardunbind.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "user_id", UserId },
                { "platform", Platform },
                { "pay_type", PayType },
                { "no_agree", NoAgree },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return string.Empty;
        }

        public void SetApiVersion(string apiVersion)
        {
        }

        #endregion
    }
}
