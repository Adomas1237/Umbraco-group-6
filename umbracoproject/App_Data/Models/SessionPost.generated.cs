//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Session</summary>
	[PublishedContentModel("sessionPost")]
	public partial class SessionPost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sessionPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SessionPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SessionPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("descriptionSession")]
		public IHtmlString DescriptionSession
		{
			get { return this.GetPropertyValue<IHtmlString>("descriptionSession"); }
		}

		///<summary>
		/// Room
		///</summary>
		[ImplementPropertyType("roomSession")]
		public string RoomSession
		{
			get { return this.GetPropertyValue<string>("roomSession"); }
		}

		///<summary>
		/// Speaker
		///</summary>
		[ImplementPropertyType("speakerSession")]
		public IEnumerable<IPublishedContent> SpeakerSession
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("speakerSession"); }
		}

		///<summary>
		/// Tags
		///</summary>
		[ImplementPropertyType("tagsSession")]
		public string TagsSession
		{
			get { return this.GetPropertyValue<string>("tagsSession"); }
		}

		///<summary>
		/// Topic
		///</summary>
		[ImplementPropertyType("topicSession")]
		public string TopicSession
		{
			get { return this.GetPropertyValue<string>("topicSession"); }
		}
	}
}
