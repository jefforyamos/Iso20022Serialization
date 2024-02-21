﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for PostalAddress24.  ISO2002 ID# _9XYD524-EeiU9cctagi5ow.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="PostalAddress24"/>.
    /// </summary>
    public class PostalAddress24XmlAsyncWriter : ISubordinateXmlAsyncWriter<PostalAddress24>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<AddressType3Choice_> addressType;
        private readonly Max70TextXmlAsyncWriter department;
        private readonly Max70TextXmlAsyncWriter subDepartment;
        private readonly Max70TextXmlAsyncWriter streetName;
        private readonly Max16TextXmlAsyncWriter buildingNumber;
        private readonly Max35TextXmlAsyncWriter buildingName;
        private readonly Max70TextXmlAsyncWriter floor;
        private readonly Max16TextXmlAsyncWriter postBox;
        private readonly Max70TextXmlAsyncWriter room;
        private readonly Max16TextXmlAsyncWriter postCode;
        private readonly Max35TextXmlAsyncWriter townName;
        private readonly Max35TextXmlAsyncWriter townLocationName;
        private readonly Max35TextXmlAsyncWriter districtName;
        private readonly Max35TextXmlAsyncWriter countrySubDivision;
        private readonly CountryCodeXmlAsyncWriter country;
        private readonly Max70TextXmlAsyncWriter addressLine;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public PostalAddress24XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<AddressType3Choice_> addressType,
            Max70TextXmlAsyncWriter department,
            Max70TextXmlAsyncWriter subDepartment,
            Max70TextXmlAsyncWriter streetName,
            Max16TextXmlAsyncWriter buildingNumber,
            Max35TextXmlAsyncWriter buildingName,
            Max70TextXmlAsyncWriter floor,
            Max16TextXmlAsyncWriter postBox,
            Max70TextXmlAsyncWriter room,
            Max16TextXmlAsyncWriter postCode,
            Max35TextXmlAsyncWriter townName,
            Max35TextXmlAsyncWriter townLocationName,
            Max35TextXmlAsyncWriter districtName,
            Max35TextXmlAsyncWriter countrySubDivision,
            CountryCodeXmlAsyncWriter country,
            Max70TextXmlAsyncWriter addressLine
        )
        {
            this.addressType = addressType;
            this.department = department;
            this.subDepartment = subDepartment;
            this.streetName = streetName;
            this.buildingNumber = buildingNumber;
            this.buildingName = buildingName;
            this.floor = floor;
            this.postBox = postBox;
            this.room = room;
            this.postCode = postCode;
            this.townName = townName;
            this.townLocationName = townLocationName;
            this.districtName = districtName;
            this.countrySubDivision = countrySubDivision;
            this.country = country;
            this.addressLine = addressLine;
        }
        public async Task WriteAsync(XmlWriter writer, PostalAddress24 valueBeingSerialized, string isoNamespace)
        {
            // AddressType Optional AddressType3Choice AddressType3Choice_
            if ( valueBeingSerialized.AddressType is AddressType3Choice_ populatedAddressType)
            {
                await writer.WriteStartElementAsync(null, "AdrTp", isoNamespace );
                await addressType.WriteAsync(writer, populatedAddressType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Department Optional Max70Text System.String
            if ( valueBeingSerialized.Department is System.String populatedDepartment)
            {
                await writer.WriteStartElementAsync(null, "Dept", isoNamespace );
                await department.WriteAsync(writer, populatedDepartment, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // SubDepartment Optional Max70Text System.String
            if ( valueBeingSerialized.SubDepartment is System.String populatedSubDepartment)
            {
                await writer.WriteStartElementAsync(null, "SubDept", isoNamespace );
                await subDepartment.WriteAsync(writer, populatedSubDepartment, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // StreetName Optional Max70Text System.String
            if ( valueBeingSerialized.StreetName is System.String populatedStreetName)
            {
                await writer.WriteStartElementAsync(null, "StrtNm", isoNamespace );
                await streetName.WriteAsync(writer, populatedStreetName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // BuildingNumber Optional Max16Text System.String
            if ( valueBeingSerialized.BuildingNumber is System.String populatedBuildingNumber)
            {
                await writer.WriteStartElementAsync(null, "BldgNb", isoNamespace );
                await buildingNumber.WriteAsync(writer, populatedBuildingNumber, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // BuildingName Optional Max35Text System.String
            if ( valueBeingSerialized.BuildingName is System.String populatedBuildingName)
            {
                await writer.WriteStartElementAsync(null, "BldgNm", isoNamespace );
                await buildingName.WriteAsync(writer, populatedBuildingName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Floor Optional Max70Text System.String
            if ( valueBeingSerialized.Floor is System.String populatedFloor)
            {
                await writer.WriteStartElementAsync(null, "Flr", isoNamespace );
                await floor.WriteAsync(writer, populatedFloor, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // PostBox Optional Max16Text System.String
            if ( valueBeingSerialized.PostBox is System.String populatedPostBox)
            {
                await writer.WriteStartElementAsync(null, "PstBx", isoNamespace );
                await postBox.WriteAsync(writer, populatedPostBox, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Room Optional Max70Text System.String
            if ( valueBeingSerialized.Room is System.String populatedRoom)
            {
                await writer.WriteStartElementAsync(null, "Room", isoNamespace );
                await room.WriteAsync(writer, populatedRoom, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // PostCode Optional Max16Text System.String
            if ( valueBeingSerialized.PostCode is System.String populatedPostCode)
            {
                await writer.WriteStartElementAsync(null, "PstCd", isoNamespace );
                await postCode.WriteAsync(writer, populatedPostCode, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TownName Optional Max35Text System.String
            if ( valueBeingSerialized.TownName is System.String populatedTownName)
            {
                await writer.WriteStartElementAsync(null, "TwnNm", isoNamespace );
                await townName.WriteAsync(writer, populatedTownName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TownLocationName Optional Max35Text System.String
            if ( valueBeingSerialized.TownLocationName is System.String populatedTownLocationName)
            {
                await writer.WriteStartElementAsync(null, "TwnLctnNm", isoNamespace );
                await townLocationName.WriteAsync(writer, populatedTownLocationName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DistrictName Optional Max35Text System.String
            if ( valueBeingSerialized.DistrictName is System.String populatedDistrictName)
            {
                await writer.WriteStartElementAsync(null, "DstrctNm", isoNamespace );
                await districtName.WriteAsync(writer, populatedDistrictName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CountrySubDivision Optional Max35Text System.String
            if ( valueBeingSerialized.CountrySubDivision is System.String populatedCountrySubDivision)
            {
                await writer.WriteStartElementAsync(null, "CtrySubDvsn", isoNamespace );
                await countrySubDivision.WriteAsync(writer, populatedCountrySubDivision, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Country Optional CountryCode string
            if ( valueBeingSerialized.Country is string populatedCountry)
            {
                await writer.WriteStartElementAsync(null, "Ctry", isoNamespace );
                await country.WriteAsync(writer, populatedCountry, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AddressLine Collection Max70Text System.String
            foreach ( var item in valueBeingSerialized.AddressLine)
            {
                await writer.WriteStartElementAsync(null, "AdrLine", isoNamespace );
                await addressLine.WriteAsync(writer, item , isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
