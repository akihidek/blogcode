# TopMostWindow

【UWP アプリ】最前面に表示できるウィンドウ (Visual Studio 2017)

CompactOverlay モードを使うサンプルです。  
Windows 10 1703 (build 15063) で提供された TryEnterViewModeAsync を使っています。  

ブログ記事:  
[【#UWP】 CompactOverlay モード: Picture in Picture というか、「最前面に表示」するウィンドウを作る](http://bluewatersoft.cocolog-nifty.com/blog/2017/08/uwp-compactover.html) (2017/8/16)  

CompactOverlay モードとの切り替え処理は、 [ViewMode クラス](./TopMostWindow/ViewMode.cs) にまとめてあります。


![スクリーンキャプチャー](../images/20170816_CompactOverlayMode01.png)

  
当然だけど、 Xamarin.Forms でも実装出来ます。

![スクリーンキャプチャー](../images/20170926_TopMostWindowXamarin01.png)

