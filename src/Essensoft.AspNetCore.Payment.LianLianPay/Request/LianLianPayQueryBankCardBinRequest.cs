using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 卡bin查询
    /// </summary>
    public class LianLianPayQueryBankCardBinRequest : ILianLianPayRequest<LianLianPayQueryBankCardBinResponse>
    {
        /// <summary>
        /// 用户银行卡卡号。
        /// 首次支付需要传入；
        /// 历次支付时，传入NoAgree则CardNo为可选参数，两者都传时，以NoAgree为准。
        /// </summary>
        public string CardNo { get; set; }

        #region ILianLianPayRequest

        public string GetRequestUrl()
        {
            return "https://queryapi.lianlianpay.com/bankcardbin.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "card_no", CardNo }
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
