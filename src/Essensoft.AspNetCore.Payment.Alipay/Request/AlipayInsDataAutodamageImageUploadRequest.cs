using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ins.data.autodamage.image.upload
    /// </summary>
    public class AlipayInsDataAutodamageImageUploadRequest : IAlipayUploadRequest<AlipayInsDataAutodamageImageUploadResponse>
    {
        /// <summary>
        /// 业务单号，在存储上面用于做目录管理，图片都放到该目录下
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型，比如车险图像定损对应的是“1”
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 图片二进制字节流
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图像文件名称
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 图像格式类型，目前仅支持jpg格式
        /// </summary>
        public string ImageType { get; set; }

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
            return "alipay.ins.data.autodamage.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "biz_no", BizNo },
                { "biz_type", BizType },
                { "image_name", ImageName },
                { "image_type", ImageType }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "image_content", ImageContent }
            };
            return parameters;
        }

        #endregion
    }
}
