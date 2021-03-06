﻿// This file is part of AlarmWorkflow.
// 
// AlarmWorkflow is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AlarmWorkflow is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AlarmWorkflow.  If not, see <http://www.gnu.org/licenses/>.

using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Linq;
using AlarmWorkflow.Shared.Core;

namespace AlarmWorkflow.Job.Geocoding.Provider
{
    [Export("OpenStreetMap", typeof(IGeoCoder))]
    [Information(DisplayName = "ExportOpenStreetMapDisplayName", Description = "ExportOpenStreetMapDescription")]
    class OpenStreetMap : IGeoCoder
    {
        #region IGeoCoder Members

        string IGeoCoder.UrlPattern
        {
            get { return "http://nominatim.openstreetmap.org/search?format=xml&street{0}&city={1}"; }
        }

        bool IGeoCoder.IsApiKeyRequired
        {
            get { return false; }
        }

        string IGeoCoder.ApiKey { get; set; }

        GeocoderLocation IGeoCoder.Geocode(PropertyLocation address)
        {
            string queryAdress = string.Format(((IGeoCoder)this).UrlPattern, HttpUtility.UrlEncode(address.Street + " " + address.StreetNumber), HttpUtility.UrlEncode(address.City));

            WebRequest request = WebRequest.Create(queryAdress);
            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    XDocument document = XDocument.Load(stream);

                    XElement placeElement = document.Descendants("place").FirstOrDefault();

                    if (placeElement != null)
                    {
                        XAttribute longitudeElement = placeElement.Attribute("lon");
                        XAttribute latitudeElement = placeElement.Attribute("lat");

                        if (longitudeElement != null && latitudeElement != null)
                        {
                            return new GeocoderLocation()
                            {
                                Longitude = double.Parse(longitudeElement.Value, CultureInfo.InvariantCulture),
                                Latitude = double.Parse(latitudeElement.Value, CultureInfo.InvariantCulture)
                            };
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
