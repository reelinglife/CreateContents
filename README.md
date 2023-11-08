# CreateContents
toc.ymlから目次用markdownファイルの作成  

●アプリの使用想定  
1.アプリをビルド  
2.ビルド後のexeファイルを以下の位置に配置  
Project  
├ DocFx  
├ docfx_project  
├ docfx  
├ Application  
│ └ Framework  
│   ├ XXX.md  
│   ├ yyy.md  
│   ├ **CreateContents.exe**  
│   └ toc.yml  
├ src  
(他省略)  
3.ビルド後イベントを設定  
  start $(ProjectDir)docs\Application\Framework\CreateMarkDownNonMVC.exe "$(ProjectDir)docs\Application\Framework"  

ビルド後イベントで**toc.yml**ファイルと同階層に**contents.md**ファイルが生成されます。
