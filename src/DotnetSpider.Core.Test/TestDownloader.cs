﻿using DotnetSpider.Core.Downloader;
using System.Threading.Tasks;

namespace DotnetSpider.Core.Test
{
	public class TestDownloader : BaseDownloader
	{
		protected override Task<Page> DowloadContent(Request request, ISpider spider)
		{
			var site = spider.Site;
			var page = new Page(request)
			{
				Content = "aabbcccdefg下载人数100"
			};
			return Task.FromResult(page);
		}
	}
}
