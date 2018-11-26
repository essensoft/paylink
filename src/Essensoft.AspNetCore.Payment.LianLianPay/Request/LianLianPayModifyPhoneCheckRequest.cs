using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayModifyPhoneCheckRequest : ILianLianPayRequest<LianLianPayModifyPhoneCheckResponse>
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
        /// 授权码
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        public string VerifyCode { get; set; }

        #region ILianLianPayRequest

        public string GetRequestUrl()
        {
            return "https://traderapi.lianlianpay.com/modifyphonecheck.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "user_id", UserId },
                { "token", Token },
                { "verify_code", VerifyCode }
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
