<h3>官方文档/帮助：</h3>
<p>支付宝：<a href="https://openhome.alipay.com/developmentDocument.htm" target="_blank">文档中心</a>、<a href="https://open.alipay.com/support/supportCenter.htm" target="_blank">技术支持中心</a>、<a href="https://openclub.alipay.com/index.php" target="_blank">开发者社区</a></p>
<p>微信支付：<a href="https://pay.weixin.qq.com/wiki/doc/api/index.html" target="_blank">开发文档</a>、<a href="http://wxpay.wxutil.com/qa/index.php" target="_blank">问答中心</a>、<a href="http://kf.qq.com/product/wechatpaymentmerchant.html" target="_blank">帮助中心</a></p>
<p>QQ钱包：<a href="https://qpay.qq.com/qpaywiki.shtml" target="_blank">开发文档</a>、<a href="http://kf.qq.com/product/qq_enterprise.html" target="_blank">帮助中心</a></p>
<p>京东支付：<a href="http://payapi.jd.com/" target="_blank">开发文档</a></p>
<p>QQ交流群：<a target="_blank" href="//shang.qq.com/wpa/qunwpa?idkey=aac56c8f02f54893267d3ac90787c1794a7687f3c31a923812a36b67c4ee6271">522457525(.Net Core Payment)</a></p>
<h3>*添加依赖注入：</h3>
<p>
    services.AddAlipay();<br />
    services.AddWeChatPay();<br />
    services.AddQPay();<br />
    services.AddJdPay();
</p>
<h3>*注册绑定配置(参数配置3)：</h3>
<p>
    services.Configure<AlipayOptions>(Configuration.GetSection("Alipay"));<br />
    services.Configure<WeChatPayOptions>(Configuration.GetSection("WeChatPay"));<br />
    services.Configure<QPayOptions>(Configuration.GetSection("QPay"));<br />
    services.Configure<JdPayOptions>(Configuration.GetSection("JdPay"));
</p>
<h3>*参数配置方式(3选1,推荐使用3)：</h3>
<p>1.使用代码配置如：services.AddAlipay(Options => { Options.AppId = ""; });</p>
<p>2.使用<a href="https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/configuration?tabs=basicconfiguration" target="_blank">"配置文件"</a>的方式，可在appsetting.json、appsettings.Development.json设置参数</p>
<p>3.使用<a href="https://docs.microsoft.com/zh-cn/aspnet/core/security/app-secrets?tabs=visual-studio" target="_blank">"用户机密"</a>的方式，可在VS中右键项目->管理用户机密，再设置参数(与2相似)。</p>
<p>*参数详情可见Startup.cs文件的ConfigureServices方法下的注释代码"配置参数"。</p>
<p>*WeChatPay,QPay中的Certificate参数可以是文件名或者Base64字符串(将证书文件转成Base64，方便配置存储)。</p>
<h3>*注意：</h3>
<p>1.示例开发环境：Windows10、VS2017 15.4.4、.Net Core 2.0.3</p>
<p>2.支持渠道:支付宝、微信支付、QQ钱包、京东支付(仅扫码支付)。</p>
<p>3.示例使用了依赖注入与用户机密(见Startup.cs文件的ConfigureServices方法)，需要自行配置(可以参考上方"参数配置")。当然你不使用依赖注入方式，自己new AlipayClient(...,...)/new WeChatPayClient(...,...)再调用也可以。</p>
<p>4.部分API未做示例，可根据现有示例与官网API参数文档自行调用(除京东支付外其他支付的API基本齐全了)。</p>
<p>5.接收支付渠道通知(NotifyController.cs文件)需要公网环境运行(另外记得修改notify_url参数)。</p>