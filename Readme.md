1、npm 配置 package.json 文件。
使用命令 npm init 创建一个新的 package.json 文件。
如图:

根据提示 执行 npm help json 命令 跳转到 npm 官网的帮助页面（本地html文件）。
如图我看到了：它 的行为受 npm-config 的影响。

于是紧跟着跳转准备参阅 npm-config。

你妹啊，不是可能比我想的多，是真的好多啊，不看了。。。有用的时候再查吧。。。

回头看 package.json 介绍 前面是命名规则建议之类的就不多提了，如果命名有问题会有提示的。
例：不能以点开头。

此例可以看出来 重复执行的 npm init 相当于修改。 
然后是一些字段的介绍。
1、main 

2、bin 设置环境变量，如果你要贡献的话需要了解一下。
比如 执行了 npm install vue@vue-cli 以后就可以在命令行调用 vue 命令了。
3、scripts 注册包各个生命周期要运行的脚本，但是我发现key是可以自定义的，比如 dist ，然后 
Npm run dist 暂时记下回头再研究。

4、config 将执行 start npm_package_config_+key，这块内容比较复杂，回头再研究。

5、dependencies  依赖。
• version Must match version exactly
• >version Must be greater than version
• >=version etc
• <version
• <=version
• ~version "Approximately equivalent to version" See semver(7)
• ^version "Compatible with version" See semver(7)
• 1.2.x 1.2.0, 1.2.1, etc., but not 1.3.0
• http://... See 'URLs as Dependencies' below
• * Matches any version
• "" (just an empty string) Same as *
• version1 - version2 Same as >=version1 <=version2.
• range1 || range2 Passes if either range1 or range2 are satisfied.
• git... See 'Git URLs as Dependencies' below
• user/repo See 'GitHub URLs' below
• tag A specific version tagged and published as tag See npm-dist-tag(1)
• path/path/path See Local Paths below

For example, these are all valid:
{ "dependencies" :
  { "foo" : "1.0.0 - 2.9999.9999"
  , "bar" : ">=1.0.2 <2.1.2"
  , "baz" : ">1.0.2 <=2.3.4"
  , "boo" : "2.0.1"
  , "qux" : "<1.0.0 || >=2.3.1 <2.4.5 || >=2.5.2 <3.0.0"
  , "asd" : "http://asdf.com/asdf.tar.gz"
  , "til" : "~1.2"
  , "elf" : "~1.2.3"
  , "two" : "2.x"
  , "thr" : "3.3.x"
  , "lat" : "latest"
  , "dyl" : "file:../dyl"
  }
}
粘过来方便查看。
6、DEFAULT VALUES 一些缺省值


现阶段需要了解这些就够了。
最后，npm 官网入门里有一节 understanding packages and modules 推荐阅读。
