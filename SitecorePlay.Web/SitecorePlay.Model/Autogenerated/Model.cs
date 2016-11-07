using System.Diagnostics;
using Sitecore.Data.Items;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Common;
	using System;
	using System.Collections.Generic;
	using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;
#region Header (/sitecore/templates/Sitecore Play/Header/Header)
namespace SitecorePlay.Model.Autogenerated


{
	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Header</para>
	/// <para>ID: {BFA92212-CA4C-4758-BDAB-EE9B137B3EB1}</para>
	/// <para>Path: /sitecore/templates/Sitecore Play/Header/Header</para>
	/// </summary>
	[TemplateMapping("{BFA92212-CA4C-4758-BDAB-EE9B137B3EB1}", "InterfaceMap")]
	public partial interface IHeader : IItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Header</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Multi-Line Text</para>
		/// </summary>
		[IndexField("body")]
		ITextFieldWrapper Body { get; }

		/// <summary>
		/// <para>Template: Header</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Multi-Line Text</para>
		/// </summary>
		[IndexField("body")]
		string BodyValue { get; }

		/// <summary>
		/// <para>Template: Header</para>
        /// <para>Field: Heading</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("heading")]
		ITextFieldWrapper Heading { get; }

		/// <summary>
		/// <para>Template: Header</para>
        /// <para>Field: Heading</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("heading")]
		string HeadingValue { get; }

		/// <summary>
		/// <para>Template: Header</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
		/// </summary>
		IImageFieldWrapper Image { get; }
		string ImageValue { get; }

		/// <summary>
		/// <para>Template: Header</para>
        /// <para>Field: Subheading</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("subheading")]
		ITextFieldWrapper Subheading { get; }

		/// <summary>
		/// <para>Template: Header</para>
        /// <para>Field: Subheading</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("subheading")]
		string SubheadingValue { get; }

	}

	/// <summary>
	/// <para>Template class</para>
    /// <para>/sitecore/templates/Sitecore Play/Header/Header</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{BFA92212-CA4C-4758-BDAB-EE9B137B3EB1}", typeof(Guid))]
	[TemplateMapping("{BFA92212-CA4C-4758-BDAB-EE9B137B3EB1}", "")]
	internal partial class HeaderItem : ItemWrapper, IHeader
	{
		private Item _item = null;

		public HeaderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public HeaderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public HeaderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public HeaderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("body")]
		public virtual ITextFieldWrapper Body
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("Body", "body"); }
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
		[IndexField("body")]
		public string BodyValue
		{
            [DebuggerStepThrough]
			get { return Body.Value; }
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Heading</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("heading")]
		public virtual ITextFieldWrapper Heading
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("Heading", "heading"); }
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Heading</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("heading")]
		public string HeadingValue
		{
            [DebuggerStepThrough]
			get { return Heading.Value; }
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
		public virtual IImageFieldWrapper Image
		{
            [DebuggerStepThrough]
			get { return GetField<ImageFieldWrapper>("Image"); }
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
		public string ImageValue
		{
            [DebuggerStepThrough]
			get { return Image.Value; }
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Subheading</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("subheading")]
		public virtual ITextFieldWrapper Subheading
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("Subheading", "subheading"); }
		}

		/// <summary>
        /// <para>Template: Header</para>
        /// <para>Field: Subheading</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("subheading")]
		public string SubheadingValue
		{
            [DebuggerStepThrough]
			get { return Subheading.Value; }
		}

	
	}
}
#endregion
#region Contact (/sitecore/templates/Sitecore Play/Contact/Contact)
namespace SitecorePlay.Model.Autogenerated
{
	using System;
	using System.Collections.Generic;
	using Fortis.Model;
	using Fortis.Model.Fields;
	using Fortis.Providers;


	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: Contact</para>
	/// <para>ID: {CBA34BF4-1761-44B5-9736-B1AD426C5A5F}</para>
	/// <para>Path: /sitecore/templates/Sitecore Play/Contact/Contact</para>
	/// </summary>
	[TemplateMapping("{CBA34BF4-1761-44B5-9736-B1AD426C5A5F}", "InterfaceMap")]
	public partial interface IContact : IItemWrapper 
	{		
		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: Address</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("address")]
		ITextFieldWrapper Address { get; }

		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: Address</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("address")]
		string AddressValue { get; }

		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("email")]
		ITextFieldWrapper Email { get; }

		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("email")]
		string EmailValue { get; }

		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("phone")]
		ITextFieldWrapper Phone { get; }

		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("phone")]
		string PhoneValue { get; }

		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: SocialMedia</para>
        /// <para>Data type: Rich Text</para>
		/// </summary>
		[IndexField("social_media")]
		IRichTextFieldWrapper SocialMedia { get; }

		/// <summary>
		/// <para>Template: Contact</para>
        /// <para>Field: SocialMedia</para>
        /// <para>Data type: Rich Text</para>
		/// </summary>
		[IndexField("social_media")]
		string SocialMediaValue { get; }

	}

	/// <summary>
	/// <para>Template class</para>
    /// <para>/sitecore/templates/Sitecore Play/Contact/Contact</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{CBA34BF4-1761-44B5-9736-B1AD426C5A5F}", typeof(Guid))]
	[TemplateMapping("{CBA34BF4-1761-44B5-9736-B1AD426C5A5F}", "")]
	internal partial class ContactItem : ItemWrapper, IContact
	{
		private Item _item = null;

		public ContactItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public ContactItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public ContactItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public ContactItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: Address</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("address")]
		public virtual ITextFieldWrapper Address
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("Address", "address"); }
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: Address</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("address")]
		public string AddressValue
		{
            [DebuggerStepThrough]
			get { return Address.Value; }
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("email")]
		public virtual ITextFieldWrapper Email
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("Email", "email"); }
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("email")]
		public string EmailValue
		{
            [DebuggerStepThrough]
			get { return Email.Value; }
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("phone")]
		public virtual ITextFieldWrapper Phone
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("Phone", "phone"); }
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("phone")]
		public string PhoneValue
		{
            [DebuggerStepThrough]
			get { return Phone.Value; }
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: SocialMedia</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("social_media")]
		public virtual IRichTextFieldWrapper SocialMedia
		{
            [DebuggerStepThrough]
			get { return GetField<RichTextFieldWrapper>("Social Media", "social_media"); }
		}

		/// <summary>
        /// <para>Template: Contact</para>
        /// <para>Field: SocialMedia</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
		[IndexField("social_media")]
		public string SocialMediaValue
		{
            [DebuggerStepThrough]
			get { return SocialMedia.Value; }
		}

	
	}
}
#endregion
#region TwitterSettings (/sitecore/templates/Sitecore Play/TwitterFeed/TwitterSettings)
namespace SitecorePlay.Model.Autogenerated
{

	/// <summary>
	/// <para>Template interface</para>
	/// <para>Template: TwitterSettings</para>
	/// <para>ID: {CD862570-A95D-4840-BE22-D8AD6ADC9054}</para>
	/// <para>Path: /sitecore/templates/Sitecore Play/TwitterFeed/TwitterSettings</para>
	/// </summary>
	[TemplateMapping("{CD862570-A95D-4840-BE22-D8AD6ADC9054}", "InterfaceMap")]
	public partial interface ITwitterSettings : IItemWrapper 
	{		
		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessToken</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("accesstoken")]
		ITextFieldWrapper AccessToken { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessToken</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("accesstoken")]
		string AccessTokenValue { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessTokenSecret</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("accesstokensecret")]
		ITextFieldWrapper AccessTokenSecret { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessTokenSecret</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("accesstokensecret")]
		string AccessTokenSecretValue { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerKey</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("consumerkey")]
		ITextFieldWrapper ConsumerKey { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerKey</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("consumerkey")]
		string ConsumerKeyValue { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerSecret</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("consumersecret")]
		ITextFieldWrapper ConsumerSecret { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerSecret</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("consumersecret")]
		string ConsumerSecretValue { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: EnableSendTweet</para>
        /// <para>Data type: Checkbox</para>
		/// </summary>
		[IndexField("enablesendtweet")]
		IBooleanFieldWrapper EnableSendTweet { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: EnableSendTweet</para>
        /// <para>Data type: Checkbox</para>
		/// </summary>
		[IndexField("enablesendtweet")]
		bool EnableSendTweetValue { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: NoOfFeeds</para>
        /// <para>Data type: Number</para>
		/// </summary>
		[IndexField("nooffeeds")]
		INumberFieldWrapper NoOfFeeds { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: NoOfFeeds</para>
        /// <para>Data type: Number</para>
		/// </summary>
		[IndexField("nooffeeds")]
		float NoOfFeedsValue { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: ScreenName</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("screenname")]
		ITextFieldWrapper ScreenName { get; }

		/// <summary>
		/// <para>Template: TwitterSettings</para>
        /// <para>Field: ScreenName</para>
        /// <para>Data type: Single-Line Text</para>
		/// </summary>
		[IndexField("screenname")]
		string ScreenNameValue { get; }

	}

	/// <summary>
	/// <para>Template class</para>
    /// <para>/sitecore/templates/Sitecore Play/TwitterFeed/TwitterSettings</para>
	/// </summary>
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{CD862570-A95D-4840-BE22-D8AD6ADC9054}", typeof(Guid))]
	[TemplateMapping("{CD862570-A95D-4840-BE22-D8AD6ADC9054}", "")]
	internal partial class TwitterSettingsItem : ItemWrapper, ITwitterSettings
	{
		private Item _item = null;

		public TwitterSettingsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }

		public TwitterSettingsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }

		public TwitterSettingsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }

		public TwitterSettingsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			_item = item;
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessToken</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("accesstoken")]
		public virtual ITextFieldWrapper AccessToken
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("AccessToken", "accesstoken"); }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessToken</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("accesstoken")]
		public string AccessTokenValue
		{
            [DebuggerStepThrough]
			get { return AccessToken.Value; }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessTokenSecret</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("accesstokensecret")]
		public virtual ITextFieldWrapper AccessTokenSecret
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("AccessTokenSecret", "accesstokensecret"); }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: AccessTokenSecret</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("accesstokensecret")]
		public string AccessTokenSecretValue
		{
            [DebuggerStepThrough]
			get { return AccessTokenSecret.Value; }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerKey</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("consumerkey")]
		public virtual ITextFieldWrapper ConsumerKey
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("ConsumerKey", "consumerkey"); }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerKey</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("consumerkey")]
		public string ConsumerKeyValue
		{
            [DebuggerStepThrough]
			get { return ConsumerKey.Value; }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerSecret</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("consumersecret")]
		public virtual ITextFieldWrapper ConsumerSecret
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("ConsumerSecret", "consumersecret"); }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: ConsumerSecret</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("consumersecret")]
		public string ConsumerSecretValue
		{
            [DebuggerStepThrough]
			get { return ConsumerSecret.Value; }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: EnableSendTweet</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("enablesendtweet")]
		public virtual IBooleanFieldWrapper EnableSendTweet
		{
            [DebuggerStepThrough]
			get { return GetField<BooleanFieldWrapper>("EnableSendTweet", "enablesendtweet"); }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: EnableSendTweet</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
		[IndexField("enablesendtweet")]
		public bool EnableSendTweetValue
		{
            [DebuggerStepThrough]
			get { return EnableSendTweet.Value; }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: NoOfFeeds</para>
        /// <para>Data type: Number</para>
        /// </summary>
		[IndexField("nooffeeds")]
		public virtual INumberFieldWrapper NoOfFeeds
		{
            [DebuggerStepThrough]
			get { return GetField<NumberFieldWrapper>("NoOfFeeds", "nooffeeds"); }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: NoOfFeeds</para>
        /// <para>Data type: Number</para>
        /// </summary>
		[IndexField("nooffeeds")]
		public float NoOfFeedsValue
		{
            [DebuggerStepThrough]
			get { return NoOfFeeds.Value; }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: ScreenName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("screenname")]
		public virtual ITextFieldWrapper ScreenName
		{
            [DebuggerStepThrough]
			get { return GetField<TextFieldWrapper>("ScreenName", "screenname"); }
		}

		/// <summary>
        /// <para>Template: TwitterSettings</para>
        /// <para>Field: ScreenName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
		[IndexField("screenname")]
		public string ScreenNameValue
		{
            [DebuggerStepThrough]
			get { return ScreenName.Value; }
		}

	
	}
}
#endregion