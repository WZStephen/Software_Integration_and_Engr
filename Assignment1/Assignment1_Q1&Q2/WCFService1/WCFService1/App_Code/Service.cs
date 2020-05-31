﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
	public int SecretNumber(int lower, int upper){
		DateTime currentDate = DateTime.Now;
		int seed = (int)currentDate.Ticks;
		Random random = new Random(seed);
		int sNumber = random.Next(lower, upper);
		return sNumber;
	}
	public string checkNumber(int userNum, int SecretNum) {
		if (userNum == SecretNum) {
			return "correct";
		}
		else {
			if (userNum > SecretNum){
				return "too big";
			}
			else {
				return "too small";
			}
		}

	}

}
