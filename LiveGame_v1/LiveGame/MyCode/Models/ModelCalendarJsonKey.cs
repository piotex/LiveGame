﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.Calendar.Models
{
	public class ModelCalendarJsonKey
	{
		public ModelCalendarJsonKey_SubModel installed { get; set; }
	}

	public class ModelCalendarJsonKey_SubModel
	{
		public string client_id { get; set; } 
		public string project_id { get; set; }
		public string auth_uri { get; set; }
		public string token_uri { get; set; }
		public string auth_provider_x509_cert_url { get; set; }
		public string client_secret { get; set; }
		public List<string> redirect_uris { get; set; } 
	}
}
