using System.Configuration;

namespace SetYourProxy.Config
{
	public class ProxyPacSection : ConfigurationSection
	{
		[ConfigurationProperty("proxyPacUrls", IsDefaultCollection = false)]
		[ConfigurationCollection(typeof(ProxyPacUrls), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap, RemoveItemName = "remove")]
		public ProxyPacUrls ProxyPacUrls
		{
			get { return (ProxyPacUrls)base["proxyPacUrls"]; }
			set { base["proxyPacUrls"] = value; }
		}
	}

	public class ProxyPacUrls : ConfigurationElementCollection
	{
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ProxyPacUrl)element).Code;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ProxyPacUrl();
		}

		public ProxyPacUrl this[int i]
		{
			get
			{
				return (ProxyPacUrl)BaseGet(i);
			}
		}

		public new ProxyPacUrl this[string key]
		{
			get
			{
				return (ProxyPacUrl)BaseGet(key);
			}
		}
	}

	public class ProxyPacUrl : ConfigurationElement
	{
		[ConfigurationProperty("code", IsRequired = true, IsKey = true)]
		public string Code
		{
			get { return (string)base["code"]; }
			set { base["code"] = value; }
		}

		[ConfigurationProperty("pacUrl", IsRequired = true)]
		public string PacUrl
		{
			get { return (string)base["pacUrl"]; }
			set { base["pacUrl"] = value; }
		}

		public override string ToString()
		{
			return Code;
		}
	}
}
