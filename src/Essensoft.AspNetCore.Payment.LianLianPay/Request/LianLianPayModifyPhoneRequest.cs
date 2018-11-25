using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayModifyPhoneRequest : ILianLianPayRequest<LianLianPayModifyPhoneResponse>
    {
        /// <summary>
        /// 平台来源
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 用户唯一编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        public string NoAgree { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 新手机号
        /// </summary>
        public string BindMob { get; set; }

        #region ILianLianPayRequest

        public string GetRequestUrl()
        {
            return "https://traderapi.lianlianpay.com/modifyphone.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "user_id", UserId },
                { "no_agree", NoAgree },
                { "pay_type", PayType },
                { "card_no", CardNo },
                { "bind_mob", BindMob },
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
