using System.Collections.Generic;
using Essensoft.Paylink.Alipay.Response;
using Essensoft.Paylink.Alipay.Utility;

namespace Essensoft.Paylink.Alipay.Request
{
    /// <summary>
    /// alipay.marketing.material.image.upload
    /// </summary>
    public class AlipayMarketingMaterialImageUploadRequest : IAlipayUploadRequest<AlipayMarketingMaterialImageUploadResponse>
    {
        /// <summary>
        /// 图片的byte字节数组。图片大小限制为2M
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文件业务标识.  该字段某些场景下必选. 具体该字段在哪些场景下需要传入，会在不同的接口处进行描述。  例如：alipay.marketing.activity.ordervoucher.create接口的voucher_image字段.就清楚描述了.需要使用该接口上传图片，同时指定file_key为PROMO_VOUCHER_IMAGE
        /// </summary>
        public string FileKey { get; set; }

        #region IAlipayRequest Members

        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

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

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.marketing.material.image.upload";
        }

        public void PutOtherTextParam(string key, string value)
        {
            if (udfParams == null)
            {
                udfParams = new Dictionary<string, string>();
            }
            udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "file_key", FileKey }
            };
            if (udfParams != null)
            {
                parameters.AddAll(udfParams);
            }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            var parameters = new Dictionary<string, FileItem>
            {
                { "file_content", FileContent }
            };
            return parameters;
        }

        #endregion
    }
}
