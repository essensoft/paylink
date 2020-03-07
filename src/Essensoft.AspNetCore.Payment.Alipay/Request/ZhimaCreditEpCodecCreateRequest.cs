using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// zhima.credit.ep.codec.create
    /// </summary>
    public class ZhimaCreditEpCodecCreateRequest : IAlipayUploadRequest<ZhimaCreditEpCodecCreateResponse>
    {
        /// <summary>
        /// 商户端保持自有渠道id所对应商户的唯一性
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 支持中文名，最长50个字符
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// 主图背景图二进制数据
        /// </summary>
        public FileItem ContentImg { get; set; }

        /// <summary>
        /// 跳转页URL
        /// </summary>
        public string GotoUrl { get; set; }

        /// <summary>
        /// logo图片二进制数据
        /// </summary>
        public FileItem LogoImg { get; set; }

        /// <summary>
        /// 推广子文案
        /// </summary>
        public string Subtitle { get; set; }

        /// <summary>
        /// 推广主文案，限20个中文字符以内
        /// </summary>
        public string Title { get; set; }

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
            return "zhima.credit.ep.codec.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "channel_id", ChannelId },
                { "channel_name", ChannelName },
                { "goto_url", GotoUrl },
                { "subtitle", Subtitle },
                { "title", Title }
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
                { "content_img", ContentImg },
                { "logo_img", LogoImg }
            };
            return parameters;
        }

        #endregion
    }
}
