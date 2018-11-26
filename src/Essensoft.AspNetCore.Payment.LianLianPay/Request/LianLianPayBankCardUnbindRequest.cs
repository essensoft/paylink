using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 银行卡解约
    /// </summary>
    public class LianLianPayBankCardUnbindRequest : ILianLianPayRequest<LianLianPayBankCardUnbindResponse>
    {
        /// <summary>
        /// 用户编号。
        /// 商户系统内对用户的唯一编码，可以为自定义字符串，加密密文或者邮箱等可以唯一定义用户的标识。
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 平台来源标识。
        /// 定义用户来源，可以使多个商户号共享一套用户信息，使用前请联系连连技术支持部以确定您的商户号是否满足相关配置条件。
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 协议号所属支付方式。
        /// 2，快捷支付。
        /// D，认证支付。
        /// 不传默认为2。
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 签约协议编号。
        /// 可调用签约查询API获取。
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
                { "no_agree", NoAgree }
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            throw new NotImplementedException();
        }

        public void SetApiVersion(string apiVersion)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
