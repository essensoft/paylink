using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.mobile.url.deviceverify.add
    /// </summary>
    public class AlipayMobileUrlDeviceverifyAddRequest : IAlipayRequest<AlipayMobileUrlDeviceverifyAddResponse>
    {
        /// <summary>
        /// 设备指纹id
        /// </summary>
        public string Apdid { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        public string Appid { get; set; }

        /// <summary>
        /// 集团统一id
        /// </summary>
        public string Hid { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 统一sdk的版本
        /// </summary>
        public string SdkVersion { get; set; }

        /// <summary>
        /// 手淘设备ID
        /// </summary>
        public string Umid { get; set; }

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
            return "alipay.mobile.url.deviceverify.add";
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
                { "apdid", Apdid },
                { "app_version", AppVersion },
                { "appid", Appid },
                { "hid", Hid },
                { "mobile", Mobile },
                { "sdk_version", SdkVersion },
                { "umid", Umid }
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
