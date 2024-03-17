using BeneficialStrategies.Iso20022.pain;
using Beneficial = BeneficialStrategies.Iso20022;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ReportParameter2Choice;
using BeneficialStrategies.Iso20022.Choices.AmountAndRateFormat2Choice;

public static class Sample
{
	public static CustomerCreditTransferInitiationV11 CustomerCreditTransferInitiationV11 = new Beneficial.pain.CustomerCreditTransferInitiationV11
	{
		GroupHeader = new()
		{
			MessageIdentification = "ABC/120928/CCT001",
			CreationDateTime = new DateTime(2012, 09, 28, 14, 7, 0),
			NumberOfTransactions = "3",
			ControlSum = 11_500_000,
			InitiatingParty = new()
			{
				Name = "ABC Corporation",
				PostalAddress = new()
				{
					StreetName = "Times Square",
					BuildingNumber = "7",
					PostCode = "NY 10036",
					TownName = "New York",
					Country = "US"
				},
			},
		},
		PaymentInformation = new()
		{
			PaymentInformationIdentification = "ABC/086",
			PaymentMethod = PaymentMethod3Code.CreditTransfer,
			BatchBooking = "false",
			RequestedExecutionDate = new Beneficial.Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2012, 09, 29) },
			Debtor = new()
			{
				Name = "ABC Corporation",
				PostalAddress = new()
				{
					StreetName = "Times Square",
					BuildingNumber = "7",
					PostCode = "NY 10036",
					TownName = "New York",
					Country = "US"
				},
				// Optionally add Contact details, other stuff here
			},
			DebtorAccount = new()
			{
				Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
				{
					Identification = "00125574999",
				},
				// Lots more info you can add here
			},
			DebtorAgent = new()
			{
				FinancialInstitutionIdentification = new()
				{
					BICFI = "BBBBUS33",
					// Lots more identifying information you can add here
				},
			},
			CreditTransferTransactionInformation =
			[
				new()
				{
					PaymentIdentification = new ()
					{
						InstructionIdentification = "ABC/120928/CCT001/01",
						EndToEndIdentification = "ABC/4562/2012-09-08",
					},
					Amount = new Beneficial.Choices.AmountType4Choice.InstructedAmount{ Currency = "JPY", Amount = 10_000_000m }, // {    = 10_000_000m },
					ChargeBearer = ChargeBearerType1Code.Shared,
					CreditorAgent = new()
					{
						FinancialInstitutionIdentification = new()
						{
							BICFI = "AAAAGB2L",
                            // Tons of more identifying information you can optionally add here
                        },
                        // Optionally add branch information here
                    },
					Creditor = new()
					{
						Name = "DEF Electronics",
						PostalAddress = new()
						{
							AddressLine = [
								"Corn Exchange 5th Floor",
								"Mark Lane 55",
								"EC3R7NE London",
								"GB"
								]
						},
                        // Optionally add ContactDetails, CountryOfResidence, Identification here
                    },
					CreditorAccount = new()
					{
						Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
						{
							Identification = "23683707994125",
                            // Optionally add issuer, schema name here 
                        },
					},
					Purpose = new Beneficial.Choices.Purpose2Choice.Code
					{
						Value = ExternalPurpose1Code.PurchaseSaleOfGoods,
					},
					RemittanceInformation = new()
					{
						Structured =
							new()
							{
								ReferredDocumentInformation =
									new()
									{
										Type = new()
										{
											CodeOrProprietary = new Beneficial.Choices.ReferredDocumentType3Choice.Code
											{
												Value = DocumentType6Code.CommercialInvoice,
											},
										},
										Number = "4562",
										RelatedDate = new DateOnly(2012,09,08),
                                        // Optionally add line details here
                                    }
								,
                                // Add more types of remittances here, use shift-spacebar for pop-up help
                            }
						,
                        // Optionally add Unstructured information here
                    },
                    // LOTS more stuff you can add at this level
                }, // end of credit transfer 1
                new ()
				{
					PaymentIdentification = new()
					{
						InstructionIdentification = "ABC/120928/CCT001/2",
						EndToEndIdentification = "ABC/ABC-13679/2012-09-15"
					},
					Amount = new Beneficial.Choices.AmountType4Choice.InstructedAmount{ Currency = "EUR", Amount = 500_000m }, 
					ChargeBearer = ChargeBearerType1Code.BorneByCreditor,
					CreditorAgent = new()
					{
						 FinancialInstitutionIdentification = new()
						 {
							 BICFI = "DDDDBEBB",
						 }
					},
					Creditor = new()
					{
						Name = "GHI Semiconductors",
						PostalAddress = new()
						{
							StreetName = "Avenue Brugmann",
							BuildingNumber = "415",
							PostCode = "1180",
							TownName = "Brussels",
							Country = "BE"
						}
					},
					CreditorAccount = new()
					{
						Identification = new Beneficial.Choices.AccountIdentification4Choice.IBAN()
						{
							 Value = "BE30001216371411"
						}
					},
					 InstructionForCreditorAgent = new()
					 {
						 Code = ExternalCreditorAgentInstruction1Code.PhoneBeneficiary,
						 InstructionInformation = "+32/2/2222222",
					 },
					 Purpose = new Beneficial.Choices.Purpose2Choice.Code { Value = ExternalPurpose1Code.PurchaseSaleOfGoods },
					 RemittanceInformation = new()
					 {
						Structured = new()
						 {
							 ReferredDocumentInformation = new()
							 {
								 Type = new()
								 {
									 CodeOrProprietary = new Beneficial.Choices.ReferredDocumentType3Choice.Code{ Value = DocumentType6Code.CommercialInvoice },
								 },
								  Number = "ABC-13679",
								 RelatedDate = new DateOnly(2012,09,15)
							 }
						 }
					 }
				},
				new ()
				{
					PaymentIdentification = new()
					{
						InstructionIdentification = "ABC/120928/CCT001/3",
						EndToEndIdentification = "ABC/987-AC/2012-09-27"
					},
					Amount = new Beneficial.Choices.AmountType4Choice.InstructedAmount{ Currency = "USD", Amount = 1_000_000m }, 
					ChargeBearer = ChargeBearerType1Code.Shared,
					CreditorAgent = new()
					{
						 FinancialInstitutionIdentification = new()
						 {
							 BICFI = "BBBBUS66",
						 }
					},
					Creditor = new()
					{
						Name = "ABC Corporation",
						PostalAddress = new()
						{
							 Department = "Treasury department",
							StreetName = "Bush Street",
							BuildingNumber = "13",
							PostCode = "CA 94108",
							TownName = "San Francisco",
							Country = "US"
						}
					},
					CreditorAccount = new()
					{
						Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
						{
							 Identification = "4895623",
						}
					},
					 Purpose = new Beneficial.Choices.Purpose2Choice.Code { Value = ExternalPurpose1Code.IntraCompanyPayment },
					 RemittanceInformation = new()
					 {
						Structured = new()
						 {
							 ReferredDocumentInformation = new()
							 {
								 Type = new()
								 {
									 CodeOrProprietary = new Beneficial.Choices.ReferredDocumentType3Choice.Code{ Value = DocumentType6Code.CommercialInvoice },
								 },
								  Number = "987-AC",
								 RelatedDate = new DateOnly(2012,09,27)
							 }
						 }
					 }
				}
			], // end of collection of CreditTransfer records
			   // LOTS more you can add at this level
		},
		// Optionally add Supplementary data at this level
	};
}