using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.public.life.msg.send
    /// </summary>
    public class AlipayOpenPublicLifeMsgSendRequest : IAlipayUploadRequest<AlipayOpenPublicLifeMsgSendResponse>
    {
        /// <summary>
        /// 消息分类，请传入对应分类编码值
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 消息正文，html原文或纯文本
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 消息背景图片（目前支持格式jpg, jpeg, bmp），需上传图片原始二进制流，图片最大1MB
        /// </summary>
        public FileItem Cover { get; set; }

        /// <summary>
        /// 消息概述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 媒体资讯类生活号消息类型
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 消息来源方附属信息，供搜索、推荐使用  publish_time（int）：消息发布时间，单位秒  keyword_list（String）: 文章的标签列表，英文逗号分隔  comment（int）：消息来源处评论次数  reward（int）：消息来源处打赏次数  is_recommended（boolean）：消息在来源处是否被推荐  is_news（boolean）：消息是否实时性内容  read（int）：消息在来源处被阅读次数  like（int）：消息在来源处被点赞次数  is_hot（boolean）：消息在来源平台是否是热门内容  share（int）：文章在来源平台的分享次数  deadline（int）：文章的失效时间，单位秒
        /// </summary>
        public string SourceExtInfo { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 来源方消息唯一标识；若不为空，根据此id和生活号id对消息去重；若为空，不去重
        /// </summary>
        public string UniqueMsgId { get; set; }

        /// <summary>
        /// 生活号消息视频时长，单位：秒（视频类消息必填）
        /// </summary>
        public string VideoLength { get; set; }

        /// <summary>
        /// 视频类型消息中视频抽样关键帧截图，视频类消息选填
        /// </summary>
        public List<string> VideoSamples { get; set; }

        /// <summary>
        /// 视频大小，单位：KB（视频类消息必填）
        /// </summary>
        public string VideoSize { get; set; }

        /// <summary>
        /// 视频资源来源id（视频类消息必填），取值限定youku, miaopai, taobao, sina中的一个
        /// </summary>
        public string VideoSource { get; set; }

        /// <summary>
        /// 视频的临时链接（优酷来源的视频消息，该字段不能为空）
        /// </summary>
        public string VideoTemporaryUrl { get; set; }

        /// <summary>
        /// 生活号视频类消息视频id或url（视频类消息必填，根据来源区分）
        /// </summary>
        public string VideoUrl { get; set; }

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
            return "alipay.open.public.life.msg.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "category", Category },
                { "content", Content },
                { "desc", Desc },
                { "msg_type", MsgType },
                { "source_ext_info", SourceExtInfo },
                { "title", Title },
                { "unique_msg_id", UniqueMsgId },
                { "video_length", VideoLength },
                { "video_samples", VideoSamples },
                { "video_size", VideoSize },
                { "video_source", VideoSource },
                { "video_temporary_url", VideoTemporaryUrl },
                { "video_url", VideoUrl }
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
                { "cover", Cover }
            };
            return parameters;
        }

        #endregion
    }
}
