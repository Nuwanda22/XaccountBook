﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLogger
{
	public class SMSReceivedEventArgs : EventArgs
	{
		public string Address { get; set; }
		public string Message { get; set; }
	}
}
