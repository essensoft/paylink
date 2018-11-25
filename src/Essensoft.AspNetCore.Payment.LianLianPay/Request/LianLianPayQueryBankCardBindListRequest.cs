using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 用户签约银行卡列表查询
    /// </summary>
    public class LianLianPayQueryBankCardBindListRequest : ILianLianPayRequest<LianLianPayQueryBankCardBindListResponse>
    {
        /// <summary>
        /// 用户编号。
        /// 商户系统内对用户的唯一编码，可以为自定义字符串，加密密文或者邮箱等可以唯一定义用户的标识。
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 台来源标识。
        /// 定义用户来源，可以使多个商户号共享一套用户信息，使用前请联系连连技术支持部以确定您的商户号是否满足相关配置条件。
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 签约协议号所属收款产品，不传则默认为快捷收款。
        /// 2 - 快捷收款。
        /// D - 认证收款。
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 签约协议编号。
        /// 签约规则及详情见签约说明。
        /// </summary>
        public string NoAgree { get; set; }

        /// <summary>
        /// 用户银行卡卡号。
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 查询偏移量，传0即可。
        /// </summary>
        public string Offset { get; set; }

        #region ILianLianPayRequest

        public string GetRequestUrl()
        {
            return "https://queryapi.lianlianpay.com/bankcardbindlist.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "user_id", UserId },
                { "platform", Platform },
                { "pay_type", PayType },
                { "no_agree", NoAgree },
                { "card_no", CardNo },
                { "offset", Offset }
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
