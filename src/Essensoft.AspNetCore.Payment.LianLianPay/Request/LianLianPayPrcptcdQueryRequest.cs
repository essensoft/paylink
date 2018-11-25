using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 大额行号查询
    /// </summary>
    public class LianLianPayPrcptcdQueryRequest : ILianLianPayRequest<LianLianPayPrcptcdQueryResponse>
    {
        /// <summary>
        /// 用户银行卡卡号。
        /// CardNo与BankCode 二者选一，如二者都传以BankCode为准。
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 银行编码。
        /// 可调用卡bin查询API进行查询。CardNo与BankCode 二者选一，如二者都传以BankCode为准。
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 开户支行名称，支持模糊查询。
        /// </summary>
        public string BrabankName { get; set; }

        /// <summary>
        /// 开户行所在省市编码，标准地市编码。
        /// 可参考省市编码表。
        /// </summary>
        public string CityCode { get; set; }

        #region ILianLianPayRequest

        public string GetRequestUrl()
        {
            return "https://queryapi.lianlianpay.com/prcptcdquery.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "card_no", CardNo },
                { "bank_code", BankCode },
                { "brabank_name", BrabankName },
                { "city_code", CityCode },
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
