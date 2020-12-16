using System;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// zhima.customer.contract.accept.create
    /// </summary>
    public class ZhimaCustomerContractAcceptCreateRequest : IAlipayRequest<ZhimaCustomerContractAcceptCreateResponse>
    {
        /// <summary>
        /// 约定应约接口
        /// </summary>
        public string BizContent { get; set; }

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

            return this.needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return this.returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return this.terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return this.terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "zhima.customer.contract.accept.create";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
