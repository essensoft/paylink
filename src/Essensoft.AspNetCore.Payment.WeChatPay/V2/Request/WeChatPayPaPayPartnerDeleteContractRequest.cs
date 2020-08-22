using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 微信代扣 - 申请解约 (服务商)
    /// </summary>
    public class WeChatPayPaPayPartnerDeleteContractRequest : IWeChatPayRequest<WeChatPayPaPayPartnerDeleteContractResponse>
    {
        /// <summary>
        /// 模板id
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        /// 签约协议号
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// 委托代扣协议id
        /// </summary>
        public string ContractId { get; set; }

        /// <summary>
        /// 解约备注
        /// </summary>
        public string ContractTerminationRemark { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/papay/partner/deletecontract";

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "plan_id", PlanId },
                { "contract_code", ContractCode },
                { "contract_id", ContractId },
                { "contract_termination_remark", ContractTerminationRemark },
                { "version", Version },
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
