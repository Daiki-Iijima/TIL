# エラーコード

```bash
mbp:~ iijimadaiki$ sudo gem install gtk3
Building native extensions.  This could take a while...
ERROR:  Error installing gtk3:
	ERROR: Failed to build gem native extension.

    current directory: /Library/Ruby/Gems/2.3.0/gems/glib2-3.3.6/ext/glib2
/System/Library/Frameworks/Ruby.framework/Versions/2.3/usr/bin/ruby -r ./siteconf20190811-18319-2wz3oo.rb extconf.rb
checking for --enable-debug-build option... no
checking for -Wall option to compiler... yes
checking for -Waggregate-return option to compiler... yes
checking for -Wcast-align option to compiler... yes
checking for -Wextra option to compiler... yes
checking for -Wformat=2 option to compiler... yes
checking for -Winit-self option to compiler... yes
checking for -Wlarger-than-65500 option to compiler... yes
checking for -Wmissing-declarations option to compiler... yes
checking for -Wmissing-format-attribute option to compiler... yes
checking for -Wmissing-include-dirs option to compiler... yes
checking for -Wmissing-noreturn option to compiler... yes
checking for -Wmissing-prototypes option to compiler... yes
checking for -Wnested-externs option to compiler... yes
checking for -Wold-style-definition option to compiler... yes
checking for -Wpacked option to compiler... yes
checking for -Wp,-D_FORTIFY_SOURCE=2 option to compiler... yes
checking for -Wpointer-arith option to compiler... yes
checking for -Wswitch-default option to compiler... yes
checking for -Wswitch-enum option to compiler... yes
checking for -Wundef option to compiler... yes
checking for -Wout-of-line-declaration option to compiler... yes
checking for -Wunsafe-loop-optimizations option to compiler... no
checking for -Wwrite-strings option to compiler... yes
checking for Homebrew... yes
checking for gobject-2.0 version (>= 2.12.0)... no
installing 'glib' native package... failed
Failed to run 'brew install glib'.
*** extconf.rb failed ***
Could not create Makefile due to some reason, probably lack of necessary
libraries and/or headers.  Check the mkmf.log file for more details.  You may
need configuration options.

Provided configuration options:
	--with-opt-dir
	--without-opt-dir
	--with-opt-include
	--without-opt-include=${opt-dir}/include
	--with-opt-lib
	--without-opt-lib=${opt-dir}/lib
	--with-make-prog
	--without-make-prog
	--srcdir=.
	--curdir
	--ruby=/System/Library/Frameworks/Ruby.framework/Versions/2.3/usr/bin/$(RUBY_BASE_NAME)
	--enable-debug-build
	--disable-debug-build
	--with-pkg-config
	--without-pkg-config
	--with-override-variables
	--without-override-variables

To see why this extension failed to compile, please check the mkmf.log which can be found here:

  /Library/Ruby/Gems/2.3.0/extensions/universal-darwin-18/2.3.0/glib2-3.3.6/mkmf.log

extconf failed, exit code 1

Gem files will remain installed in /Library/Ruby/Gems/2.3.0/gems/glib2-3.3.6 for inspection.
Results logged to /Library/Ruby/Gems/2.3.0/extensions/universal-darwin-18/2.3.0/glib2-3.3.6/gem_make.out
```

# 試したこと

## brew update
- 一旦、今出ている部分では止まらなくなった

## MacデフォルトのRubyだとダメ説
- 検証↓
    - https://blog.kawa-xxx.jp/entry/20101214/1292310727