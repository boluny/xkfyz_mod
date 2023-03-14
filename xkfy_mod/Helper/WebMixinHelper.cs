using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace xkfy_mod.Helper
{
	/// <summary>
	/// The URL mapping to use web content into winforms Form control
	/// </summary>
	public static class WebMixinHelper
	{
		static readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();
		static WebMixinHelper()
		{
			//
			// TODO: Add constructor logic here
			//
			dictionary.Add("PreviewStore", "WebContent/PreviewStore/main.html");
		}

		public static string GetContentAbsolutePath(string key) {
            dictionary.TryGetValue(key, out var relPath);
			var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return Path.Combine(outputDirectory, relPath);
		}
	}
}
