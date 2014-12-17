﻿using System;
using CookComputing.XmlRpc;
namespace Drupal7.Services
{
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public struct DrupalContact
	{
		public string cid;
		public string category;
		public string recipients;
		public string reply;
		public string weight;
		public string selected;
	}

	/// <summary>
	/// https://www.drupal.org/project/services_contact
	/// </summary>
	public sealed partial class DrupalServices
	{
		public DrupalContact[] ContactIndex()
		{
			this.InitRequest();
			DrupalContact[] res = null;
			try {
				res = drupalServiceSystem.ContactIndex();
			} catch (Exception ex) {
				this.HandleException(ex, "ContactIndex");
			}
			return res;
		}

		public bool ContactSite(string name, string mail, string subject, int cid, string message, bool copy)
		{
			this.InitRequest();
			bool res = false;
			try {
				res = drupalServiceSystem.ContactSite(name, mail, subject, cid, message, copy);
			} catch (Exception ex) {
				this.HandleException(ex, "ContactSite");
			}
			return res;
		}

		public bool ContactPersonal(string name, string mail, string to, string subject, string message, bool copy)
		{
			this.InitRequest();
			bool res = false;
			try {
				res = drupalServiceSystem.ContactPersonal(name, mail, to, subject, message, copy);
			} catch (Exception ex) {
				this.HandleException(ex, "ContactPersonal");
			}
			return res;
		}
	}
}
