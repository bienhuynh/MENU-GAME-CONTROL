﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace QRCoder
{
    public static class PayloadGenerator
    {
        public class WiFi
        {
            private readonly string ssid, password, authenticationMode;
            private readonly bool isHiddenSsid;
            public WiFi(string ssid, string password, Authentication authenticationMode, bool isHiddenSSID = false)
            {
                this.ssid = EscapeInput(ssid);
                this.ssid = isHexStyle(this.ssid) ? "\"" + this.ssid + "\"" : this.ssid;
                this.password = EscapeInput(password);
                this.password = isHexStyle(this.password) ? "\"" + this.password + "\"" : this.password;
                this.authenticationMode = authenticationMode.ToString();
                this.isHiddenSsid = isHiddenSSID;
            }

            public override string ToString()
            {
                return
                    $"WIFI:T:{this.authenticationMode};S:{this.ssid};P:{this.password};{(this.isHiddenSsid ? "H:true" : string.Empty)};";
            }

            public enum Authentication
            {
                WEP,
                WPA,
                nopass
            }
        }

        public class Mail
        {
            private readonly string mailReceiver, subject, message;
            private readonly MailEncoding encoding;

            public Mail(string mailReceiver, MailEncoding encoding = MailEncoding.MAILTO)
            {
                this.mailReceiver = mailReceiver;
                this.subject = this.message = string.Empty;
                this.encoding = encoding;
            }

            public Mail(string mailReceiver, string subject, MailEncoding encoding = MailEncoding.MAILTO)
            {
                this.mailReceiver = mailReceiver;
                this.subject = subject;
                this.message = string.Empty;
                this.encoding = encoding;
            }

            public Mail(string mailReceiver, string subject, string message, MailEncoding encoding = MailEncoding.MAILTO)
            {
                this.mailReceiver = mailReceiver;
                this.subject = subject;
                this.message = message;
                this.encoding = encoding;
            }

            public override string ToString()
            {
                switch (this.encoding)
                {
                    case MailEncoding.MAILTO:
                        return
                            $"mailto:{this.mailReceiver}?subject={System.Uri.EscapeDataString(this.subject)}&body={System.Uri.EscapeDataString(this.message)}";
                    case MailEncoding.MATMSG:
                        return
                            $"MATMSG:TO:{this.mailReceiver};SUB:{EscapeInput(this.subject)};BODY:{EscapeInput(this.message)};;";
                    case MailEncoding.SMTP:
                        return
                            $"SMTP:{this.mailReceiver}:{EscapeInput(this.subject, true)}:{EscapeInput(this.message, true)}";
                    default:
                        return this.mailReceiver;
                }
            }

            public enum MailEncoding
            {
                MAILTO,
                MATMSG,
                SMTP
            }
        }

        public class SMS
        {
            private readonly string number, subject;
            private readonly SMSEncoding encoding;

            public SMS(string number, SMSEncoding encoding = SMSEncoding.SMS)
            {
                this.number = number;
                this.subject = string.Empty;
                this.encoding = encoding;
            }

            public SMS(string number, string subject, SMSEncoding encoding = SMSEncoding.SMS)
            {
                this.number = number;
                this.subject = subject;
                this.encoding = encoding;
            }

            public override string ToString()
            {
                switch (this.encoding)
                {
                    case SMSEncoding.SMS:
                        return $"sms:{this.number}?body={System.Uri.EscapeDataString(this.subject)}";
                    case SMSEncoding.SMS_iOS:
                        return $"sms:{this.number};body={System.Uri.EscapeDataString(this.subject)}";
                    case SMSEncoding.SMSTO:
                        return $"SMSTO:{this.number}:{this.subject}";
                    default:
                        return "sms:";
                }
            }

            public enum SMSEncoding
            {
                SMS,
                SMSTO,
                SMS_iOS
            }
        }

        public class MMS
        {
            private readonly string number, subject;
            private readonly MMSEncoding encoding;

            public MMS(string number, MMSEncoding encoding = MMSEncoding.MMS)
            {
                this.number = number;
                this.subject = string.Empty;
                this.encoding = encoding;
            }

            public MMS(string number, string subject, MMSEncoding encoding = MMSEncoding.MMS)
            {
                this.number = number;
                this.subject = subject;
                this.encoding = encoding;
            }

            public override string ToString()
            {
                switch (this.encoding)
                {
                    case MMSEncoding.MMSTO:
                        return $"mmsto:{this.number}?subject={System.Uri.EscapeDataString(this.subject)}";
                    case MMSEncoding.MMS:
                        return $"mms:{this.number}?body={System.Uri.EscapeDataString(this.subject)}";
                    default:
                        return "mms:";
                }
            }

            public enum MMSEncoding
            {
                MMS,
                MMSTO
            }
        }

        public class Geolocation
        {
            private readonly string latitude, longitude;
            private readonly GeolocationEncoding encoding;
            public Geolocation(string latitude, string longitude, GeolocationEncoding encoding = GeolocationEncoding.GEO)
            {
                this.latitude = latitude.Replace(",",".");
                this.longitude = longitude.Replace(",", ".");
                this.encoding = encoding;
            }

            public override string ToString()
            {
                switch (this.encoding)
                {
                    case GeolocationEncoding.GEO:
                        return $"geo:{this.latitude},{this.longitude}";
                    case GeolocationEncoding.GoogleMaps:
                        return $"http://maps.google.com/maps?q={this.latitude},{this.longitude}";
                    default:
                        return "geo:";
                }
            }

            public enum GeolocationEncoding
            {
                GEO,
                GoogleMaps
            }
        }

        public class PhoneNumber
        {
            private readonly string number;
            public PhoneNumber(string number)
            {
                this.number = number;
            }

            public override string ToString()
            {
                return $"tel:{this.number}";
            }
        }

        public class SkypeCall
        {
            private readonly string skypeUsername;
            public SkypeCall(string skypeUsername)
            {
                this.skypeUsername = skypeUsername;
            }

            public override string ToString()
            {
                return $"skype:{this.skypeUsername}?call";
            }
        }

        public class Url
        {
            private readonly string url;
            public Url(string url)
            {
                this.url = url;
            }

            public override string ToString()
            {
                return (!this.url.StartsWith("http") ? "http://" + this.url : this.url);
            }
        }

        public class Bookmark
        {
            private readonly string url, title;
            public Bookmark(string url, string title)
            {
                this.url = EscapeInput(url);
                this.title = EscapeInput(title);
            }

            public override string ToString()
            {
                return $"MEBKM:TITLE:{this.title};URL:{this.url};;";
            }
        }

        public class BitcoinAddress
        {
            private readonly string address, label, message;
            private readonly double? amount;

            public BitcoinAddress(string address, double? amount, string label = null, string message = null)
            {
                this.address = address;

                if (!string.IsNullOrEmpty(label))
                {
                    this.label = Uri.EscapeUriString(label);
                }

                if (!string.IsNullOrEmpty(message))
                {
                    this.message = Uri.EscapeUriString(message);
                }

                this.amount = amount;
            }

            public override string ToString()
            {
                string query = null;

                var queryValues = new List<KeyValuePair<string,string>>{
                  new KeyValuePair<string, string>(nameof(label), label),
                  new KeyValuePair<string, string>(nameof(message), message),
                  new KeyValuePair<string, string>(nameof(amount), amount.HasValue ? amount.Value.ToString("#.########", CultureInfo.InvariantCulture) : null)
                };

                if (queryValues.Any(keyPair => !string.IsNullOrEmpty(keyPair.Value)))
                {
                    query = "?" + string.Join("&", queryValues
                        .Where(keyPair => !string.IsNullOrEmpty(keyPair.Value))
                        .Select(keyPair => $"{keyPair.Key}={keyPair.Value}")
                        .ToArray());
                }

                return $"bitcoin:{address}{query}";
            }
        }

        public class Girocode
        {
            //Keep in mind, that the ECC level has to be set to "M" when generating a Girocode!
            //Girocode specification: http://www.europeanpaymentscouncil.eu/index.cfm/knowledge-bank/epc-documents/quick-response-code-guidelines-to-enable-data-capture-for-the-initiation-of-a-sepa-credit-transfer/epc069-12-quick-response-code-guidelines-to-enable-data-capture-for-the-initiation-of-a-sepa-credit-transfer1/

            private string br = "\n";
            private readonly string iban, bic, name, purposeOfCreditTransfer, remittanceInformation, messageToGirocodeUser;
            private readonly decimal amount;
            private readonly GirocodeVersion version;
            private readonly GirocodeEncoding encoding;
            private readonly TypeOfRemittance typeOfRemittance;
                       

            /// <summary>
            /// Generates the payload for a Girocode (QR-Code with credit transfer information).
            /// Attention: When using Girocode payload, QR code must be generated with ECC level M!
            /// </summary>
            /// <param name="iban">Account number of the Beneficiary. Only IBAN is allowed.</param>
            /// <param name="bic">BIC of the Beneficiary Bank.</param>
            /// <param name="name">Name of the Beneficiary.</param>
            /// <param name="amount">Amount of the Credit Transfer in Euro.
            /// (Amount must be more than 0.01 and less than 999999999.99)</param>
            /// <param name="remittanceInformation">Remittance Information (Purpose-/reference text). (optional)</param>
            /// <param name="typeOfRemittance">Type of remittance information. Either structured (e.g. ISO 11649 RF Creditor Reference) and max. 35 chars or unstructured and max. 140 chars.</param>
            /// <param name="purposeOfCreditTransfer">Purpose of the Credit Transfer (optional)</param>
            /// <param name="messageToGirocodeUser">Beneficiary to originator information. (optional)</param>
            /// <param name="version">Girocode version. Either 001 or 002. Default: 001.</param>
            /// <param name="encoding">Encoding of the Girocode payload. Default: ISO-8859-1</param>
            public Girocode(string iban, string bic, string name, decimal amount, string remittanceInformation = "", TypeOfRemittance typeOfRemittance = TypeOfRemittance.Unstructured, string purposeOfCreditTransfer = "", string messageToGirocodeUser = "", GirocodeVersion version = GirocodeVersion.Version1, GirocodeEncoding encoding = GirocodeEncoding.ISO_8859_1)
            {
                this.version = version;
                this.encoding = encoding;
                if (!IsValidIban(iban))
                    throw new GirocodeException("The IBAN entered isn't valid.");
                this.iban = iban.Replace(" ","").ToUpper();
                if (!IsValidBic(bic))
                    throw new GirocodeException("The BIC entered isn't valid.");
                this.bic = bic.Replace(" ", "").ToUpper();
                if (name.Length > 70)
                    throw new GirocodeException("(Payee-)Name must be shorter than 71 chars.");
                this.name = name;
                if (amount.ToString().Replace(",", ".").Contains(".") && amount.ToString().Replace(",",".").Split('.')[1].TrimEnd('0').Length > 2)
                    throw new GirocodeException("Amount must have less than 3 digits after decimal point.");
                if (amount < 0.01m || amount > 999999999.99m)
                    throw new GirocodeException("Amount has to at least 0.01 and must be smaller or equal to 999999999.99.");
                this.amount = amount;
                if (purposeOfCreditTransfer.Length > 4)
                    throw new GirocodeException("Purpose of credit transfer can only have 4 chars at maximum.");
                this.purposeOfCreditTransfer = purposeOfCreditTransfer;
                if (typeOfRemittance.Equals(TypeOfRemittance.Unstructured) && remittanceInformation.Length > 140)
                    throw new GirocodeException("Unstructured reference texts have to shorter than 141 chars.");
                if (typeOfRemittance.Equals(TypeOfRemittance.Structured) && remittanceInformation.Length > 35)
                    throw new GirocodeException("Structured reference texts have to shorter than 36 chars.");
                this.typeOfRemittance = typeOfRemittance;
                this.remittanceInformation = remittanceInformation;
                if (messageToGirocodeUser.Length > 70)
                    throw new GirocodeException("Message to the Girocode-User reader texts have to shorter than 71 chars.");
                this.messageToGirocodeUser = messageToGirocodeUser;
            }

            public override string ToString()
            {
                var girocodePayload = "BCD" + br;
                girocodePayload += (version.Equals(GirocodeVersion.Version1) ? "001" : "002") + br;
                girocodePayload += (int)encoding + 1 + br;
                girocodePayload += "SCT" + br;
                girocodePayload += bic + br;
                girocodePayload += name + br;
                girocodePayload += iban + br;
                girocodePayload += $"EUR{amount:0.00}".Replace(",",".") + br;
                girocodePayload += purposeOfCreditTransfer + br;
                girocodePayload += (typeOfRemittance.Equals(TypeOfRemittance.Structured)
                    ? remittanceInformation
                    : string.Empty) + br;
                girocodePayload += (typeOfRemittance.Equals(TypeOfRemittance.Unstructured)
                    ? remittanceInformation
                    : string.Empty) + br;
                girocodePayload += messageToGirocodeUser;

                return ConvertStringToEncoding(girocodePayload, encoding.ToString().Replace("_","-"));
            }

            public enum GirocodeVersion
            {
                Version1,
                Version2
            }

            public enum TypeOfRemittance
            {
                Structured,
                Unstructured
            }

            public enum GirocodeEncoding
            {
                UTF_8,
                ISO_8859_1,
                ISO_8859_2,
                ISO_8859_4,
                ISO_8859_5,
                ISO_8859_7,
                ISO_8859_10,
                ISO_8859_15
            }

            public class GirocodeException : Exception
            {
                public GirocodeException()
                {
                }

                public GirocodeException(string message)
                    : base(message)
                {
                }

                public GirocodeException(string message, Exception inner)
                    : base(message, inner)
                {
                }
            }
        }


        public class BezahlCode
        {
            //BezahlCode specification: http://www.bezahlcode.de/wp-content/uploads/BezahlCode_TechDok.pdf

            private readonly string name, iban, bic, account, bnc, sepaReference, reason, creditorId, mandateId, periodicTimeunit;
            private readonly decimal amount;
            private readonly int postingKey, periodicTimeunitRotation;
            private readonly Currency currency;
            private readonly AuthorityType authority;
            private readonly DateTime executionDate, dateOfSignature, periodicFirstExecutionDate, periodicLastExecutionDate;


            /// <summary>
            /// Constructor for contact data
            /// </summary>
            /// <param name="authority">Type of the bank transfer</param>
            /// <param name="name">Name of the receiver (Empfänger)</param>
            /// <param name="account">Bank account (Kontonummer)</param>
            /// <param name="bnc">Bank institute (Bankleitzahl)</param>
            /// <param name="iban">IBAN</param>
            /// <param name="bic">BIC</param>
            /// <param name="reason">Reason (Verwendungszweck)</param>
            public BezahlCode(AuthorityType authority, string name, string account = "", string bnc = "", string iban = "", string bic = "", string reason = "") : this(authority, name, account, bnc, iban, bic, 0, string.Empty, 0, null, null, string.Empty, string.Empty, null, reason, 0, string.Empty, Currency.EUR, null, 1)
            {                                
            }           


            /// <summary>
            /// Constructor for non-SEPA payments
            /// </summary>
            /// <param name="authority">Type of the bank transfer</param>
            /// <param name="name">Name of the receiver (Empfänger)</param>
            /// <param name="account">Bank account (Kontonummer)</param>
            /// <param name="bnc">Bank institute (Bankleitzahl)</param>
            /// <param name="amount">Amount (Betrag)</param>
            /// <param name="periodicTimeunit">Unit of intervall for payment ('M' = monthly, 'W' = weekly)</param>
            /// <param name="periodicTimeunitRotation">Intervall for payment. This value is combined with 'periodicTimeunit'</param>
            /// <param name="periodicFirstExecutionDate">Date of first periodic execution</param>
            /// <param name="periodicLastExecutionDate">Date of last periodic execution</param>
            /// <param name="reason">Reason (Verwendungszweck)</param>
            /// <param name="postingKey">Transfer Key (Textschlüssel, z.B. Spendenzahlung = 69)</param>
            /// <param name="currency">Currency (Währung)</param>
            /// <param name="executionDate">Execution date (Ausführungsdatum)</param>
            public BezahlCode(AuthorityType authority, string name, string account, string bnc, decimal amount, string periodicTimeunit = "", int periodicTimeunitRotation = 0, DateTime? periodicFirstExecutionDate = null, DateTime? periodicLastExecutionDate = null, string reason = "", int postingKey = 0, Currency currency = Currency.EUR, DateTime? executionDate = null) : this(authority, name, account, bnc, string.Empty, string.Empty, amount, periodicTimeunit, periodicTimeunitRotation, periodicFirstExecutionDate, periodicLastExecutionDate, string.Empty, string.Empty, null, reason, postingKey, string.Empty, currency, executionDate, 2)
            {
            }

            /// <summary>
            /// Constructor for SEPA payments
            /// </summary>
            /// <param name="authority">Type of the bank transfer</param>
            /// <param name="name">Name of the receiver (Empfänger)</param>
            /// <param name="iban">IBAN</param>
            /// <param name="bic">BIC</param>
            /// <param name="amount">Amount (Betrag)</param>
            /// <param name="periodicTimeunit">Unit of intervall for payment ('M' = monthly, 'W' = weekly)</param>
            /// <param name="periodicTimeunitRotation">Intervall for payment. This value is combined with 'periodicTimeunit'</param>
            /// <param name="periodicFirstExecutionDate">Date of first periodic execution</param>
            /// <param name="periodicLastExecutionDate">Date of last periodic execution</param>
            /// <param name="creditorId">Creditor id (Gläubiger ID)</param>
            /// <param name="mandateId">Manadate id (Mandatsreferenz)</param>
            /// <param name="dateOfSignature">Signature date (Erteilungsdatum des Mandats)</param>
            /// <param name="reason">Reason (Verwendungszweck)</param>
            /// <param name="postingKey">Transfer Key (Textschlüssel, z.B. Spendenzahlung = 69)</param>
            /// <param name="sepaReference">SEPA reference (SEPA-Referenz)</param>
            /// <param name="currency">Currency (Währung)</param>
            /// <param name="executionDate">Execution date (Ausführungsdatum)</param>
            public BezahlCode(AuthorityType authority, string name, string iban, string bic, decimal amount, string periodicTimeunit = "", int periodicTimeunitRotation = 0, DateTime? periodicFirstExecutionDate = null, DateTime? periodicLastExecutionDate = null, string creditorId = "", string mandateId = "", DateTime? dateOfSignature = null, string reason = "", string sepaReference = "", Currency currency = Currency.EUR, DateTime? executionDate = null) : this(authority, name, string.Empty, string.Empty, iban, bic, amount, periodicTimeunit, periodicTimeunitRotation, periodicFirstExecutionDate, periodicLastExecutionDate, creditorId, mandateId, dateOfSignature, reason, 0, sepaReference, currency, executionDate, 3)
            {
            }




            /// <summary>
            /// Generic constructor. Please use specific (non-SEPA or SEPA) constructor
            /// </summary>
            /// <param name="authority">Type of the bank transfer</param>
            /// <param name="name">Name of the receiver (Empfänger)</param>
            /// <param name="account">Bank account (Kontonummer)</param>
            /// <param name="bnc">Bank institute (Bankleitzahl)</param>
            /// <param name="iban">IBAN</param>
            /// <param name="bic">BIC</param>
            /// <param name="amount">Amount (Betrag)</param>
            /// <param name="periodicTimeunit">Unit of intervall for payment ('M' = monthly, 'W' = weekly)</param>
            /// <param name="periodicTimeunitRotation">Intervall for payment. This value is combined with 'periodicTimeunit'</param>
            /// <param name="periodicFirstExecutionDate">Date of first periodic execution</param>
            /// <param name="periodicLastExecutionDate">Date of last periodic execution</param>
            /// <param name="creditorId">Creditor id (Gläubiger ID)</param>
            /// <param name="mandateId">Manadate id (Mandatsreferenz)</param>
            /// <param name="dateOfSignature">Signature date (Erteilungsdatum des Mandats)</param>
            /// <param name="reason">Reason (Verwendungszweck)</param>
            /// <param name="postingKey">Transfer Key (Textschlüssel, z.B. Spendenzahlung = 69)</param>
            /// <param name="sepaReference">SEPA reference (SEPA-Referenz)</param>
            /// <param name="currency">Currency (Währung)</param>
            /// <param name="executionDate">Execution date (Ausführungsdatum)</param>
            /// <param name="internalMode">Only used for internal state handdling</param>
            public BezahlCode(AuthorityType authority, string name, string account, string bnc, string iban, string bic, decimal amount, string periodicTimeunit = "", int periodicTimeunitRotation = 0, DateTime? periodicFirstExecutionDate = null, DateTime? periodicLastExecutionDate = null, string creditorId = "", string mandateId = "", DateTime? dateOfSignature = null, string reason = "", int postingKey = 0, string sepaReference = "", Currency currency = Currency.EUR, DateTime? executionDate = null, int internalMode = 0)
            {
                //Loaded via "contact-constructor"
                if (internalMode == 1)
                {
                    if (!authority.Equals(AuthorityType.contact) && !authority.Equals(AuthorityType.contact_v2))
                        throw new BezahlCodeException("The constructor without an amount may only ne used with authority types 'contact' and 'contact_v2'.");
                    if (authority.Equals(AuthorityType.contact) && (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(bnc)))
                        throw new BezahlCodeException("When using authority type 'contact' the parameters 'account' and 'bnc' must be set.");

                    if (!authority.Equals(AuthorityType.contact_v2))
                    {
                        var oldFilled = (!string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(bnc));
                        var newFilled = (!string.IsNullOrEmpty(iban) && !string.IsNullOrEmpty(bic));
                        if ((!oldFilled && !newFilled) || (oldFilled && newFilled))
                            throw new BezahlCodeException("When using authority type 'contact_v2' either the parameters 'account' and 'bnc' or the parameters 'iban' and 'bic' must be set. Leave the other parameter pair empty.");
                    }
                }
                else if (internalMode == 2)
                {
                    if (!authority.Equals(AuthorityType.periodicsinglepayment) && !authority.Equals(AuthorityType.singledirectdebit) && !authority.Equals(AuthorityType.singlepayment))
                        throw new BezahlCodeException("The constructor with 'account' and 'bnc' may only be used with 'non SEPA' authority types. Either choose another authority type or switch constructor.");
                    if (authority.Equals(AuthorityType.periodicsinglepayment) && (string.IsNullOrEmpty(periodicTimeunit) || periodicTimeunitRotation == 0))
                        throw new BezahlCodeException("When using 'periodicsinglepayment' as authority type, the parameters 'periodicTimeunit' and 'periodicTimeunitRotation' must be set.");

                }
                else if (internalMode == 3)
                {
                    if (!authority.Equals(AuthorityType.periodicsinglepaymentsepa) && !authority.Equals(AuthorityType.singledirectdebitsepa) && !authority.Equals(AuthorityType.singlepaymentsepa))
                        throw new BezahlCodeException("The constructor with 'iban' and 'bic' may only be used with 'SEPA' authority types. Either choose another authority type or switch constructor.");
                    if (authority.Equals(AuthorityType.periodicsinglepaymentsepa) && (string.IsNullOrEmpty(periodicTimeunit) || periodicTimeunitRotation == 0))
                        throw new BezahlCodeException("When using 'periodicsinglepaymentsepa' as authority type, the parameters 'periodicTimeunit' and 'periodicTimeunitRotation' must be set.");
                }

                this.authority = authority;

                if (name.Length > 70)
                    throw new BezahlCodeException("(Payee-)Name must be shorter than 71 chars.");
                this.name = name;

                if (reason.Length > 27)
                    throw new BezahlCodeException("Reasons texts have to be shorter than 28 chars.");
                this.reason = reason;

                var oldWayFilled = (!string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(bnc));
                var newWayFilled = (!string.IsNullOrEmpty(iban) && !string.IsNullOrEmpty(bic));

                //Non-SEPA payment types
                if (authority.Equals(AuthorityType.periodicsinglepayment) || authority.Equals(AuthorityType.singledirectdebit) || authority.Equals(AuthorityType.singlepayment) || authority.Equals(AuthorityType.contact) || (authority.Equals(AuthorityType.contact_v2) && oldWayFilled))
                {
                    if (!Regex.IsMatch(account.Replace(" ", ""), @"^[0-9]{1,9}$"))
                        throw new BezahlCodeException("The account entered isn't valid.");
                    this.account = account.Replace(" ", "").ToUpper();
                    if(!Regex.IsMatch(bnc.Replace(" ", ""), @"^[0-9]{1,9}$"))
                        throw new BezahlCodeException("The bnc entered isn't valid.");
                    this.bnc = bnc.Replace(" ", "").ToUpper();

                    if (!authority.Equals(AuthorityType.contact) && !authority.Equals(AuthorityType.contact_v2))
                    {
                        if (postingKey < 0 || postingKey >= 100)
                            throw new BezahlCodeException("PostingKey must be within 0 and 99.");
                        this.postingKey = postingKey;
                    }                  
                }

                //SEPA payment types
                if (authority.Equals(AuthorityType.periodicsinglepaymentsepa) || authority.Equals(AuthorityType.singledirectdebitsepa) || authority.Equals(AuthorityType.singlepaymentsepa) || (authority.Equals(AuthorityType.contact_v2) && newWayFilled))
                {
                    if (!IsValidIban(iban))
                        throw new BezahlCodeException("The IBAN entered isn't valid.");
                    this.iban = iban.Replace(" ", "").ToUpper();
                    if (!IsValidBic(bic))
                        throw new BezahlCodeException("The BIC entered isn't valid.");
                    this.bic = bic.Replace(" ", "").ToUpper();

                    if (!authority.Equals(AuthorityType.contact_v2))
                    {
                        if (sepaReference.Length > 35)
                            throw new BezahlCodeException("SEPA reference texts have to be shorter than 36 chars.");
                        this.sepaReference = sepaReference;

                        if (!string.IsNullOrEmpty(creditorId) && !Regex.IsMatch(creditorId.Replace(" ", ""), @"^[a-zA-Z]{2,2}[0-9]{2,2}([A-Za-z0-9]|[\+|\?|/|\-|:|\(|\)|\.|,|']){3,3}([A-Za-z0-9]|[\+|\?|/|\-|:|\(|\)|\.|,|']){1,28}$"))
                            throw new BezahlCodeException("The creditorId entered isn't valid.");
                        this.creditorId = creditorId;
                        if (!string.IsNullOrEmpty(mandateId) && !Regex.IsMatch(mandateId.Replace(" ", ""), @"^([A-Za-z0-9]|[\+|\?|/|\-|:|\(|\)|\.|,|']){1,35}$"))
                            throw new BezahlCodeException("The mandateId entered isn't valid.");
                        this.mandateId = mandateId;
                        if (dateOfSignature != null)
                            this.dateOfSignature = (DateTime)dateOfSignature;
                    }
                }

                //Checks for all payment types
                if (!authority.Equals(AuthorityType.contact) && !authority.Equals(AuthorityType.contact_v2))
                {
                    if (amount.ToString().Replace(",", ".").Contains(".") && amount.ToString().Replace(",", ".").Split('.')[1].TrimEnd('0').Length > 2)
                        throw new BezahlCodeException("Amount must have less than 3 digits after decimal point.");
                    if (amount < 0.01m || amount > 999999999.99m)
                        throw new BezahlCodeException("Amount has to at least 0.01 and must be smaller or equal to 999999999.99.");
                    this.amount = amount;
                    
                    this.currency = currency;

                    if (executionDate == null)
                        this.executionDate = DateTime.Now;
                    else
                    {
                        if (DateTime.Today.Ticks > executionDate.Value.Ticks)
                            throw new BezahlCodeException("Execution date must be today or in future.");
                        this.executionDate = (DateTime)executionDate;
                    }

                    if (authority.Equals(AuthorityType.periodicsinglepayment) || authority.Equals(AuthorityType.periodicsinglepaymentsepa))
                    {
                        if (periodicTimeunit.ToUpper() != "M" && periodicTimeunit.ToUpper() != "W")
                            throw new BezahlCodeException("The periodicTimeunit must be either 'M' (monthly) or 'W' (weekly).");
                        this.periodicTimeunit = periodicTimeunit;
                        if (periodicTimeunitRotation < 1 || periodicTimeunitRotation > 52)
                            throw new BezahlCodeException("The periodicTimeunitRotation must be 1 or greater. (It means repeat the payment every 'periodicTimeunitRotation' weeks/months.");
                        this.periodicTimeunitRotation = periodicTimeunitRotation;
                        if (periodicFirstExecutionDate != null)
                            this.periodicFirstExecutionDate = (DateTime)periodicFirstExecutionDate;
                        if (periodicLastExecutionDate != null)
                            this.periodicLastExecutionDate = (DateTime)periodicLastExecutionDate;
                    }

                }
                
                
                
            }

            public override string ToString()
            {
                var bezahlCodePayload = $"bank://{authority}?";
                
                bezahlCodePayload += $"name={Uri.EscapeDataString(name)}&";

                if (!authority.Equals(AuthorityType.contact) && !authority.Equals(AuthorityType.contact_v2))
                {
                    //Handle what is same for all payments

                    if (authority.Equals(AuthorityType.periodicsinglepayment) || authority.Equals(AuthorityType.singledirectdebit) || authority.Equals(AuthorityType.singlepayment))
                    {
                        bezahlCodePayload += $"account={account}&";
                        bezahlCodePayload += $"bnc={bnc}&";
                        if (postingKey > 0)
                            bezahlCodePayload += $"postingkey={postingKey}&";     
                    }
                    else
                    {
                        bezahlCodePayload += $"iban={iban}&";
                        bezahlCodePayload += $"bic={bic}&";

                        if (!string.IsNullOrEmpty(sepaReference))
                            bezahlCodePayload += $"separeference={ Uri.EscapeDataString(sepaReference)}&";

                        if (authority.Equals(AuthorityType.singledirectdebitsepa))
                        {
                            if (!string.IsNullOrEmpty(creditorId))
                                bezahlCodePayload += $"creditorid={ Uri.EscapeDataString(creditorId)}&";
                            if (!string.IsNullOrEmpty(mandateId))
                                bezahlCodePayload += $"mandateid={ Uri.EscapeDataString(mandateId)}&";
                            if (dateOfSignature != null)
                                bezahlCodePayload += $"dateofsignature={dateOfSignature.ToString("ddMMyyyy")}&";
                        }
                    }
                    bezahlCodePayload += $"amount={amount:0.00}&".Replace(".", ",");

                    if (!string.IsNullOrEmpty(reason))
                        bezahlCodePayload += $"reason={ Uri.EscapeDataString(reason)}&";
                    bezahlCodePayload += $"currency={currency}&";
                    bezahlCodePayload += $"executiondate={executionDate.ToString("ddMMyyyy")}&";

                    if (authority.Equals(AuthorityType.periodicsinglepayment) || authority.Equals(AuthorityType.periodicsinglepaymentsepa))
                    {
                        bezahlCodePayload += $"periodictimeunit={periodicTimeunit}&";
                        bezahlCodePayload += $"periodictimeunitrotation={periodicTimeunitRotation}&";
                        if (periodicFirstExecutionDate != null)
                            bezahlCodePayload += $"periodicfirstexecutiondate={periodicFirstExecutionDate.ToString("ddMMyyyy")}&";
                        if (periodicLastExecutionDate != null)
                            bezahlCodePayload += $"periodiclastexecutiondate={periodicLastExecutionDate.ToString("ddMMyyyy")}&";
                    }
                }
                else
                {
                    //Handle what is same for all contacts
                    if (authority.Equals(AuthorityType.contact))
                    {
                        bezahlCodePayload += $"account={account}&";
                        bezahlCodePayload += $"bnc={bnc}&";
                    }
                    else if (authority.Equals(AuthorityType.contact_v2))
                    {
                        if (!string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(bnc))
                        {
                            bezahlCodePayload += $"account={account}&";
                            bezahlCodePayload += $"bnc={bnc}&";
                        }
                        else
                        {
                            bezahlCodePayload += $"iban={iban}&";
                            bezahlCodePayload += $"bic={bic}&";
                        }
                    }

                    if (!string.IsNullOrEmpty(reason))
                        bezahlCodePayload += $"reason={ Uri.EscapeDataString(reason)}&";
                }

                return bezahlCodePayload.Trim('&');
            }

            /// <summary>
            /// ISO 4217 currency codes 
            /// </summary>
            public enum Currency
            {
                AED = 784,
                AFN = 971,
                ALL = 008,
                AMD = 051,
                ANG = 532,
                AOA = 973,
                ARS = 032,
                AUD = 036,
                AWG = 533,
                AZN = 944,
                BAM = 977,
                BBD = 052,
                BDT = 050,
                BGN = 975,
                BHD = 048,
                BIF = 108,
                BMD = 060,
                BND = 096,
                BOB = 068,
                BOV = 984,
                BRL = 986,
                BSD = 044,
                BTN = 064,
                BWP = 072,
                BYR = 974,
                BZD = 084,
                CAD = 124,
                CDF = 976,
                CHE = 947,
                CHF = 756,
                CHW = 948,
                CLF = 990,
                CLP = 152,
                CNY = 156,
                COP = 170,
                COU = 970,
                CRC = 188,
                CUC = 931,
                CUP = 192,
                CVE = 132,
                CZK = 203,
                DJF = 262,
                DKK = 208,
                DOP = 214,
                DZD = 012,
                EGP = 818,
                ERN = 232,
                ETB = 230,
                EUR = 978,
                FJD = 242,
                FKP = 238,
                GBP = 826,
                GEL = 981,
                GHS = 936,
                GIP = 292,
                GMD = 270,
                GNF = 324,
                GTQ = 320,
                GYD = 328,
                HKD = 344,
                HNL = 340,
                HRK = 191,
                HTG = 332,
                HUF = 348,
                IDR = 360,
                ILS = 376,
                INR = 356,
                IQD = 368,
                IRR = 364,
                ISK = 352,
                JMD = 388,
                JOD = 400,
                JPY = 392,
                KES = 404,
                KGS = 417,
                KHR = 116,
                KMF = 174,
                KPW = 408,
                KRW = 410,
                KWD = 414,
                KYD = 136,
                KZT = 398,
                LAK = 418,
                LBP = 422,
                LKR = 144,
                LRD = 430,
                LSL = 426,
                LYD = 434,
                MAD = 504,
                MDL = 498,
                MGA = 969,
                MKD = 807,
                MMK = 104,
                MNT = 496,
                MOP = 446,
                MRO = 478,
                MUR = 480,
                MVR = 462,
                MWK = 454,
                MXN = 484,
                MXV = 979,
                MYR = 458,
                MZN = 943,
                NAD = 516,
                NGN = 566,
                NIO = 558,
                NOK = 578,
                NPR = 524,
                NZD = 554,
                OMR = 512,
                PAB = 590,
                PEN = 604,
                PGK = 598,
                PHP = 608,
                PKR = 586,
                PLN = 985,
                PYG = 600,
                QAR = 634,
                RON = 946,
                RSD = 941,
                RUB = 643,
                RWF = 646,
                SAR = 682,
                SBD = 090,
                SCR = 690,
                SDG = 938,
                SEK = 752,
                SGD = 702,
                SHP = 654,
                SLL = 694,
                SOS = 706,
                SRD = 968,
                SSP = 728,
                STD = 678,
                SVC = 222,
                SYP = 760,
                SZL = 748,
                THB = 764,
                TJS = 972,
                TMT = 934,
                TND = 788,
                TOP = 776,
                TRY = 949,
                TTD = 780,
                TWD = 901,
                TZS = 834,
                UAH = 980,
                UGX = 800,
                USD = 840,
                USN = 997,
                UYI = 940,
                UYU = 858,
                UZS = 860,
                VEF = 937,
                VND = 704,
                VUV = 548,
                WST = 882,
                XAF = 950,
                XAG = 961,
                XAU = 959,
                XBA = 955,
                XBB = 956,
                XBC = 957,
                XBD = 958,
                XCD = 951,
                XDR = 960,
                XOF = 952,
                XPD = 964,
                XPF = 953,
                XPT = 962,
                XSU = 994,
                XTS = 963,
                XUA = 965,
                XXX = 999,
                YER = 886,
                ZAR = 710,
                ZMW = 967,
                ZWL = 932
            }


            /// <summary>
            /// Operation modes of the BezahlCode
            /// </summary>
            public enum AuthorityType
            {
                /// <summary>
                /// Single payment (Überweisung)
                /// </summary>
                [Obsolete]
                singlepayment,
                /// <summary>
                /// Single SEPA payment (SEPA-Überweisung)
                /// </summary>
                singlepaymentsepa,
                /// <summary>
                /// Single debit (Lastschrift)
                /// </summary>
                [Obsolete]
                singledirectdebit,
                /// <summary>
                /// Single SEPA debit (SEPA-Lastschrift)                
                /// </summary>
                singledirectdebitsepa,
                /// <summary>
                /// Periodic payment (Dauerauftrag)
                /// </summary>
                [Obsolete]
                periodicsinglepayment,
                /// <summary>
                /// Periodic SEPA payment (SEPA-Dauerauftrag)
                /// </summary>
                periodicsinglepaymentsepa,
                /// <summary>
                /// Contact data
                /// </summary>
                contact,
                /// <summary>
                /// Contact data V2
                /// </summary>
                contact_v2
            }

            public class BezahlCodeException : Exception
            {
                public BezahlCodeException()
                {
                }

                public BezahlCodeException(string message)
                    : base(message)
                {
                }

                public BezahlCodeException(string message, Exception inner)
                    : base(message, inner)
                {
                }
            }
        }

        public class CalendarEvent
        {
            private readonly string subject, description, location, start, end;
            private readonly EventEncoding encoding;

            public CalendarEvent(string subject, string description, string location, DateTime start, DateTime end, bool allDayEvent, EventEncoding encoding = EventEncoding.Universal)
            {
                this.subject = subject;
                this.description = description;
                this.location = location;
                this.encoding = encoding;
                string dtFormat = allDayEvent ? "yyyyMMdd" : "yyyyMMddTHHmmss";
                this.start = start.ToString(dtFormat);
                this.end = end.ToString(dtFormat);
            }

            public override string ToString()
            {
                var vEvent = $"BEGIN:VEVENT{Environment.NewLine}";
                vEvent += $"SUMMARY:{this.subject}{Environment.NewLine}";
                vEvent += !string.IsNullOrEmpty(this.description) ? $"DESCRIPTION:{this.description}{Environment.NewLine}" : "";
                vEvent += !string.IsNullOrEmpty(this.location) ? $"LOCATION:{this.location}{Environment.NewLine}" : "";
                vEvent += $"DTSTART:{this.start}{Environment.NewLine}";
                vEvent += $"DTEND:{this.end}{Environment.NewLine}";
                vEvent += "END:VEVENT";

                if (this.encoding.Equals(EventEncoding.iCalComplete))
                    vEvent = $@"BEGIN:VCALENDAR{Environment.NewLine}VERSION:2.0{Environment.NewLine}{vEvent}{Environment.NewLine}END:VCALENDAR";

                return vEvent;
            }

            public enum EventEncoding
            {
                iCalComplete,
                Universal
            }
        }

        public class OneTimePassword
        {
            //https://github.com/google/google-authenticator/wiki/Key-Uri-Format
            public OneTimePasswordAuthType Type { get; set; } = OneTimePasswordAuthType.TOTP;
            public string Secret { get; set; }
            public OoneTimePasswordAuthAlgorithm Algorithm { get; set; } = OoneTimePasswordAuthAlgorithm.SHA1;
            public string Issuer { get; set; }
            public string Label { get; set; }
            public int Digits { get; set; } = 6;
            public int? Counter { get; set; } = null;
            public int? Period { get; set; } = 30;

            public enum OneTimePasswordAuthType
            {
                TOTP,
                HOTP,
            }

            public enum OoneTimePasswordAuthAlgorithm
            {
                SHA1,
                SHA256,
                SHA512,
            }

            public override string ToString()
            {
                switch (Type)
                {
                    case OneTimePasswordAuthType.TOTP:
                        return TimeToString();
                    case OneTimePasswordAuthType.HOTP:
                        return HMACToString();
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            // Note: Issuer:Label must only contain 1 : if either of the Issuer or the Label has a : then it is invalid.
            // Defaults are 6 digits and 30 for Period

            private string HMACToString()
            {
                var sb = new StringBuilder("otpauth://hotp/");
                ProcessCommonFields(sb);
                var actualCounter = Counter ?? 1;
                sb.Append("&counter=" + actualCounter);
                return sb.ToString();
            }

            private string TimeToString()
            {
                if (Period == null)
                {
                    throw new Exception("Period must be set when using OneTimePasswordAuthType.TOTP");
                }

                var sb = new StringBuilder("otpauth://totp/");

                ProcessCommonFields(sb);

                if (Period != 30)
                {
                    sb.Append("&period=" + Period);
                }

                return sb.ToString();
            }

            private void ProcessCommonFields(StringBuilder sb)
            {
                if (String40Methods.IsNullOrWhiteSpace(Secret))
                {
                    throw new Exception("Secret must be a filled out base32 encoded string");
                }
                string strippedSecret = Secret.Replace(" ", "");
                string escapedIssuer = null;
                string escapedLabel = null;

                if (!String40Methods.IsNullOrWhiteSpace(Issuer))
                {
                    if (Issuer.Contains(":"))
                    {
                        throw new Exception("Issuer must not have a ':'");
                    }
                    escapedIssuer = Uri.EscapeUriString(Issuer);
                }

                if (!String40Methods.IsNullOrWhiteSpace(Label))
                {
                    if (Label.Contains(":"))
                    {
                        throw new Exception("Label must not have a ':'");
                    }
                    escapedLabel = Uri.EscapeUriString(Label);
                }

                if (escapedLabel != null)
                {
                    if (escapedIssuer != null)
                    {
                        escapedLabel = escapedIssuer + ":" + escapedLabel;
                    }
                }
                else if (escapedIssuer != null)
                {
                    escapedLabel = escapedIssuer;
                }

                if (escapedLabel != null)
                {
                    sb.Append(escapedLabel);
                }

                sb.Append("?secret=" + strippedSecret);

                if (escapedIssuer != null)
                {
                    sb.Append("&issuer=" + escapedIssuer);
                }

                if (Digits != 6)
                {
                    sb.Append("&digits=" + Digits);
                }
            }
        }
        
        public class ShadowSocksConfig
        {
            private readonly string hostname, password, tag, methodStr;
            private readonly Method method;
            private readonly int port;
            private Dictionary<string, string> encryptionTexts = new Dictionary<string, string>() {
                { "Aes128Cfb", "aes-128-cfb" },
                { "Aes128Cfb1", "aes-128-cfb1" },
                { "Aes128Cfb8", "aes-128-cfb8" },
                { "Aes128Ctr", "aes-128-ctr" },
                { "Aes128Ofb", "aes-128-ofb" },
                { "Aes192Cfb", "aes-192-cfb" },
                { "Aes192Cfb1", "aes-192-cfb1" },
                { "Aes192Cfb8", "aes-192-cfb8" },
                { "Aes192Ctr", "aes-192-ctr" },
                { "Aes192Ofb", "aes-192-ofb" },
                { "Aes256Cb", "aes-256-cfb" },
                { "Aes256Cfb1", "aes-256-cfb1" },
                { "Aes256Cfb8", "aes-256-cfb8" },
                { "Aes256Ctr", "aes-256-ctr" },
                { "Aes256Ofb", "aes-256-ofb" },
                { "BfCfb", "bf-cfb" },
                { "Camellia128Cfb", "camellia-128-cfb" },
                { "Camellia192Cfb", "camellia-192-cfb" },
                { "Camellia256Cfb", "camellia-256-cfb" },
                { "Cast5Cfb", "cast5-cfb" },
                { "Chacha20", "chacha20" },
                { "DesCfb", "des-cfb" },
                { "IdeaCfb", "idea-cfb" },
                { "Rc2Cfb", "rc2-cfb" },
                { "Rc4", "rc4" },
                { "Rc4Md5", "rc4-md5" },
                { "Salsa20", "salsa20" },
                { "Salsa20Ctr", "salsa20-ctr" },
                { "SeedCfb", "seed-cfb" },
                { "Table", "table" }
            };


            public ShadowSocksConfig(string hostname, int port, string password, Method method, string tag = null)
            {
                this.hostname = hostname;
                if (port < 1 || port > 65535)
                    throw new ShadowSocksConfigException("Value of 'port' must be within 0 and 65535.");
                this.port = port;
                this.password = password;
                this.method = method;
                this.methodStr = encryptionTexts[method.ToString()];
                this.tag = tag;    
            }

            public override string ToString()
            {
                var connectionString = $"{methodStr}:{password}@{hostname}:{port}";
                var connectionStringEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(connectionString));
                return $"ss://{connectionStringEncoded}{(!string.IsNullOrEmpty(tag) ? $"#{tag}" : string.Empty)}";
            }

            public enum Method
            {
                Aes128Cfb,
                Aes128Cfb1,
                Aes128Cfb8,
                Aes128Ctr,
                Aes128Ofb,
                Aes192Cfb,
                Aes192Cfb1,
                Aes192Cfb8,
                Aes192Ctr,
                Aes192Ofb,
                Aes256Cb,
                Aes256Cfb1,
                Aes256Cfb8,
                Aes256Ctr,
                Aes256Ofb,
                BfCfb,
                Camellia128Cfb,
                Camellia192Cfb,
                Camellia256Cfb,
                Cast5Cfb,
                Chacha20,
                DesCfb,
                IdeaCfb,
                Rc2Cfb,
                Rc4,
                Rc4Md5,
                Salsa20,
                Salsa20Ctr,
                SeedCfb,
                Table
            }

            public class ShadowSocksConfigException : Exception
            {
                public ShadowSocksConfigException()
                {
                }

                public ShadowSocksConfigException(string message)
                    : base(message)
                {
                }

                public ShadowSocksConfigException(string message, Exception inner)
                    : base(message, inner)
                {
                }
            }
        }
        
        public class MoneroTransaction
        {
            private readonly string address, txPaymentId, recipientName, txDescription;
            private readonly float? txAmount;
                       

            public MoneroTransaction(string address, float? txAmount = null, string txPaymentId = null, string recipientName = null, string txDescription = null)
            {
                if (string.IsNullOrEmpty(address))
                    throw new MoneroTransactionException("The address is mandatory and has to be set.");
                this.address = address;
                if (txAmount != null && txAmount <= 0)
                    throw new MoneroTransactionException("Value of 'txAmount' must be greater than 0.");
                this.txAmount = txAmount;
                this.txPaymentId = txPaymentId;
                this.recipientName = recipientName;
                this.txDescription = txDescription;
            }

            public override string ToString()
            {
                var moneroUri = $"monero://{address}{(!string.IsNullOrEmpty(txPaymentId) || !string.IsNullOrEmpty(recipientName) || !string.IsNullOrEmpty(txDescription) || txAmount != null ? "?" : string.Empty)}";
                moneroUri += (!string.IsNullOrEmpty(txPaymentId) ? $"tx_payment_id={Uri.EscapeDataString(txPaymentId)}&" : string.Empty);
                moneroUri += (!string.IsNullOrEmpty(recipientName) ? $"recipient_name={Uri.EscapeDataString(recipientName)}&" : string.Empty);
                moneroUri += (txAmount != null ? $"tx_amount={txAmount.ToString().Replace(",",".")}&" : string.Empty);
                moneroUri += (!string.IsNullOrEmpty(txDescription) ? $"tx_description={Uri.EscapeDataString(txDescription)}" : string.Empty);
                return moneroUri.TrimEnd('&');
            }
                        

            public class MoneroTransactionException : Exception
            {
                public MoneroTransactionException()
                {
                }

                public MoneroTransactionException(string message)
                    : base(message)
                {
                }

                public MoneroTransactionException(string message, Exception inner)
                    : base(message, inner)
                {
                }
            }
        }


        private static bool IsValidIban(string iban)
        {
            return Regex.IsMatch(iban.Replace(" ", ""), @"[a-zA-Z]{2}[0-9]{2}[a-zA-Z0-9]{4}[0-9]{7}([a-zA-Z0-9]?){0,16}");
        }

        private static bool IsValidBic(string bic)
        {
            return Regex.IsMatch(bic.Replace(" ", ""), @"([a-zA-Z]{4}[a-zA-Z]{2}[a-zA-Z0-9]{2}([a-zA-Z0-9]{3})?)");
        }

        private static string ConvertStringToEncoding(string message, string encoding)
        {
            Encoding iso = Encoding.GetEncoding(encoding);
            Encoding utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(message);
            byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
#if NET40
            return iso.GetString(isoBytes);
#else
                return iso.GetString(isoBytes,0, isoBytes.Length);
            #endif
        }

        private static string EscapeInput(string inp, bool simple = false)
        {
            char[] forbiddenChars = {'\\', ';', ',', ':'};
            if (simple)
            {
                forbiddenChars = new char[1] {':'};
            }
            foreach (var c in forbiddenChars)
            {
                inp = inp.Replace(c.ToString(), "\\" + c);
            }
            return inp;
        }

        private static bool isHexStyle(string inp)
        {
            return (System.Text.RegularExpressions.Regex.IsMatch(inp, @"\A\b[0-9a-fA-F]+\b\Z") || System.Text.RegularExpressions.Regex.IsMatch(inp, @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"));
        }
    }
}
