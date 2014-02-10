MarkdownInLiveWriter
====================

This project is a markdown plugin for [Windows Live Writer](http://windows.microsoft.com/en-us/windows-live/essentials-other#essentials=overviewother). You can use this plugin to write your blog in markdown, and it provides the live preview and code syntax highlight.

## Installation

**Option 1:**

Download the [MarkdownInLiveWriter.dll](https://github.com/fresky/MarkdownInLiveWriter/raw/master/MarkdownInLiveWriter.dll), 
then put it in the [WindowsLiveWriterPath]\Plugins\.

**Option 2:**

Download the [MarkdownInLiveWriter.msi](https://github.com/fresky/MarkdownInLiveWriter/raw/master/MarkdownInLiveWriter.msi), then run the installer. 

## Usage

Please refer to the below screen shot.
![screenshot](https://raw.github.com/fresky/MarkdownInLiveWriter/master/screenshot.png "MarkdownInLiveWriter")

1. Click the **Insert** menu in Windows Live Writer, then click the **Insert Markdown**.
2. Write your blog in the left panel with Markdown, you can see the live preview in the right Panel.
3. You can also click the **source** tab to see the html source for the markdown.
4. You can specify the programming language and display style.
5. Click the "Highlight" button to preview the code highlight.
5. Click the **Insert** button, then the content will be inserted to the Windows Live Writer.

## Requirements

Please install [Windows Live Writer](http://windows.microsoft.com/en-us/windows-live/essentials-other#essentials=overviewother)

## Build Installer
Install [Wixtoolset](http://wixtoolset.org/). Then run the following 2 commands:  

    Wixpath\candle.exe -out markdowninlivewriter.wixobj MarkdownInLiveWriter.wxs   
    Wixpath\light.exe -ext WixUIExtension MarkdownInLiveWriter.wixobj


## Credits

This project is using [markdownsharp](http://code.google.com/p/markdownsharp/), which is a open source C# implementation of Markdown processor.

And the wix file is base on the [Mike Stall's post](http://blogs.msdn.com/b/jmstall/archive/2007/10/27/wix-script-for-installing-live-writer-plugins.aspx).

## License

MarkdownInLiveWriter is released under the MIT License. See the bundled LICENSE file for details.

## Chang Log

1. 08/01/2013	add the wix installer file
1. 07/19/2013	support code syntax highlight
1. 07/16/2013	initial version
