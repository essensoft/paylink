using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ecard.edu.public.bind
    /// </summary>
    public class AlipayEcardEduPublicBindRequest : IAlipayRequest<AlipayEcardEduPublicBindResponse>
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 公众账号协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 一卡通姓名
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 一卡通卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 公众账号id
        /// </summary>
        public string PublicId { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.ecard.edu.public.bind";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "agent_code", AgentCode },
                { "agreement_id", AgreementId },
                { "alipay_user_id", AlipayUserId },
                { "card_name", CardName },
                { "card_no", CardNo },
                { "public_id", PublicId }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
